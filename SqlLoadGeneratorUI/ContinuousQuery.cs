using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace SqlLoadGeneratorUI
{
    #region Query Execution Delegates
    // Delegates to handle changes to the Continuous Query status
    public delegate void QueryExecutedHandler(int numberOfExecutions);
    public delegate void QueryExecutedMsHandler(TimeSpan spendingTime);
    public delegate void QueryExecuteAVGHandler(double i);
    public delegate void QueryFailedHandler(int numberOfFailures);
    public delegate void QueryThreadsChangedHandler(int queryThreads);
    public delegate void QueryForciblyStoppedHandler();
    public delegate void QueryElapsedTimeHandler(TimeSpan elapsedTime);
    #endregion

    #region Query Enumerations
    public enum RunStatus
    {
        Started,
        Paused,
        Stopped
    }
    #endregion

    class ContinuousQuery
    {
        #region Imported APIs
        // API for impersonation of a domain account
        [DllImport("advapi32.DLL", SetLastError = true)]
        public static extern int LogonUser(string lpszUsername, string lpszDomain,
        string lpszPassword, int dwLogonType, int dwLogonProvider, out IntPtr
        phToken);
        #endregion

        #region Internal Variables
        private string _connectionString = string.Empty;
        private string _sqlQuery = string.Empty;
        string _username = string.Empty;
        string _password = string.Empty;
        string _domain = string.Empty;
        int _targetConcurrentThreads = 0;
        bool _useWindowsLogin = false;
        string _LogLocation = string.Empty;
        double _executedquery = 0;
        #endregion

        #region Constructors
        public ContinuousQuery(string connectionString, string sqlQuery, string username
            , string password, bool useWindowsLogin, int targetConcurrentThreads)
        {
            _LogLocation = Properties.Settings.Default.ApplicationLogLocation + Properties.Settings.Default.ApplicationLogFilename; 
            _sqlQuery = sqlQuery;
            _connectionString = connectionString;
            _runStatus = RunStatus.Stopped;
            _password = password;
            _useWindowsLogin = useWindowsLogin;
            _targetConcurrentThreads = targetConcurrentThreads;

            if (_useWindowsLogin)
            {
                int slashLocation = username.IndexOf(@"\");

                if (slashLocation == -1)
                {
                    _domain = Environment.MachineName;
                    _username = username;
                }
                else
                {
                    _domain = username.Substring(0, slashLocation);
                    _username = username.Substring(slashLocation + 1);
                }
            }
            else
            {
                _username = username;
            }
        }
        #endregion
        
        #region Properties and Delegates
        // Events
        public QueryExecutedHandler QueryExecuted;

        public QueryExecutedMsHandler QueryExecutedMs;
        public QueryExecuteAVGHandler QueryAVGDBTime;
        public QueryFailedHandler QueryFailed;
        public QueryThreadsChangedHandler QueryThreadsChanged;
        public QueryForciblyStoppedHandler QueryForciblyStopped;
        
        // Properties
        private static RunStatus _runStatus = RunStatus.Stopped;
        public RunStatus RunStatus
        {
            get { return _runStatus; }
        }

        private int _numberOfExecutions = 0;
        public int NumberOfExecutions 
        { 
                get { return _numberOfExecutions; }
        }

        private int _numberOfFailures = 0;
        public int NumberOfFailures
        {
            get { return _numberOfFailures; }
        }

        private int _queryThreads = 0;
        public int QueryThreads 
        {
            get { return _queryThreads; }
        }


        private TimeSpan _queryRunTimeMs;
        public TimeSpan QueryRunTimeMs
        {
            get { return _queryRunTimeMs; }
        }

        public double AVGQueryTimeMs
        {
            get
            {
                return _executedquery / _numberOfExecutions;
            }     
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Start the query; run in a loop until a Stop message is received.
        /// </summary>
        public void Start()
        {
            // Short circuit if it's already running
            if (_runStatus == RunStatus.Started)
            {
                return;
            }

            // Set the flag to signal Query Started
            _runStatus = RunStatus.Started;

            // Start as many many concurrent threads as requested
            for (int i = 0; i < _targetConcurrentThreads; ++i)
            {
                ThreadStart ts = new ThreadStart(InfiniteLoop);
                Thread t = new Thread(ts);
                
                t.Start();
                ++_queryThreads;
                ++Globals._totalThreadCount;
                QueryThreadsChanged.DynamicInvoke(_queryThreads);
            }
        }

        /// <summary>
        /// Set the Stop flag.  The various threads will monitor this flag
        /// And stop
        /// </summary>
        public void Stop()
        {
            _runStatus = RunStatus.Stopped;
            _executedquery = 0;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Use the LogonUser API to get a token from the OS
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private IntPtr GetLoginToken(string domain, string username, string password)
        {
            IntPtr loginToken;
            
            // Get a token for the domain user
            if (LogonUser(username, domain, password, 2, 0, out loginToken) == 0)
            {
                System.Windows.Forms.MessageBox.Show(string.Format("Login Failedfor '{0}\\{1}'", domain, username), "Login Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Stop();
                QueryForciblyStopped.DynamicInvoke();
                //throw new Exception(string.Format("Login failed for '{0}\\{1}'", domain, username));
            }

            return loginToken;
        }
        #endregion
        
        #region Methods executed out of process
        /// <summary>
        /// This method will run indefinitely.  It will only stop when the Stop
        /// flag has been set.  If Domain Account has been set, then impersonate
        /// the domain account.
        /// </summary>
        private void InfiniteLoop()
        {
            WindowsIdentity wi = null;
            WindowsImpersonationContext wic = null;

            // Start impersonating the user if necessary
            if (_useWindowsLogin)
            {
                IntPtr loginToken;
                loginToken = GetLoginToken(_domain, _username, _password);

                if ((int)loginToken != 0)
                {
                    wi = new WindowsIdentity(loginToken);
                    wic = wi.Impersonate();
                }
            }

            // Run the loop until a Stop flag is step
            while (true)
            {
                // Said Stop flag
                if (_runStatus == RunStatus.Stopped)
                {
                    // Increment the counter; let anyone subscripting know
                    --_queryThreads;
                    --Globals._totalThreadCount;
                    QueryThreadsChanged.DynamicInvoke(_queryThreads);
                    return;
                }

                // Kick off the Query 
                ExecuteQuery();
            }
        }
        
        /// <summary>
        /// Excecute the user supplied query
        /// </summary>
        private void ExecuteQuery()
        {
            // We want to capture any problems
            try
            {
                // Create new stopwatch.
                Stopwatch stopwatch = new Stopwatch();
                // Begin timing.
                stopwatch.Start();

                // Make sure our connection is disposed; run the query
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand(_sqlQuery, conn))
                    {
                        comm.ExecuteReader();
                        conn.Close();
                        stopwatch.Stop();
                        

                        // Write result.
                        _queryRunTimeMs = stopwatch.Elapsed;
                        _executedquery= _executedquery+ _queryRunTimeMs.TotalMilliseconds;
                        QueryExecutedMs.DynamicInvoke(_queryRunTimeMs);

                        // Increment the counter; let anyone subscribing know
                        ++_numberOfExecutions;
                        ++Globals._totalCompletedQueryCount;
                        QueryExecuted.DynamicInvoke(_numberOfExecutions);
                        QueryAVGDBTime.DynamicInvoke(AVGQueryTimeMs);

                        return;
                    }
                   
                }
                
            }
            catch (Exception ex)
            {

                ++_numberOfFailures;
                ++Globals._totalFailedQueryCount;
                QueryFailed.DynamicInvoke(_numberOfFailures);

                // Just swallow the error... for now
                //throw ex;

                // Log the error if the Application Logging is turned on
                if (Globals._applicationLogging)
                {
                    try
                    {
                        // TODO:  This logging will cause the application to crash when
                        // simultaneous failures occur in multi-threaded queries.
                        using (StreamWriter sw = new StreamWriter(_LogLocation, true))
                        {
                            StringBuilder errorMessage = new StringBuilder();

                            errorMessage.AppendLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                            errorMessage.AppendLine("Timestamp:  " + DateTime.Now.ToString());
                            errorMessage.AppendLine("Source   :  " + ex.Source);
                            errorMessage.AppendLine("Message  :  " + ex.Message);
                            errorMessage.AppendLine("Stack Trace");
                            errorMessage.AppendLine("-----------");
                            errorMessage.AppendLine(ex.StackTrace);
                            errorMessage.AppendLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                            sw.WriteLine(errorMessage.ToString());
                            sw.Close();
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, "Application Logging Error");
                    }
                }

                if (ex.Message.IndexOf("Login failed") > -1)
                {
                    System.Windows.Forms.MessageBox.Show("Bad Login" + Environment.NewLine + ex.Message, "Login Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    Stop();
                    QueryForciblyStopped.DynamicInvoke();
                    return;
                }
                if (ex.Message.IndexOf("An error has occurred while establishing a connection to the server") > -1)
                {
                    System.Windows.Forms.MessageBox.Show("Bad Connection; either bad server name or security" + Environment.NewLine + ex.Message, "Login Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    Stop();
                    QueryForciblyStopped.DynamicInvoke();
                    return;
                }
            }
        }
        #endregion
    }
}
