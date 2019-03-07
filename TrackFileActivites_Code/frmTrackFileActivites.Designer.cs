namespace TrackFileActivites
{
    partial class frmTrackFileActivites
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackFileActivites));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemOpenOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSetPath = new System.Windows.Forms.TextBox();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.btnStartTracking = new System.Windows.Forms.Button();
            this.btnStopTracking = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.lblTrackPath = new System.Windows.Forms.Label();
            this.toolTipTrackPath = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipWorkPath = new System.Windows.Forms.ToolTip(this.components);
            this.lblFilter = new System.Windows.Forms.Label();
            this.chkIncludeSubdirectories = new System.Windows.Forms.CheckBox();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.toolTipNotifyFilter = new System.Windows.Forms.ToolTip(this.components);
            this.gbNotifyFilter = new System.Windows.Forms.GroupBox();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.chkCreationTime = new System.Windows.Forms.CheckBox();
            this.chkFileName = new System.Windows.Forms.CheckBox();
            this.chkLastAccess = new System.Windows.Forms.CheckBox();
            this.chkDirectoryName = new System.Windows.Forms.CheckBox();
            this.chkLastWrite = new System.Windows.Forms.CheckBox();
            this.chkAttributes = new System.Windows.Forms.CheckBox();
            this.chkSize = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.gbNotifyFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Track File Activites [not running]";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenOptions,
            this.toolStripMenuItemOpenLog,
            this.toolStripMenuItemExit});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 70);
            this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
            // 
            // toolStripMenuItemOpenOptions
            // 
            this.toolStripMenuItemOpenOptions.Name = "toolStripMenuItemOpenOptions";
            this.toolStripMenuItemOpenOptions.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemOpenOptions.Text = "Open Options";
            // 
            // toolStripMenuItemOpenLog
            // 
            this.toolStripMenuItemOpenLog.Name = "toolStripMenuItemOpenLog";
            this.toolStripMenuItemOpenLog.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemOpenLog.Text = "Open Log";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // txtSetPath
            // 
            this.txtSetPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtSetPath.Location = new System.Drawing.Point(51, 12);
            this.txtSetPath.Name = "txtSetPath";
            this.txtSetPath.Size = new System.Drawing.Size(175, 20);
            this.txtSetPath.TabIndex = 0;
            this.toolTipTrackPath.SetToolTip(this.txtSetPath, "Please select a path to Track File Activites.");
            // 
            // btnSetPath
            // 
            this.btnSetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPath.Location = new System.Drawing.Point(234, 10);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(30, 23);
            this.btnSetPath.TabIndex = 1;
            this.btnSetPath.Text = "...";
            this.toolTipTrackPath.SetToolTip(this.btnSetPath, "Please select a path to Track File Activites.");
            this.btnSetPath.UseVisualStyleBackColor = true;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // btnStartTracking
            // 
            this.btnStartTracking.Location = new System.Drawing.Point(59, 241);
            this.btnStartTracking.Name = "btnStartTracking";
            this.btnStartTracking.Size = new System.Drawing.Size(83, 23);
            this.btnStartTracking.TabIndex = 2;
            this.btnStartTracking.Text = "Start Tracking";
            this.btnStartTracking.UseVisualStyleBackColor = true;
            this.btnStartTracking.Click += new System.EventHandler(this.btnStartTracking_Click);
            // 
            // btnStopTracking
            // 
            this.btnStopTracking.Enabled = false;
            this.btnStopTracking.Location = new System.Drawing.Point(148, 241);
            this.btnStopTracking.Name = "btnStopTracking";
            this.btnStopTracking.Size = new System.Drawing.Size(84, 23);
            this.btnStopTracking.TabIndex = 3;
            this.btnStopTracking.Text = "Stop Tracking";
            this.btnStopTracking.UseVisualStyleBackColor = true;
            this.btnStopTracking.Click += new System.EventHandler(this.btnStopTracking_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // lblTrackPath
            // 
            this.lblTrackPath.AutoSize = true;
            this.lblTrackPath.Location = new System.Drawing.Point(12, 15);
            this.lblTrackPath.Name = "lblTrackPath";
            this.lblTrackPath.Size = new System.Drawing.Size(35, 13);
            this.lblTrackPath.TabIndex = 6;
            this.lblTrackPath.Text = "Track";
            this.toolTipTrackPath.SetToolTip(this.lblTrackPath, "Please select a path to Track File Activites.");
            // 
            // toolTipTrackPath
            // 
            this.toolTipTrackPath.AutomaticDelay = 0;
            this.toolTipTrackPath.AutoPopDelay = 5000;
            this.toolTipTrackPath.InitialDelay = 0;
            this.toolTipTrackPath.IsBalloon = true;
            this.toolTipTrackPath.ReshowDelay = 0;
            this.toolTipTrackPath.ToolTipTitle = "Tracking Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Log";
            this.toolTipTrackPath.SetToolTip(this.label1, "Please select a path to Track File Activites.");
            // 
            // toolTipWorkPath
            // 
            this.toolTipWorkPath.AutomaticDelay = 0;
            this.toolTipWorkPath.AutoPopDelay = 5000;
            this.toolTipWorkPath.InitialDelay = 0;
            this.toolTipWorkPath.IsBalloon = true;
            this.toolTipWorkPath.ReshowDelay = 0;
            this.toolTipWorkPath.ToolTipTitle = "Working Directory";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 68);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Filter";
            // 
            // chkIncludeSubdirectories
            // 
            this.chkIncludeSubdirectories.AutoSize = true;
            this.chkIncludeSubdirectories.Checked = true;
            this.chkIncludeSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubdirectories.Location = new System.Drawing.Point(51, 95);
            this.chkIncludeSubdirectories.Name = "chkIncludeSubdirectories";
            this.chkIncludeSubdirectories.Size = new System.Drawing.Size(131, 17);
            this.chkIncludeSubdirectories.TabIndex = 9;
            this.chkIncludeSubdirectories.Text = "Include Subdirectories";
            this.chkIncludeSubdirectories.UseVisualStyleBackColor = true;
            // 
            // cmbFilters
            // 
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Items.AddRange(new object[] {
            "*.*",
            "*.txt",
            "*.docx",
            "*.xls",
            "*.ppt"});
            this.cmbFilters.Location = new System.Drawing.Point(51, 65);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(76, 21);
            this.cmbFilters.TabIndex = 10;
            this.cmbFilters.Text = "*.*";
            // 
            // toolTipNotifyFilter
            // 
            this.toolTipNotifyFilter.AutomaticDelay = 0;
            this.toolTipNotifyFilter.AutoPopDelay = 5000;
            this.toolTipNotifyFilter.InitialDelay = 0;
            this.toolTipNotifyFilter.IsBalloon = true;
            this.toolTipNotifyFilter.ReshowDelay = 0;
            this.toolTipNotifyFilter.ToolTipTitle = "Working Directory";
            // 
            // gbNotifyFilter
            // 
            this.gbNotifyFilter.Controls.Add(this.chkSecurity);
            this.gbNotifyFilter.Controls.Add(this.chkCreationTime);
            this.gbNotifyFilter.Controls.Add(this.chkFileName);
            this.gbNotifyFilter.Controls.Add(this.chkLastAccess);
            this.gbNotifyFilter.Controls.Add(this.chkDirectoryName);
            this.gbNotifyFilter.Controls.Add(this.chkLastWrite);
            this.gbNotifyFilter.Controls.Add(this.chkAttributes);
            this.gbNotifyFilter.Controls.Add(this.chkSize);
            this.gbNotifyFilter.Location = new System.Drawing.Point(15, 118);
            this.gbNotifyFilter.Name = "gbNotifyFilter";
            this.gbNotifyFilter.Size = new System.Drawing.Size(217, 116);
            this.gbNotifyFilter.TabIndex = 21;
            this.gbNotifyFilter.TabStop = false;
            this.gbNotifyFilter.Text = "Notify Modifs";
            this.toolTipNotifyFilter.SetToolTip(this.gbNotifyFilter, "heloo");
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Location = new System.Drawing.Point(115, 88);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(64, 17);
            this.chkSecurity.TabIndex = 21;
            this.chkSecurity.Text = "Security";
            this.chkSecurity.UseVisualStyleBackColor = false;
            // 
            // chkCreationTime
            // 
            this.chkCreationTime.AutoSize = true;
            this.chkCreationTime.Location = new System.Drawing.Point(13, 88);
            this.chkCreationTime.Name = "chkCreationTime";
            this.chkCreationTime.Size = new System.Drawing.Size(88, 17);
            this.chkCreationTime.TabIndex = 20;
            this.chkCreationTime.Text = "CreationTime";
            this.chkCreationTime.UseVisualStyleBackColor = true;
            // 
            // chkFileName
            // 
            this.chkFileName.AutoSize = true;
            this.chkFileName.Checked = true;
            this.chkFileName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFileName.Location = new System.Drawing.Point(13, 19);
            this.chkFileName.Name = "chkFileName";
            this.chkFileName.Size = new System.Drawing.Size(70, 17);
            this.chkFileName.TabIndex = 14;
            this.chkFileName.Text = "FileName";
            this.chkFileName.UseVisualStyleBackColor = true;
            // 
            // chkLastAccess
            // 
            this.chkLastAccess.AutoSize = true;
            this.chkLastAccess.Location = new System.Drawing.Point(115, 65);
            this.chkLastAccess.Name = "chkLastAccess";
            this.chkLastAccess.Size = new System.Drawing.Size(81, 17);
            this.chkLastAccess.TabIndex = 19;
            this.chkLastAccess.Text = "LastAccess";
            this.chkLastAccess.UseVisualStyleBackColor = true;
            // 
            // chkDirectoryName
            // 
            this.chkDirectoryName.AutoSize = true;
            this.chkDirectoryName.Location = new System.Drawing.Point(115, 19);
            this.chkDirectoryName.Name = "chkDirectoryName";
            this.chkDirectoryName.Size = new System.Drawing.Size(96, 17);
            this.chkDirectoryName.TabIndex = 15;
            this.chkDirectoryName.Text = "DirectoryName";
            this.chkDirectoryName.UseVisualStyleBackColor = true;
            // 
            // chkLastWrite
            // 
            this.chkLastWrite.AutoSize = true;
            this.chkLastWrite.Location = new System.Drawing.Point(13, 65);
            this.chkLastWrite.Name = "chkLastWrite";
            this.chkLastWrite.Size = new System.Drawing.Size(71, 17);
            this.chkLastWrite.TabIndex = 18;
            this.chkLastWrite.Text = "LastWrite";
            this.chkLastWrite.UseVisualStyleBackColor = true;
            // 
            // chkAttributes
            // 
            this.chkAttributes.AutoSize = true;
            this.chkAttributes.Location = new System.Drawing.Point(13, 42);
            this.chkAttributes.Name = "chkAttributes";
            this.chkAttributes.Size = new System.Drawing.Size(70, 17);
            this.chkAttributes.TabIndex = 16;
            this.chkAttributes.Text = "Attributes";
            this.chkAttributes.UseVisualStyleBackColor = true;
            // 
            // chkSize
            // 
            this.chkSize.AutoSize = true;
            this.chkSize.Location = new System.Drawing.Point(115, 42);
            this.chkSize.Name = "chkSize";
            this.chkSize.Size = new System.Drawing.Size(46, 17);
            this.chkSize.TabIndex = 17;
            this.chkSize.Text = "Size";
            this.chkSize.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 224);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(51, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 23;
            // 
            // frmTrackFileActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbNotifyFilter);
            this.Controls.Add(this.cmbFilters);
            this.Controls.Add(this.chkIncludeSubdirectories);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblTrackPath);
            this.Controls.Add(this.btnStopTracking);
            this.Controls.Add(this.btnStartTracking);
            this.Controls.Add(this.btnSetPath);
            this.Controls.Add(this.txtSetPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrackFileActivites";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Track File Activites";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrackFileActivites_FormClosing);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.gbNotifyFilter.ResumeLayout(false);
            this.gbNotifyFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtSetPath;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Button btnStartTracking;
        private System.Windows.Forms.Button btnStopTracking;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Label lblTrackPath;
        private System.Windows.Forms.ToolTip toolTipTrackPath;
        private System.Windows.Forms.ToolTip toolTipWorkPath;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.CheckBox chkIncludeSubdirectories;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenLog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolTip toolTipNotifyFilter;
        private System.Windows.Forms.GroupBox gbNotifyFilter;
        private System.Windows.Forms.CheckBox chkSecurity;
        private System.Windows.Forms.CheckBox chkCreationTime;
        private System.Windows.Forms.CheckBox chkFileName;
        private System.Windows.Forms.CheckBox chkLastAccess;
        private System.Windows.Forms.CheckBox chkDirectoryName;
        private System.Windows.Forms.CheckBox chkLastWrite;
        private System.Windows.Forms.CheckBox chkAttributes;
        private System.Windows.Forms.CheckBox chkSize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

