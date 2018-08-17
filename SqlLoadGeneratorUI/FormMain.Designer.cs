namespace SqlLoadGeneratorUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAllQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripQuery = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartAllQueries = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStopAllQueries = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveAllQueries = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResetCounters = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelThreadsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCompletedQueriesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFailedQueriesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLoggingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripConnection = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelServer = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStripQuery.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripConnection.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQueryToolStripMenuItem,
            this.toggleLoggingToolStripMenuItem,
            this.startAllQueriesToolStripMenuItem,
            this.stopAllQueriesToolStripMenuItem,
            this.removeAllQueriesToolStripMenuItem,
            this.resetCountersToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.queryToolStripMenuItem.Text = "&Query";
            // 
            // addQueryToolStripMenuItem
            // 
            this.addQueryToolStripMenuItem.Image = global::SqlLoadGeneratorUI.Properties.Resources.Add;
            this.addQueryToolStripMenuItem.Name = "addQueryToolStripMenuItem";
            this.addQueryToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addQueryToolStripMenuItem.Text = "Add &Query";
            this.addQueryToolStripMenuItem.Click += new System.EventHandler(this.addQueryToolStripMenuItem_Click);
            // 
            // toggleLoggingToolStripMenuItem
            // 
            this.toggleLoggingToolStripMenuItem.Name = "toggleLoggingToolStripMenuItem";
            this.toggleLoggingToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.toggleLoggingToolStripMenuItem.Text = "&Toggle Logging";
            this.toggleLoggingToolStripMenuItem.Click += new System.EventHandler(this.toggleLoggingToolStripMenuItem_Click);
            // 
            // startAllQueriesToolStripMenuItem
            // 
            this.startAllQueriesToolStripMenuItem.Image = global::SqlLoadGeneratorUI.Properties.Resources.control_play_blue;
            this.startAllQueriesToolStripMenuItem.Name = "startAllQueriesToolStripMenuItem";
            this.startAllQueriesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.startAllQueriesToolStripMenuItem.Text = "St&art All Queries";
            this.startAllQueriesToolStripMenuItem.Click += new System.EventHandler(this.startAllQueriesToolStripMenuItem_Click);
            // 
            // stopAllQueriesToolStripMenuItem
            // 
            this.stopAllQueriesToolStripMenuItem.Image = global::SqlLoadGeneratorUI.Properties.Resources.control_stop_blue;
            this.stopAllQueriesToolStripMenuItem.Name = "stopAllQueriesToolStripMenuItem";
            this.stopAllQueriesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.stopAllQueriesToolStripMenuItem.Text = "St&op All Queries";
            this.stopAllQueriesToolStripMenuItem.Click += new System.EventHandler(this.stopAllQueriesToolStripMenuItem_Click);
            // 
            // removeAllQueriesToolStripMenuItem
            // 
            this.removeAllQueriesToolStripMenuItem.Image = global::SqlLoadGeneratorUI.Properties.Resources.cross;
            this.removeAllQueriesToolStripMenuItem.Name = "removeAllQueriesToolStripMenuItem";
            this.removeAllQueriesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.removeAllQueriesToolStripMenuItem.Text = "&Remove All Queries";
            this.removeAllQueriesToolStripMenuItem.Click += new System.EventHandler(this.removeAllQueriesToolStripMenuItem_Click);
            // 
            // resetCountersToolStripMenuItem
            // 
            this.resetCountersToolStripMenuItem.Image = global::SqlLoadGeneratorUI.Properties.Resources.table_refresh;
            this.resetCountersToolStripMenuItem.Name = "resetCountersToolStripMenuItem";
            this.resetCountersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.resetCountersToolStripMenuItem.Text = "R&eset Counters";
            this.resetCountersToolStripMenuItem.Click += new System.EventHandler(this.resetCountersToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.optionsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Image = global::SqlLoadGeneratorUI.Properties.Resources.application_form_edit;
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem1.Text = "&Options...";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripQuery
            // 
            this.toolStripQuery.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripQuery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddQuery,
            this.toolStripButtonStartAllQueries,
            this.toolStripButtonStopAllQueries,
            this.toolStripButtonRemoveAllQueries,
            this.toolStripButtonResetCounters});
            this.toolStripQuery.Location = new System.Drawing.Point(140, 24);
            this.toolStripQuery.Name = "toolStripQuery";
            this.toolStripQuery.Size = new System.Drawing.Size(519, 25);
            this.toolStripQuery.TabIndex = 5;
            this.toolStripQuery.Text = "toolStrip1";
            // 
            // toolStripButtonAddQuery
            // 
            this.toolStripButtonAddQuery.Image = global::SqlLoadGeneratorUI.Properties.Resources.Add;
            this.toolStripButtonAddQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddQuery.Name = "toolStripButtonAddQuery";
            this.toolStripButtonAddQuery.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonAddQuery.Text = "Add Query";
            this.toolStripButtonAddQuery.ToolTipText = "Add a new SQL query to run";
            this.toolStripButtonAddQuery.Click += new System.EventHandler(this.toolStripButtonAddQuery_Click);
            // 
            // toolStripButtonStartAllQueries
            // 
            this.toolStripButtonStartAllQueries.Image = global::SqlLoadGeneratorUI.Properties.Resources.control_play_blue;
            this.toolStripButtonStartAllQueries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartAllQueries.Name = "toolStripButtonStartAllQueries";
            this.toolStripButtonStartAllQueries.Size = new System.Drawing.Size(105, 22);
            this.toolStripButtonStartAllQueries.Text = "Start All Queries";
            this.toolStripButtonStartAllQueries.Click += new System.EventHandler(this.toolStripButtonStartAllQueries_Click);
            // 
            // toolStripButtonStopAllQueries
            // 
            this.toolStripButtonStopAllQueries.Image = global::SqlLoadGeneratorUI.Properties.Resources.control_stop_blue;
            this.toolStripButtonStopAllQueries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStopAllQueries.Name = "toolStripButtonStopAllQueries";
            this.toolStripButtonStopAllQueries.Size = new System.Drawing.Size(103, 22);
            this.toolStripButtonStopAllQueries.Text = "Stop All Queries";
            this.toolStripButtonStopAllQueries.Click += new System.EventHandler(this.toolStripButtonStopAllQueries_Click);
            // 
            // toolStripButtonRemoveAllQueries
            // 
            this.toolStripButtonRemoveAllQueries.Image = global::SqlLoadGeneratorUI.Properties.Resources.cross;
            this.toolStripButtonRemoveAllQueries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveAllQueries.Name = "toolStripButtonRemoveAllQueries";
            this.toolStripButtonRemoveAllQueries.Size = new System.Drawing.Size(120, 22);
            this.toolStripButtonRemoveAllQueries.Text = "Remove All Queries";
            this.toolStripButtonRemoveAllQueries.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonResetCounters
            // 
            this.toolStripButtonResetCounters.Image = global::SqlLoadGeneratorUI.Properties.Resources.table_refresh;
            this.toolStripButtonResetCounters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetCounters.Name = "toolStripButtonResetCounters";
            this.toolStripButtonResetCounters.Size = new System.Drawing.Size(102, 22);
            this.toolStripButtonResetCounters.Text = "Reset Counters";
            this.toolStripButtonResetCounters.Click += new System.EventHandler(this.toolStripButtonResetCounters_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelThreadsCount,
            this.toolStripStatusLabelCompletedQueriesCount,
            this.toolStripStatusLabelFailedQueriesCount,
            this.toolStripStatusLabelSpacer,
            this.toolStripStatusLabelLoggingStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelThreadsCount
            // 
            this.toolStripStatusLabelThreadsCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelThreadsCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelThreadsCount.Name = "toolStripStatusLabelThreadsCount";
            this.toolStripStatusLabelThreadsCount.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabelThreadsCount.Text = "Thread Count:  0";
            this.toolStripStatusLabelThreadsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelCompletedQueriesCount
            // 
            this.toolStripStatusLabelCompletedQueriesCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelCompletedQueriesCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelCompletedQueriesCount.Name = "toolStripStatusLabelCompletedQueriesCount";
            this.toolStripStatusLabelCompletedQueriesCount.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelCompletedQueriesCount.Text = "Completed Queries:  0";
            this.toolStripStatusLabelCompletedQueriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelFailedQueriesCount
            // 
            this.toolStripStatusLabelFailedQueriesCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelFailedQueriesCount.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelFailedQueriesCount.Name = "toolStripStatusLabelFailedQueriesCount";
            this.toolStripStatusLabelFailedQueriesCount.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabelFailedQueriesCount.Text = "Failed Queries:  0";
            this.toolStripStatusLabelFailedQueriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelSpacer
            // 
            this.toolStripStatusLabelSpacer.Name = "toolStripStatusLabelSpacer";
            this.toolStripStatusLabelSpacer.Size = new System.Drawing.Size(396, 17);
            this.toolStripStatusLabelSpacer.Spring = true;
            // 
            // toolStripStatusLabelLoggingStatus
            // 
            this.toolStripStatusLabelLoggingStatus.AutoSize = false;
            this.toolStripStatusLabelLoggingStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelLoggingStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabelLoggingStatus.Name = "toolStripStatusLabelLoggingStatus";
            this.toolStripStatusLabelLoggingStatus.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabelLoggingStatus.Text = "Application Logging: Off";
            this.toolStripStatusLabelLoggingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabelLoggingStatus.ToolTipText = "Whether the application will save errors to a text file.";
            // 
            // toolStripConnection
            // 
            this.toolStripConnection.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabelServer});
            this.toolStripConnection.Location = new System.Drawing.Point(3, 24);
            this.toolStripConnection.Name = "toolStripConnection";
            this.toolStripConnection.Size = new System.Drawing.Size(137, 25);
            this.toolStripConnection.TabIndex = 7;
            this.toolStripConnection.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Server";
            // 
            // toolStripLabelServer
            // 
            this.toolStripLabelServer.Name = "toolStripLabelServer";
            this.toolStripLabelServer.Size = new System.Drawing.Size(86, 25);
            this.toolStripLabelServer.ToolTipText = "Pick the SQL Server to run queries against";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.flowLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(842, 359);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(842, 430);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripConnection);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripQuery);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, -2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(832, 356);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 430);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "SQL Load Generator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripQuery.ResumeLayout(false);
            this.toolStripQuery.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripConnection.ResumeLayout(false);
            this.toolStripConnection.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripQuery;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddQuery;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLoggingStatus;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartAllQueries;
        private System.Windows.Forms.ToolStripButton toolStripButtonStopAllQueries;
        private System.Windows.Forms.ToolStripMenuItem startAllQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveAllQueries;
        private System.Windows.Forms.ToolStrip toolStripConnection;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripLabelServer;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelThreadsCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCompletedQueriesCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFailedQueriesCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpacer;
        private System.Windows.Forms.ToolStripButton toolStripButtonResetCounters;
        private System.Windows.Forms.ToolStripMenuItem resetCountersToolStripMenuItem;

    }
}

