namespace SqlLoadGeneratorUI
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonApplicationLoggingOff = new System.Windows.Forms.RadioButton();
            this.radioButtonApplicationLoggingOn = new System.Windows.Forms.RadioButton();
            this.textBoxApplicationLogLocation = new System.Windows.Forms.TextBox();
            this.textBoxApplicationLogFilename = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDefaultQuery = new System.Windows.Forms.TextBox();
            this.textBoxDefaultApplication = new System.Windows.Forms.TextBox();
            this.radioButtonDomainAccountType = new System.Windows.Forms.RadioButton();
            this.radioButtonSqlAccountType = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxDefaultConcurrentQueryCount = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDefaultPassword = new System.Windows.Forms.TextBox();
            this.textBoxDefaultUsername = new System.Windows.Forms.TextBox();
            this.textBoxDefaultDatabase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSaveOptions = new System.Windows.Forms.Button();
            this.buttonCancelOptions = new System.Windows.Forms.Button();
            this.buttonResetOptions = new System.Windows.Forms.Button();
            this.buttonRestoreDefaultOptions = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxAllApplications = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAllServers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAllDatabases = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxConnectionStringModifiers = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDefaultServer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filename";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonApplicationLoggingOff);
            this.groupBox1.Controls.Add(this.radioButtonApplicationLoggingOn);
            this.groupBox1.Controls.Add(this.textBoxApplicationLogLocation);
            this.groupBox1.Controls.Add(this.textBoxApplicationLogFilename);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Logging";
            // 
            // radioButtonApplicationLoggingOff
            // 
            this.radioButtonApplicationLoggingOff.AutoSize = true;
            this.radioButtonApplicationLoggingOff.Location = new System.Drawing.Point(219, 70);
            this.radioButtonApplicationLoggingOff.Name = "radioButtonApplicationLoggingOff";
            this.radioButtonApplicationLoggingOff.Size = new System.Drawing.Size(39, 17);
            this.radioButtonApplicationLoggingOff.TabIndex = 10;
            this.radioButtonApplicationLoggingOff.Text = "Off";
            this.radioButtonApplicationLoggingOff.UseVisualStyleBackColor = true;
            // 
            // radioButtonApplicationLoggingOn
            // 
            this.radioButtonApplicationLoggingOn.AutoSize = true;
            this.radioButtonApplicationLoggingOn.Checked = true;
            this.radioButtonApplicationLoggingOn.Location = new System.Drawing.Point(173, 70);
            this.radioButtonApplicationLoggingOn.Name = "radioButtonApplicationLoggingOn";
            this.radioButtonApplicationLoggingOn.Size = new System.Drawing.Size(39, 17);
            this.radioButtonApplicationLoggingOn.TabIndex = 9;
            this.radioButtonApplicationLoggingOn.TabStop = true;
            this.radioButtonApplicationLoggingOn.Text = "On";
            this.radioButtonApplicationLoggingOn.UseVisualStyleBackColor = true;
            // 
            // textBoxApplicationLogLocation
            // 
            this.textBoxApplicationLogLocation.Location = new System.Drawing.Point(66, 43);
            this.textBoxApplicationLogLocation.Name = "textBoxApplicationLogLocation";
            this.textBoxApplicationLogLocation.Size = new System.Drawing.Size(196, 20);
            this.textBoxApplicationLogLocation.TabIndex = 8;
            // 
            // textBoxApplicationLogFilename
            // 
            this.textBoxApplicationLogFilename.Location = new System.Drawing.Point(66, 16);
            this.textBoxApplicationLogFilename.Name = "textBoxApplicationLogFilename";
            this.textBoxApplicationLogFilename.Size = new System.Drawing.Size(196, 20);
            this.textBoxApplicationLogFilename.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status at program start";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxDefaultQuery);
            this.groupBox2.Controls.Add(this.textBoxDefaultApplication);
            this.groupBox2.Controls.Add(this.radioButtonDomainAccountType);
            this.groupBox2.Controls.Add(this.radioButtonSqlAccountType);
            this.groupBox2.Controls.Add(this.maskedTextBoxDefaultConcurrentQueryCount);
            this.groupBox2.Controls.Add(this.textBoxDefaultPassword);
            this.groupBox2.Controls.Add(this.textBoxDefaultUsername);
            this.groupBox2.Controls.Add(this.textBoxDefaultDatabase);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 237);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Query Defaults";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Query";
            // 
            // textBoxDefaultQuery
            // 
            this.textBoxDefaultQuery.AcceptsReturn = true;
            this.textBoxDefaultQuery.Location = new System.Drawing.Point(9, 187);
            this.textBoxDefaultQuery.Multiline = true;
            this.textBoxDefaultQuery.Name = "textBoxDefaultQuery";
            this.textBoxDefaultQuery.Size = new System.Drawing.Size(253, 41);
            this.textBoxDefaultQuery.TabIndex = 15;
            // 
            // textBoxDefaultApplication
            // 
            this.textBoxDefaultApplication.Location = new System.Drawing.Point(107, 116);
            this.textBoxDefaultApplication.Name = "textBoxDefaultApplication";
            this.textBoxDefaultApplication.Size = new System.Drawing.Size(155, 20);
            this.textBoxDefaultApplication.TabIndex = 14;
            // 
            // radioButtonDomainAccountType
            // 
            this.radioButtonDomainAccountType.AutoSize = true;
            this.radioButtonDomainAccountType.Location = new System.Drawing.Point(156, 93);
            this.radioButtonDomainAccountType.Name = "radioButtonDomainAccountType";
            this.radioButtonDomainAccountType.Size = new System.Drawing.Size(61, 17);
            this.radioButtonDomainAccountType.TabIndex = 13;
            this.radioButtonDomainAccountType.Text = "Domain";
            this.radioButtonDomainAccountType.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqlAccountType
            // 
            this.radioButtonSqlAccountType.AutoSize = true;
            this.radioButtonSqlAccountType.Checked = true;
            this.radioButtonSqlAccountType.Location = new System.Drawing.Point(108, 93);
            this.radioButtonSqlAccountType.Name = "radioButtonSqlAccountType";
            this.radioButtonSqlAccountType.Size = new System.Drawing.Size(46, 17);
            this.radioButtonSqlAccountType.TabIndex = 12;
            this.radioButtonSqlAccountType.TabStop = true;
            this.radioButtonSqlAccountType.Text = "SQL";
            this.radioButtonSqlAccountType.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxDefaultConcurrentQueryCount
            // 
            this.maskedTextBoxDefaultConcurrentQueryCount.Location = new System.Drawing.Point(107, 142);
            this.maskedTextBoxDefaultConcurrentQueryCount.Mask = "000";
            this.maskedTextBoxDefaultConcurrentQueryCount.Name = "maskedTextBoxDefaultConcurrentQueryCount";
            this.maskedTextBoxDefaultConcurrentQueryCount.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBoxDefaultConcurrentQueryCount.TabIndex = 11;
            // 
            // textBoxDefaultPassword
            // 
            this.textBoxDefaultPassword.Location = new System.Drawing.Point(107, 67);
            this.textBoxDefaultPassword.Name = "textBoxDefaultPassword";
            this.textBoxDefaultPassword.Size = new System.Drawing.Size(155, 20);
            this.textBoxDefaultPassword.TabIndex = 9;
            // 
            // textBoxDefaultUsername
            // 
            this.textBoxDefaultUsername.Location = new System.Drawing.Point(107, 41);
            this.textBoxDefaultUsername.Name = "textBoxDefaultUsername";
            this.textBoxDefaultUsername.Size = new System.Drawing.Size(155, 20);
            this.textBoxDefaultUsername.TabIndex = 8;
            // 
            // textBoxDefaultDatabase
            // 
            this.textBoxDefaultDatabase.Location = new System.Drawing.Point(107, 15);
            this.textBoxDefaultDatabase.Name = "textBoxDefaultDatabase";
            this.textBoxDefaultDatabase.Size = new System.Drawing.Size(155, 20);
            this.textBoxDefaultDatabase.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Concurrent Queries";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Application";
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.Location = new System.Drawing.Point(375, 448);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOptions.TabIndex = 8;
            this.buttonSaveOptions.Text = "Save";
            this.buttonSaveOptions.UseVisualStyleBackColor = true;
            this.buttonSaveOptions.Click += new System.EventHandler(this.buttonSaveOptions_Click);
            // 
            // buttonCancelOptions
            // 
            this.buttonCancelOptions.Location = new System.Drawing.Point(455, 448);
            this.buttonCancelOptions.Name = "buttonCancelOptions";
            this.buttonCancelOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelOptions.TabIndex = 9;
            this.buttonCancelOptions.Text = "Cancel";
            this.buttonCancelOptions.UseVisualStyleBackColor = true;
            this.buttonCancelOptions.Click += new System.EventHandler(this.buttonCancelOptions_Click);
            // 
            // buttonResetOptions
            // 
            this.buttonResetOptions.Location = new System.Drawing.Point(295, 448);
            this.buttonResetOptions.Name = "buttonResetOptions";
            this.buttonResetOptions.Size = new System.Drawing.Size(75, 23);
            this.buttonResetOptions.TabIndex = 10;
            this.buttonResetOptions.Text = "Reset";
            this.buttonResetOptions.UseVisualStyleBackColor = true;
            this.buttonResetOptions.Click += new System.EventHandler(this.buttonResetOptions_Click);
            // 
            // buttonRestoreDefaultOptions
            // 
            this.buttonRestoreDefaultOptions.Location = new System.Drawing.Point(155, 448);
            this.buttonRestoreDefaultOptions.Name = "buttonRestoreDefaultOptions";
            this.buttonRestoreDefaultOptions.Size = new System.Drawing.Size(135, 23);
            this.buttonRestoreDefaultOptions.TabIndex = 11;
            this.buttonRestoreDefaultOptions.Text = "Restore Default Options";
            this.buttonRestoreDefaultOptions.UseVisualStyleBackColor = true;
            this.buttonRestoreDefaultOptions.Click += new System.EventHandler(this.buttonRestoreDefaultOptions_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxAllApplications);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBoxAllServers);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxAllDatabases);
            this.groupBox3.Location = new System.Drawing.Point(287, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 279);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frequently Used";
            // 
            // textBoxAllApplications
            // 
            this.textBoxAllApplications.Location = new System.Drawing.Point(9, 209);
            this.textBoxAllApplications.Multiline = true;
            this.textBoxAllApplications.Name = "textBoxAllApplications";
            this.textBoxAllApplications.Size = new System.Drawing.Size(229, 61);
            this.textBoxAllApplications.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Applications (one per line)";
            // 
            // textBoxAllServers
            // 
            this.textBoxAllServers.Location = new System.Drawing.Point(9, 123);
            this.textBoxAllServers.Multiline = true;
            this.textBoxAllServers.Name = "textBoxAllServers";
            this.textBoxAllServers.Size = new System.Drawing.Size(229, 61);
            this.textBoxAllServers.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Servers (one per line)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Databases (one per line)";
            // 
            // textBoxAllDatabases
            // 
            this.textBoxAllDatabases.AcceptsReturn = true;
            this.textBoxAllDatabases.Location = new System.Drawing.Point(9, 37);
            this.textBoxAllDatabases.Multiline = true;
            this.textBoxAllDatabases.Name = "textBoxAllDatabases";
            this.textBoxAllDatabases.Size = new System.Drawing.Size(229, 61);
            this.textBoxAllDatabases.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.textBoxConnectionStringModifiers);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(519, 89);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(378, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "* \"Pooling=false\" is necessary to not leave hanging connections in SQL Server";
            // 
            // textBoxConnectionStringModifiers
            // 
            this.textBoxConnectionStringModifiers.Location = new System.Drawing.Point(10, 37);
            this.textBoxConnectionStringModifiers.Name = "textBoxConnectionStringModifiers";
            this.textBoxConnectionStringModifiers.Size = new System.Drawing.Size(503, 20);
            this.textBoxConnectionStringModifiers.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Connection String Modifiers";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxDefaultServer);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Location = new System.Drawing.Point(286, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 49);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Default Server";
            // 
            // textBoxDefaultServer
            // 
            this.textBoxDefaultServer.Location = new System.Drawing.Point(91, 20);
            this.textBoxDefaultServer.Name = "textBoxDefaultServer";
            this.textBoxDefaultServer.Size = new System.Drawing.Size(146, 20);
            this.textBoxDefaultServer.TabIndex = 1;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 483);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonRestoreDefaultOptions);
            this.Controls.Add(this.buttonResetOptions);
            this.Controls.Add(this.buttonCancelOptions);
            this.Controls.Add(this.buttonSaveOptions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSaveOptions;
        private System.Windows.Forms.Button buttonCancelOptions;
        private System.Windows.Forms.RadioButton radioButtonDomainAccountType;
        private System.Windows.Forms.RadioButton radioButtonSqlAccountType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDefaultConcurrentQueryCount;
        private System.Windows.Forms.TextBox textBoxDefaultPassword;
        private System.Windows.Forms.TextBox textBoxDefaultUsername;
        private System.Windows.Forms.TextBox textBoxDefaultDatabase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDefaultApplication;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDefaultQuery;
        private System.Windows.Forms.RadioButton radioButtonApplicationLoggingOff;
        private System.Windows.Forms.RadioButton radioButtonApplicationLoggingOn;
        private System.Windows.Forms.TextBox textBoxApplicationLogLocation;
        private System.Windows.Forms.TextBox textBoxApplicationLogFilename;
        private System.Windows.Forms.Button buttonResetOptions;
        private System.Windows.Forms.Button buttonRestoreDefaultOptions;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAllDatabases;
        private System.Windows.Forms.TextBox textBoxAllApplications;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAllServers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxConnectionStringModifiers;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxDefaultServer;
        private System.Windows.Forms.Label label16;
    }
}