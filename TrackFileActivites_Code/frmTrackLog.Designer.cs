namespace TrackFileActivites
{
    partial class frmTrackLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackLog));
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnHeaderEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtRefreshInterval = new System.Windows.Forms.TextBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.btnManualRefresh = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.chkChanged = new System.Windows.Forms.CheckBox();
            this.chkDeleted = new System.Windows.Forms.CheckBox();
            this.chkRenamed = new System.Windows.Forms.CheckBox();
            this.chkCreated = new System.Windows.Forms.CheckBox();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.gbEventFilter = new System.Windows.Forms.GroupBox();
            this.gbPathFilter = new System.Windows.Forms.GroupBox();
            this.chkPath = new System.Windows.Forms.CheckBox();
            this.gbTimeFilter = new System.Windows.Forms.GroupBox();
            this.gbAutoRefreshInterval = new System.Windows.Forms.GroupBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbEventFilter.SuspendLayout();
            this.gbPathFilter.SuspendLayout();
            this.gbTimeFilter.SuspendLayout();
            this.gbAutoRefreshInterval.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEvent,
            this.columnHeaderPath,
            this.columnHeaderTime});
            this.listViewLog.Location = new System.Drawing.Point(12, 120);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(696, 206);
            this.listViewLog.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            this.listViewLog.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewLog_ColumnClick);
            // 
            // columnHeaderEvent
            // 
            this.columnHeaderEvent.Text = "Event";
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Path";
            this.columnHeaderPath.Width = 550;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Time";
            this.columnHeaderTime.Width = 63;
            // 
            // txtRefreshInterval
            // 
            this.txtRefreshInterval.Location = new System.Drawing.Point(22, 29);
            this.txtRefreshInterval.Name = "txtRefreshInterval";
            this.txtRefreshInterval.Size = new System.Drawing.Size(35, 20);
            this.txtRefreshInterval.TabIndex = 2;
            this.txtRefreshInterval.Text = "1";
            this.txtRefreshInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRefreshInterval.TextChanged += new System.EventHandler(this.txtRefreshInterval_TextChanged);
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(63, 32);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(39, 13);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "Minute";
            // 
            // btnManualRefresh
            // 
            this.btnManualRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManualRefresh.ImageKey = "Refresh.png";
            this.btnManualRefresh.ImageList = this.imageList;
            this.btnManualRefresh.Location = new System.Drawing.Point(603, 39);
            this.btnManualRefresh.Name = "btnManualRefresh";
            this.btnManualRefresh.Size = new System.Drawing.Size(105, 23);
            this.btnManualRefresh.TabIndex = 4;
            this.btnManualRefresh.Text = "Manual Refresh";
            this.btnManualRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManualRefresh.UseVisualStyleBackColor = true;
            this.btnManualRefresh.Click += new System.EventHandler(this.btnManualRefresh_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Refresh.png");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(30, 30);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(47, 20);
            this.txtPath.TabIndex = 9;
            // 
            // dtStartTime
            // 
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtStartTime.Location = new System.Drawing.Point(91, 12);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(100, 20);
            this.dtStartTime.TabIndex = 11;
            this.dtStartTime.Value = new System.DateTime(2008, 7, 23, 0, 0, 0, 0);
            // 
            // chkChanged
            // 
            this.chkChanged.AutoSize = true;
            this.chkChanged.Checked = true;
            this.chkChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChanged.Location = new System.Drawing.Point(6, 22);
            this.chkChanged.Name = "chkChanged";
            this.chkChanged.Size = new System.Drawing.Size(69, 17);
            this.chkChanged.TabIndex = 12;
            this.chkChanged.Text = "Changed";
            this.chkChanged.UseVisualStyleBackColor = true;
            // 
            // chkDeleted
            // 
            this.chkDeleted.AutoSize = true;
            this.chkDeleted.Checked = true;
            this.chkDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeleted.Location = new System.Drawing.Point(81, 22);
            this.chkDeleted.Name = "chkDeleted";
            this.chkDeleted.Size = new System.Drawing.Size(63, 17);
            this.chkDeleted.TabIndex = 13;
            this.chkDeleted.Text = "Deleted";
            this.chkDeleted.UseVisualStyleBackColor = true;
            // 
            // chkRenamed
            // 
            this.chkRenamed.AutoSize = true;
            this.chkRenamed.Checked = true;
            this.chkRenamed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRenamed.Location = new System.Drawing.Point(6, 45);
            this.chkRenamed.Name = "chkRenamed";
            this.chkRenamed.Size = new System.Drawing.Size(72, 17);
            this.chkRenamed.TabIndex = 14;
            this.chkRenamed.Text = "Renamed";
            this.chkRenamed.UseVisualStyleBackColor = true;
            // 
            // chkCreated
            // 
            this.chkCreated.AutoSize = true;
            this.chkCreated.Checked = true;
            this.chkCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreated.Location = new System.Drawing.Point(81, 45);
            this.chkCreated.Name = "chkCreated";
            this.chkCreated.Size = new System.Drawing.Size(63, 17);
            this.chkCreated.TabIndex = 15;
            this.chkCreated.Text = "Created";
            this.chkCreated.UseVisualStyleBackColor = true;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Location = new System.Drawing.Point(6, 32);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(15, 14);
            this.chkTime.TabIndex = 16;
            this.chkTime.UseVisualStyleBackColor = true;
            this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged);
            // 
            // dtEndTime
            // 
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtEndTime.Location = new System.Drawing.Point(91, 38);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(100, 20);
            this.dtEndTime.TabIndex = 17;
            this.dtEndTime.Value = new System.DateTime(2008, 7, 23, 23, 59, 59, 0);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(27, 16);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 18;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(30, 42);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(52, 13);
            this.lblEndTime.TabIndex = 19;
            this.lblEndTime.Text = "End Time";
            // 
            // gbEventFilter
            // 
            this.gbEventFilter.Controls.Add(this.chkChanged);
            this.gbEventFilter.Controls.Add(this.chkDeleted);
            this.gbEventFilter.Controls.Add(this.chkRenamed);
            this.gbEventFilter.Controls.Add(this.chkCreated);
            this.gbEventFilter.Location = new System.Drawing.Point(12, 12);
            this.gbEventFilter.Name = "gbEventFilter";
            this.gbEventFilter.Size = new System.Drawing.Size(147, 75);
            this.gbEventFilter.TabIndex = 21;
            this.gbEventFilter.TabStop = false;
            this.gbEventFilter.Text = "Event Filter";
            // 
            // gbPathFilter
            // 
            this.gbPathFilter.Controls.Add(this.chkPath);
            this.gbPathFilter.Controls.Add(this.txtPath);
            this.gbPathFilter.Location = new System.Drawing.Point(165, 12);
            this.gbPathFilter.Name = "gbPathFilter";
            this.gbPathFilter.Size = new System.Drawing.Size(90, 75);
            this.gbPathFilter.TabIndex = 22;
            this.gbPathFilter.TabStop = false;
            this.gbPathFilter.Text = "Path Filter";
            // 
            // chkPath
            // 
            this.chkPath.AutoSize = true;
            this.chkPath.Location = new System.Drawing.Point(9, 33);
            this.chkPath.Name = "chkPath";
            this.chkPath.Size = new System.Drawing.Size(15, 14);
            this.chkPath.TabIndex = 17;
            this.chkPath.UseVisualStyleBackColor = true;
            this.chkPath.CheckedChanged += new System.EventHandler(this.chkPath_CheckedChanged);
            // 
            // gbTimeFilter
            // 
            this.gbTimeFilter.Controls.Add(this.chkTime);
            this.gbTimeFilter.Controls.Add(this.dtStartTime);
            this.gbTimeFilter.Controls.Add(this.dtEndTime);
            this.gbTimeFilter.Controls.Add(this.lblStartTime);
            this.gbTimeFilter.Controls.Add(this.lblEndTime);
            this.gbTimeFilter.Location = new System.Drawing.Point(261, 12);
            this.gbTimeFilter.Name = "gbTimeFilter";
            this.gbTimeFilter.Size = new System.Drawing.Size(205, 75);
            this.gbTimeFilter.TabIndex = 23;
            this.gbTimeFilter.TabStop = false;
            this.gbTimeFilter.Text = "Time Filter";
            // 
            // gbAutoRefreshInterval
            // 
            this.gbAutoRefreshInterval.Controls.Add(this.txtRefreshInterval);
            this.gbAutoRefreshInterval.Controls.Add(this.lblMinute);
            this.gbAutoRefreshInterval.Location = new System.Drawing.Point(472, 12);
            this.gbAutoRefreshInterval.Name = "gbAutoRefreshInterval";
            this.gbAutoRefreshInterval.Size = new System.Drawing.Size(124, 75);
            this.gbAutoRefreshInterval.TabIndex = 24;
            this.gbAutoRefreshInterval.TabStop = false;
            this.gbAutoRefreshInterval.Text = "Auto Refresh Interval";
            // 
            // txtLogPath
            // 
            this.txtLogPath.Location = new System.Drawing.Point(65, 93);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.ReadOnly = true;
            this.txtLogPath.Size = new System.Drawing.Size(450, 20);
            this.txtLogPath.TabIndex = 25;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(521, 91);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Log Path";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "TrackFileActivities.log";
            this.openFileDialog.Filter = "Track File Activities Log file|TrackFileActivities.log";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Select previous log file or select the default log for today";
            // 
            // frmTrackLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.gbAutoRefreshInterval);
            this.Controls.Add(this.gbTimeFilter);
            this.Controls.Add(this.gbPathFilter);
            this.Controls.Add(this.gbEventFilter);
            this.Controls.Add(this.btnManualRefresh);
            this.Controls.Add(this.listViewLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTrackLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTrackLog_Load);
            this.gbEventFilter.ResumeLayout(false);
            this.gbEventFilter.PerformLayout();
            this.gbPathFilter.ResumeLayout(false);
            this.gbPathFilter.PerformLayout();
            this.gbTimeFilter.ResumeLayout(false);
            this.gbTimeFilter.PerformLayout();
            this.gbAutoRefreshInterval.ResumeLayout(false);
            this.gbAutoRefreshInterval.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.ColumnHeader columnHeaderEvent;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.TextBox txtRefreshInterval;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Button btnManualRefresh;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.CheckBox chkChanged;
        private System.Windows.Forms.CheckBox chkDeleted;
        private System.Windows.Forms.CheckBox chkRenamed;
        private System.Windows.Forms.CheckBox chkCreated;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.GroupBox gbEventFilter;
        private System.Windows.Forms.GroupBox gbPathFilter;
        private System.Windows.Forms.CheckBox chkPath;
        private System.Windows.Forms.GroupBox gbTimeFilter;
        private System.Windows.Forms.GroupBox gbAutoRefreshInterval;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}