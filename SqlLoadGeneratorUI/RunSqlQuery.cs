using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlLoadGeneratorUI
{
    #region RunSqlQuery UI Delegates
    public delegate void CountStatusChangedHandler();
    #endregion

    public partial class RunSqlQuery : UserControl
    {
        #region Constructors
        public RunSqlQuery()
        {
            InitializeComponent();

            // Setup the form
            InitForm();
        }
        #endregion

        #region Delegates
        public CountStatusChangedHandler CountStatusChanged;
        #endregion
        
        #region Internal Variables
        ContinuousQuery _continuousQuery = null;
        #endregion

        #region Event Handlers
        private void QueryExecuted(int numberOfExecutions)
        {
            UpdateNumberOfRuns(numberOfExecutions.ToString("n0"));
        }

        private void QueryExecutedMs(TimeSpan spentTimeMs)
        {
            UpdateSpendingTime(spentTimeMs.TotalMilliseconds.ToString("n0"));
        }

        private void QueryAVGQueryDBTime(double avgDBTime)
        {
            UpdateAVGDbTime(avgDBTime.ToString("n0"));
        }

        private void QueryFailed(int numberOfFailures)
        {
            UpdateNumberOfFailures(numberOfFailures.ToString("n0"));
        }

        private void QueryThreadsChanged(int numberOfThreads)
        {
            UpdateNumberOfThreads(numberOfThreads.ToString("n0"));
        }

        private void QueryForciblyStopped()
        {
            ToggleStartButtonEnable(true);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Validate the input fields and start the specified number of 
        /// query instances.
        /// </summary>
        public void StartQuery()
        {
            if (_continuousQuery.RunStatus != RunStatus.Started)
            {
                StartRunSqlQuery();
            }
        }

        /// <summary>
        /// Stop all running query instances.
        /// </summary>
        public void StopQuery()
        {
            StopRunSqlQuery();
        }

        public void CloseQuery()
        {
            CloseRunSqlQuery();
        }
        #endregion 

        #region Thread safe form updates
        delegate void SetTextCallback(string text);
        delegate void SetBoolCallback(bool value);

        private void UpdateNumberOfRuns(string text)
        {
            if (this.textBoxNumberOfRuns.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateNumberOfRuns);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxNumberOfRuns.Text = text;
            }

            CountStatusChanged.DynamicInvoke();
        }

        private void UpdateSpendingTime(string text)
        {
            if (this.txtSpendingTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateSpendingTime);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtSpendingTime.Text = text;
            }

            CountStatusChanged.DynamicInvoke();
        }

        private void UpdateAVGDbTime(string text)
        {
            if (this.txtAVGTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateAVGDbTime);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtAVGTime.Text = text;
            }

            CountStatusChanged.DynamicInvoke();
        }

        


        private void UpdateNumberOfFailures(string text)
        {
            if (this.textBoxNumberOfFailures.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateNumberOfFailures);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxNumberOfFailures.Text = text;
            }

            CountStatusChanged.DynamicInvoke();
        }

        private void UpdateNumberOfThreads(string text)
        {
            if (this.textBoxNumberOfThreads.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(UpdateNumberOfThreads);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxNumberOfThreads.Text = text;
            }

            CountStatusChanged.DynamicInvoke();
        }

        /// <summary>
        /// Clear the # of Runs, # of Failures, # of Queries textboxes
        /// </summary>
        private void ClearCounterTextboxes()
        {
            this.textBoxNumberOfFailures.Text = string.Empty;
            this.textBoxNumberOfRuns.Text = string.Empty;
            //this.textBoxNumberOfThreads.Text = string.Empty;
        }

        /// <summary>
        /// Only the Start or Stop button should be enabled at 1 time
        /// </summary>
        /// <param name="value"></param>
        private void ToggleStartButtonEnable(bool value)
        {
            if (this.buttonStart.InvokeRequired || this.buttonStop.InvokeRequired)
            {
                SetBoolCallback d = new SetBoolCallback(ToggleStartButtonEnable);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                buttonStop.Enabled = !value;
                buttonStart.Enabled = value;
            }
        }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Validate that all fields needed to form a connection string
        /// are filled out.
        /// </summary>
        /// <returns></returns>
        private bool ValidateConnectionStringInputs()
        {
            string errorMessage = string.Empty;

            if (this.textBoxUsername.Text.Trim().Length == 0)
            {
                errorMessage = "No username was provided";
            }

            if (this.textBoxPassword.Text.Trim().Length == 0)
            {
                errorMessage = "No password was provided";
            }

            if (((FormMain)this.FindForm()).ServerName.Trim().Length == 0)
            {
                errorMessage = "No server name was provided";
            }

            if (this.comboBoxDatabase.Text.Trim().Length == 0)
            {
                errorMessage = "No database was provided";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                return true;
            }
            else
            {
                MessageBox.Show (errorMessage, "Invalid Options"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Start up a continuous query object, and wire everything up
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        private void StartContinuousQuery()
        {
            string connectionString = string.Empty;

            // Build the connection string
            connectionString = BuildConnectionString();

            // Instantiate a Continuous Query
            _continuousQuery = new ContinuousQuery(connectionString, this.textBoxQuery.Text
                , this.textBoxUsername.Text, this.textBoxPassword.Text, this.checkBoxDomainAccount.Checked
                , int.Parse(this.maskedTextBoxConcurrentQueries.Text));

            // Wire-up the events
            _continuousQuery.QueryExecuted += new QueryExecutedHandler(QueryExecuted);
            _continuousQuery.QueryExecutedMs += new QueryExecutedMsHandler(QueryExecutedMs);
            _continuousQuery.QueryAVGDBTime += new QueryExecuteAVGHandler(QueryAVGQueryDBTime);
            _continuousQuery.QueryFailed += new QueryFailedHandler(QueryFailed);
            _continuousQuery.QueryThreadsChanged += new QueryThreadsChangedHandler(QueryThreadsChanged);
            _continuousQuery.QueryForciblyStopped += new QueryForciblyStoppedHandler(QueryForciblyStopped);
            // Start the Query
            _continuousQuery.Start();
        }

        /// <summary>
        /// End a continuous query
        /// </summary>
        private void StopContinuousQuery()
        {
            if ((_continuousQuery != null) && (_continuousQuery.RunStatus == RunStatus.Started))
            {
                _continuousQuery.Stop();
            }
        }

        /// <summary>
        /// Build a connection string based on the form inputs
        /// </summary>
        /// <returns></returns>
        private string BuildConnectionString()
        {
            StringBuilder connectionString = new StringBuilder();

            string baseConnectionString = Properties.Settings.Default.ConnectionStringModifiers + ";Initial Catalog={0};Data Source={1};";
            string baseSqlConnectionStringSnippet = "User ID={0};Password={1};";
            string baseIntegratedSecurity = "Integrated Security=SSPI;";
            string baseApplicationName = "Application Name={0};";

            connectionString.Append(string.Format(baseConnectionString, comboBoxDatabase.Text, ((FormMain)this.FindForm()).ServerName));

            // Use either Windows security or SQL Server security
            if (checkBoxDomainAccount.Checked == false)
            {
                connectionString.Append(string.Format(baseSqlConnectionStringSnippet, textBoxUsername.Text, textBoxPassword.Text));
            }
            else
            {
                connectionString.Append(baseIntegratedSecurity);
            }

            if (this.comboBoxApplication.Text.Trim().Length != 0)
            {
                connectionString.Append(string.Format(baseApplicationName, this.comboBoxApplication.Text.Trim()));
            }

            return connectionString.ToString();
        }

        /// <summary>
        /// Validate inputs and start all instances of a query
        /// </summary>
        private void StartRunSqlQuery()
        {
            // Validate inputs
            if (!ValidateConnectionStringInputs())
            {
                return;
            }

            StartContinuousQuery();

            ClearCounterTextboxes();

            ToggleStartButtonEnable(false);
        }

        /// <summary>
        /// Stop all instances of a query.
        /// </summary>
        private void StopRunSqlQuery()
        {
            StopContinuousQuery();

            ToggleStartButtonEnable(true);
        }

        /// <summary>
        /// Stop all instances of a query and remove it from the panel.
        /// </summary>
        private void CloseRunSqlQuery()
        {
            StopContinuousQuery();

            this.Parent.Controls.Remove(this);
        }

        /// <summary>
        /// Intial setup of the user control.
        /// </summary>
        private void InitForm()
        {
            ToggleStartButtonEnable(true);

            checkBoxHidePassword.Checked = true;
            textBoxPassword.UseSystemPasswordChar = true;

            textBoxUsername.Text = Properties.Settings.Default.DefaultUsername;
            comboBoxDatabase.Text = Properties.Settings.Default.DefaultDatabase;
            textBoxPassword.Text = Properties.Settings.Default.DefaultPassword;
            textBoxQuery.Text = Properties.Settings.Default.DefaultQuery;
            comboBoxApplication.Text = Properties.Settings.Default.DefaultApplication;
            maskedTextBoxConcurrentQueries.Text = Properties.Settings.Default.DefaultConcurrentQueryCount.ToString();
            checkBoxDomainAccount.Checked = Properties.Settings.Default.DefaultIsDomainAccount;

            // Load the Databases options from the user preferences
            string[] allDatabases = new string[Properties.Settings.Default.AllDatabases.Count];
            Properties.Settings.Default.AllDatabases.CopyTo(allDatabases, 0);
            comboBoxDatabase.Items.AddRange (allDatabases);

            // Load the Applications options from the user preferences
            string[] allApplications = new string[Properties.Settings.Default.AllApplications.Count];
            Properties.Settings.Default.AllApplications.CopyTo(allApplications, 0);
            comboBoxApplication.Items.AddRange(allApplications);
        }
        #endregion

        #region UI Helpers
        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartRunSqlQuery();
        }
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopRunSqlQuery();
        }


        private void buttonCloseUserControl_Click(object sender, EventArgs e)
        {
            CloseRunSqlQuery();
        }

        private void checkBoxHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHidePassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// When the Query textbox is doubleclicked, select all text.
        /// This may not be the choice for everyone, but it works well for demos
        /// when you copy and paste in code.  For more of an editor feel, it should
        /// be extended.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void textBoxQuery_DoubleClick(object sender, System.EventArgs e)
        {
            this.textBoxQuery.Select(0, this.textBoxQuery.Text.Length);
        }
        #endregion
        
    }
}
