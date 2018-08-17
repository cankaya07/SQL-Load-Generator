using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace SqlLoadGeneratorUI
{
    public partial class FormOptions : Form
    {
        #region UI Helpers
        public FormOptions()
        {
            InitializeComponent();
        }
        
        void FormOptions_Load(object sender, System.EventArgs e)
        {
            LoadOptions();
        }

        private void buttonSaveOptions_Click(object sender, EventArgs e)
        {
            SaveOptions();
            this.Close();
        }

        private void buttonCancelOptions_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonResetOptions_Click(object sender, EventArgs e)
        {
            LoadOptions();
        }

        private void buttonRestoreDefaultOptions_Click(object sender, EventArgs e)
        {
            ResetOptions();
        }
        #endregion

        #region Internal Methods
        /// <summary>
        /// Save the user specified preferences
        /// </summary>
        private void SaveOptions()
        {
            // Default Query Settings
            Properties.Settings.Default.DefaultApplication = textBoxDefaultApplication.Text.Trim();
            Properties.Settings.Default.DefaultConcurrentQueryCount = int.Parse(maskedTextBoxDefaultConcurrentQueryCount.Text);
            Properties.Settings.Default.DefaultDatabase = textBoxDefaultDatabase.Text.Trim();
            Properties.Settings.Default.DefaultPassword = textBoxDefaultPassword.Text.Trim();
            Properties.Settings.Default.DefaultUsername = textBoxDefaultUsername.Text.Trim();
            Properties.Settings.Default.DefaultQuery = textBoxDefaultQuery.Text.Trim();
            if (radioButtonSqlAccountType.Checked)
            {
                Properties.Settings.Default.DefaultIsDomainAccount = false;
            }
            else
            {
                Properties.Settings.Default.DefaultIsDomainAccount = true;
            }

            // Application Logging Settings
            Properties.Settings.Default.ApplicationLogFilename = textBoxApplicationLogFilename.Text.Trim();

            string applicationLogLocation = textBoxApplicationLogLocation.Text.Trim();
            if (!applicationLogLocation.EndsWith(@"\"))
            {
                textBoxApplicationLogLocation.Text = applicationLogLocation + @"\";
            }
            Properties.Settings.Default.ApplicationLogLocation = textBoxApplicationLogLocation.Text.Trim();
            if (radioButtonApplicationLoggingOn.Checked)
            {
                Properties.Settings.Default.ApplicationLogging = true;
            }
            else
            {
                Properties.Settings.Default.ApplicationLogging = false;
            }

            // General Settings
            Properties.Settings.Default.ConnectionStringModifiers = textBoxConnectionStringModifiers.Text.Trim();

            // Server settings
            Properties.Settings.Default.DefaultServer = textBoxDefaultServer.Text.Trim();

            // Convert the multiline textboxes to StringCollections and persist
            Properties.Settings.Default.AllApplications.Clear();
            Properties.Settings.Default.AllApplications.AddRange(textBoxAllApplications.Lines);

            Properties.Settings.Default.AllServers.Clear();
            Properties.Settings.Default.AllServers.AddRange(textBoxAllServers.Lines);

            Properties.Settings.Default.AllDatabases.Clear();
            Properties.Settings.Default.AllDatabases.AddRange(textBoxAllDatabases.Lines);

            // Persist the settings
            Properties.Settings.Default.Save();
            
        }

        /// <summary>
        /// Load the user specified preferences for editing
        /// </summary>
        private void LoadOptions()
        {
            // Default Query Settings
            textBoxDefaultApplication.Text = Properties.Settings.Default.DefaultApplication;
            maskedTextBoxDefaultConcurrentQueryCount.Text = Properties.Settings.Default.DefaultConcurrentQueryCount.ToString();
            textBoxDefaultDatabase.Text = Properties.Settings.Default.DefaultDatabase;
            textBoxDefaultPassword.Text = Properties.Settings.Default.DefaultPassword;
            textBoxDefaultUsername.Text = Properties.Settings.Default.DefaultUsername;
            textBoxDefaultQuery.Text = Properties.Settings.Default.DefaultQuery;
            if (Properties.Settings.Default.DefaultIsDomainAccount)
            {
                radioButtonDomainAccountType.Checked = true;
            }
            else
            {
                radioButtonSqlAccountType.Checked = true;
            }

            // Application Logging Settings
            textBoxApplicationLogFilename.Text = Properties.Settings.Default.ApplicationLogFilename;
            textBoxApplicationLogLocation.Text = Properties.Settings.Default.ApplicationLogLocation;
            if (Properties.Settings.Default.ApplicationLogging)
            {
                radioButtonApplicationLoggingOn.Checked = true;
            }
            else
            {
                radioButtonApplicationLoggingOff.Checked = true;
            }

            // General Settings
            textBoxConnectionStringModifiers.Text = Properties.Settings.Default.ConnectionStringModifiers;

            // Server settings
            textBoxDefaultServer.Text = Properties.Settings.Default.DefaultServer;

            // Populate the All Databases textbox from the collection
            string[] allDatabases = new string [Properties.Settings.Default.AllDatabases.Count];
            Properties.Settings.Default.AllDatabases.CopyTo(allDatabases, 0);
            textBoxAllDatabases.Lines = allDatabases;

            // Populate the All Servers textbox from the collection
            string[] allServers = new string[Properties.Settings.Default.AllServers.Count];
            Properties.Settings.Default.AllServers.CopyTo(allServers, 0);
            textBoxAllServers.Lines = allServers;

            // Populate the All Applications textbox from the collection
            string[] allApplications = new string[Properties.Settings.Default.AllApplications.Count];
            Properties.Settings.Default.AllApplications.CopyTo(allApplications, 0);
            textBoxAllApplications.Lines = allApplications;
        }

        /// <summary>
        /// Reset the user specified optins to the default values
        /// </summary>
        private void ResetOptions()
        {
            Properties.Settings.Default.Reset();
            LoadOptions();
        }
        #endregion

    }
}
