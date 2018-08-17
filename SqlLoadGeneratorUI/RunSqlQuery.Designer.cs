namespace SqlLoadGeneratorUI
{
    partial class RunSqlQuery
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonCloseUserControl = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSpendingTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNumberOfThreads = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfFailures = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumberOfRuns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDatabase = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxDomainAccount = new System.Windows.Forms.CheckBox();
            this.comboBoxApplication = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxConcurrentQueries = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxHidePassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAVGTime = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonCloseUserControl);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxQuery);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtAVGTime);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txtSpendingTime);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(323, 356);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonCloseUserControl
            // 
            this.buttonCloseUserControl.FlatAppearance.BorderSize = 0;
            this.buttonCloseUserControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUserControl.Image = global::SqlLoadGeneratorUI.Properties.Resources.delete;
            this.buttonCloseUserControl.Location = new System.Drawing.Point(287, 0);
            this.buttonCloseUserControl.Name = "buttonCloseUserControl";
            this.buttonCloseUserControl.Size = new System.Drawing.Size(27, 20);
            this.buttonCloseUserControl.TabIndex = 2;
            this.buttonCloseUserControl.UseVisualStyleBackColor = true;
            this.buttonCloseUserControl.Click += new System.EventHandler(this.buttonCloseUserControl_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.AcceptsReturn = true;
            this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery.Location = new System.Drawing.Point(3, 21);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(313, 92);
            this.textBoxQuery.TabIndex = 1;
            this.textBoxQuery.DoubleClick += new System.EventHandler(this.textBoxQuery_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Db exec Time(ms)";
            // 
            // txtSpendingTime
            // 
            this.txtSpendingTime.Location = new System.Drawing.Point(101, 182);
            this.txtSpendingTime.Name = "txtSpendingTime";
            this.txtSpendingTime.Size = new System.Drawing.Size(65, 20);
            this.txtSpendingTime.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxNumberOfThreads);
            this.groupBox2.Controls.Add(this.textBoxNumberOfFailures);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxNumberOfRuns);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Location = new System.Drawing.Point(5, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 63);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run Statistics";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "# of Queries";
            // 
            // textBoxNumberOfThreads
            // 
            this.textBoxNumberOfThreads.ForeColor = System.Drawing.Color.Lime;
            this.textBoxNumberOfThreads.Location = new System.Drawing.Point(239, 37);
            this.textBoxNumberOfThreads.Name = "textBoxNumberOfThreads";
            this.textBoxNumberOfThreads.ReadOnly = true;
            this.textBoxNumberOfThreads.Size = new System.Drawing.Size(68, 20);
            this.textBoxNumberOfThreads.TabIndex = 6;
            // 
            // textBoxNumberOfFailures
            // 
            this.textBoxNumberOfFailures.ForeColor = System.Drawing.Color.Red;
            this.textBoxNumberOfFailures.Location = new System.Drawing.Point(160, 37);
            this.textBoxNumberOfFailures.Name = "textBoxNumberOfFailures";
            this.textBoxNumberOfFailures.ReadOnly = true;
            this.textBoxNumberOfFailures.Size = new System.Drawing.Size(60, 20);
            this.textBoxNumberOfFailures.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "# of Failures";
            // 
            // textBoxNumberOfRuns
            // 
            this.textBoxNumberOfRuns.ForeColor = System.Drawing.Color.Blue;
            this.textBoxNumberOfRuns.Location = new System.Drawing.Point(160, 13);
            this.textBoxNumberOfRuns.Name = "textBoxNumberOfRuns";
            this.textBoxNumberOfRuns.ReadOnly = true;
            this.textBoxNumberOfRuns.Size = new System.Drawing.Size(61, 20);
            this.textBoxNumberOfRuns.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "# of Runs";
            // 
            // buttonStop
            // 
            this.buttonStop.Image = global::SqlLoadGeneratorUI.Properties.Resources.control_stop_blue;
            this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStop.Location = new System.Drawing.Point(7, 36);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::SqlLoadGeneratorUI.Properties.Resources.control_play_blue;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(7, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDatabase);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.checkBoxDomainAccount);
            this.groupBox1.Controls.Add(this.comboBoxApplication);
            this.groupBox1.Controls.Add(this.maskedTextBoxConcurrentQueries);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.checkBoxHidePassword);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Location = new System.Drawing.Point(5, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 119);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // comboBoxDatabase
            // 
            this.comboBoxDatabase.FormattingEnabled = true;
            this.comboBoxDatabase.Location = new System.Drawing.Point(69, 68);
            this.comboBoxDatabase.Name = "comboBoxDatabase";
            this.comboBoxDatabase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDatabase.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Database";
            // 
            // checkBoxDomainAccount
            // 
            this.checkBoxDomainAccount.AutoSize = true;
            this.checkBoxDomainAccount.Location = new System.Drawing.Point(176, 18);
            this.checkBoxDomainAccount.Name = "checkBoxDomainAccount";
            this.checkBoxDomainAccount.Size = new System.Drawing.Size(105, 17);
            this.checkBoxDomainAccount.TabIndex = 6;
            this.checkBoxDomainAccount.Text = "Domain Account";
            this.checkBoxDomainAccount.UseVisualStyleBackColor = true;
            // 
            // comboBoxApplication
            // 
            this.comboBoxApplication.FormattingEnabled = true;
            this.comboBoxApplication.Location = new System.Drawing.Point(68, 91);
            this.comboBoxApplication.Name = "comboBoxApplication";
            this.comboBoxApplication.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApplication.TabIndex = 4;
            // 
            // maskedTextBoxConcurrentQueries
            // 
            this.maskedTextBoxConcurrentQueries.Location = new System.Drawing.Point(208, 91);
            this.maskedTextBoxConcurrentQueries.Mask = "000";
            this.maskedTextBoxConcurrentQueries.Name = "maskedTextBoxConcurrentQueries";
            this.maskedTextBoxConcurrentQueries.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBoxConcurrentQueries.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Concurrent Queries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Application";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(68, 16);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // checkBoxHidePassword
            // 
            this.checkBoxHidePassword.AutoSize = true;
            this.checkBoxHidePassword.Location = new System.Drawing.Point(176, 43);
            this.checkBoxHidePassword.Name = "checkBoxHidePassword";
            this.checkBoxHidePassword.Size = new System.Drawing.Size(97, 17);
            this.checkBoxHidePassword.TabIndex = 7;
            this.checkBoxHidePassword.Text = "Hide Password";
            this.checkBoxHidePassword.UseVisualStyleBackColor = true;
            this.checkBoxHidePassword.CheckedChanged += new System.EventHandler(this.checkBoxHidePassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(69, 41);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "AVG DB Time(ms)";
            // 
            // txtAVGTime
            // 
            this.txtAVGTime.Location = new System.Drawing.Point(107, 206);
            this.txtAVGTime.Name = "txtAVGTime";
            this.txtAVGTime.Size = new System.Drawing.Size(100, 20);
            this.txtAVGTime.TabIndex = 13;
            // 
            // RunSqlQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.Name = "RunSqlQuery";
            this.Size = new System.Drawing.Size(323, 356);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxHidePassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxApplication;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxConcurrentQueries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumberOfRuns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxDomainAccount;
        private System.Windows.Forms.TextBox textBoxNumberOfFailures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNumberOfThreads;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCloseUserControl;
        private System.Windows.Forms.ComboBox comboBoxDatabase;
        private System.Windows.Forms.TextBox txtSpendingTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAVGTime;
        private System.Windows.Forms.Label label12;
    }
}
