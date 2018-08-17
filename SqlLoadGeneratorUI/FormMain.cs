using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlLoadGeneratorUI
{
    public partial class FormMain : Form
    {
        #region Constructors
        public FormMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public string ServerName
        {
            get { return toolStripLabelServer.Text; }
        }
        #endregion

        #region UI Helpers
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Start the application with the user preference for logging
            ToggleLogging(Properties.Settings.Default.ApplicationLogging);

            // Set the default server
            toolStripLabelServer.Text = Properties.Settings.Default.DefaultServer;

            // Update the status counters
            UpdateCountStatus();

            // Load the Applications options from the user preferences
            string[] allServers = new string[Properties.Settings.Default.AllServers.Count];
            Properties.Settings.Default.AllServers.CopyTo(allServers, 0);
            toolStripLabelServer.Items.AddRange(allServers);
        }

        private void toolStripButtonAddQuery_Click(object sender, EventArgs e)
        {
            AddQuery();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonToggleLogging_Click(object sender, EventArgs e)
        {
            // Flip the logging state
            ToggleLogging(!Globals._applicationLogging);
        }

        private void addQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuery();
        }

        private void toggleLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Flip the logging state
            ToggleLogging(!Globals._applicationLogging);
        }

        private void toolStripButtonStartAllQueries_Click(object sender, EventArgs e)
        {
            StartAllQueries();
        }

        private void toolStripButtonStopAllQueries_Click(object sender, EventArgs e)
        {
            StopAllQueries();
        }

        private void startAllQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartAllQueries();
        }

        private void stopAllQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopAllQueries();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CloseAllQueries();
        }

        private void removeAllQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllQueries();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutBox aboutBox = new FormAboutBox();
            aboutBox.ShowDialog();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOptions formOptions = new FormOptions();
            formOptions.ShowDialog();
        }

        private void toolStripButtonResetCounters_Click(object sender, EventArgs e)
        {
            ResetCounters();
        }

        private void resetCountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetCounters();
        }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Flip the status of Application logging.  This determines the behavior
        /// when application errors occur.
        /// </summary>
        /// <param name="applicationLogging">True for logging; False for no logging</param>
        private void ToggleLogging(Boolean applicationLogging)
        {
            if (applicationLogging)
            {
                Globals._applicationLogging = true;
                //this.toolStripButtonToggleLogging.Text = "Turn off logging";
                //this.toolStripButtonToggleLogging.ToolTipText = "The application is currently writing detailed errors messages.";
                this.toolStripStatusLabelLoggingStatus.Text = "Application Logging: On";

            }
            else
            {
                Globals._applicationLogging = false;
                //this.toolStripButtonToggleLogging.Text = "Turn on logging";
                //this.toolStripButtonToggleLogging.ToolTipText = "The application is currently not writing detailed errors messages.";
                this.toolStripStatusLabelLoggingStatus.Text = "Application Logging: Off";
            }
        }

        /// <summary>
        /// Add a new Run Sql Query object to the panel.
        /// </summary>
        private void AddQuery()
        {
            RunSqlQuery rsq = new RunSqlQuery();
            rsq.CountStatusChanged += new CountStatusChangedHandler(UpdateCountStatus);
            flowLayoutPanel1.Controls.Add(rsq);
        }

        /// <summary>
        /// Attempt to start all instances of the RunSqlQuery object on the panel.
        /// </summary>
        private void StartAllQueries()
        {
            foreach (RunSqlQuery rsc in flowLayoutPanel1.Controls.OfType<RunSqlQuery>())
            {
                rsc.StartQuery();
            }
        }

        /// <summary>
        /// Attempt to stop all instances of the RunSqlQuery object on the panel.
        /// </summary>
        private void StopAllQueries()
        {
            foreach (RunSqlQuery rsc in flowLayoutPanel1.Controls.OfType<RunSqlQuery>())
            {
                rsc.StopQuery();
            }
        }

        /// <summary>
        /// Remove all instances of the RunSqlQuery from the panel
        /// </summary>
        private void CloseAllQueries()
        {
            // Since we're dynamically adding controls, we have to do this so we can 
            // iterate over all of them; otherwise we can only iterate through half of them
            RunSqlQuery[] runSqlQueries = flowLayoutPanel1.Controls.OfType<RunSqlQuery>().ToArray<RunSqlQuery>();

            foreach (RunSqlQuery runSqlQuery in runSqlQueries)
            {
                runSqlQuery.CloseQuery();
            }
        }

        /// <summary>
        /// Update the counters in the status bar.
        /// </summary>
        private void UpdateCountStatus()
        {
            toolStripStatusLabelCompletedQueriesCount.Text = string.Format(Properties.Resources.CompletedQueriesStatus, Globals._totalCompletedQueryCount);
            toolStripStatusLabelFailedQueriesCount.Text = string.Format(Properties.Resources.FailedQueriesStatus, Globals._totalFailedQueryCount);
            toolStripStatusLabelThreadsCount.Text = string.Format(Properties.Resources.TotalThreadsStatus, Globals._totalThreadCount);
        }

        /// <summary>
        /// Reset the global counters and update the status.
        /// </summary>
        private void ResetCounters()
        {
            Globals._totalCompletedQueryCount = 0;
            Globals._totalFailedQueryCount = 0;
            // This shouldn't be reset... otherwise, our total count will be off
            //Global._totalThreadCount = 0;
            UpdateCountStatus();
        }
        #endregion
    }
}
