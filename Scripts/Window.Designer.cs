namespace ABH.UI
{
    partial class UIProcess
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIProcess));
            this.g_mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.g_LogoBlock = new System.Windows.Forms.Panel();
            this.g_errorDisplay = new System.Windows.Forms.Label();
            this.g_tabsBackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.g_backupsButton = new System.Windows.Forms.Button();
            this.g_revertButton = new System.Windows.Forms.Button();
            this.ReportError = new System.Windows.Forms.Button();
            this.g_backupLabel = new System.Windows.Forms.Label();
            this.g_backupFileLocation = new System.Windows.Forms.TextBox();
            this.g_changeBackupLocationButton = new System.Windows.Forms.Button();
            this.g_backupSaveLocationLabel = new System.Windows.Forms.Label();
            this.g_backupLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.g_mainTimerLoop = new System.Windows.Forms.Timer(this.components);
            this.g_arkSaveLocationLabel = new System.Windows.Forms.Label();
            this.g_arkSaveLocationFilePathDisplay = new System.Windows.Forms.TextBox();
            this.g_changeArkSaveLocationButton = new System.Windows.Forms.Button();
            this.g_arkSaveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.g_saveTimer = new System.Windows.Forms.Timer(this.components);
            this.g_saveIntervalLabel = new System.Windows.Forms.Label();
            this.g_manualBackupButton = new System.Windows.Forms.Button();
            this.g_garbageCollectionTimer = new System.Windows.Forms.Timer(this.components);
            this.g_MinimizeButton = new System.Windows.Forms.Button();
            this.g_TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.g_manualSaveBox = new System.Windows.Forms.Panel();
            this.g_submitButton = new System.Windows.Forms.Button();
            this.g_milestoneCheckbox = new System.Windows.Forms.CheckBox();
            this.g_backupName = new System.Windows.Forms.TextBox();
            this.g_manualBackupPanelLabel = new System.Windows.Forms.Label();
            this.g_maxSavesLabel = new System.Windows.Forms.Label();
            this.g_MaxMapSaves = new System.Windows.Forms.NumericUpDown();
            this.g_updateMoDButton = new System.Windows.Forms.Button();
            this.g_transferDataSaveIntervalChooser = new System.Windows.Forms.NumericUpDown();
            this.g_transferDataSaveIntLabel = new System.Windows.Forms.Label();
            this.g_transferDataSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.g_saveIntervalChooser = new System.Windows.Forms.NumericUpDown();
            this.g_tabsBackgroundPanel.SuspendLayout();
            this.g_manualSaveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_MaxMapSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_transferDataSaveIntervalChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_saveIntervalChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // g_LogoBlock
            // 
            this.g_LogoBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.g_LogoBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("g_LogoBlock.BackgroundImage")));
            this.g_LogoBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.g_LogoBlock.Location = new System.Drawing.Point(0, 0);
            this.g_LogoBlock.Margin = new System.Windows.Forms.Padding(0);
            this.g_LogoBlock.Name = "g_LogoBlock";
            this.g_LogoBlock.Size = new System.Drawing.Size(173, 83);
            this.g_LogoBlock.TabIndex = 0;
            this.g_mainToolTip.SetToolTip(this.g_LogoBlock, "Visit us at sharksinteractive.net");
            // 
            // g_errorDisplay
            // 
            this.g_errorDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.g_errorDisplay.AutoSize = true;
            this.g_errorDisplay.ForeColor = System.Drawing.Color.Red;
            this.g_errorDisplay.Location = new System.Drawing.Point(10, 498);
            this.g_errorDisplay.Name = "g_errorDisplay";
            this.g_errorDisplay.Size = new System.Drawing.Size(230, 23);
            this.g_errorDisplay.TabIndex = 13;
            this.g_errorDisplay.Text = "No errors to display";
            this.g_errorDisplay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.g_mainToolTip.SetToolTip(this.g_errorDisplay, "Test");
            this.g_errorDisplay.TextChanged += new System.EventHandler(this.g_errorDisplay_TextChanged);
            this.g_errorDisplay.Click += new System.EventHandler(this.g_errorDisplay_Click);
            // 
            // g_tabsBackgroundPanel
            // 
            this.g_tabsBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.g_tabsBackgroundPanel.Controls.Add(this.g_LogoBlock);
            this.g_tabsBackgroundPanel.Controls.Add(this.g_backupsButton);
            this.g_tabsBackgroundPanel.Controls.Add(this.g_revertButton);
            this.g_tabsBackgroundPanel.Controls.Add(this.ReportError);
            this.g_tabsBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.g_tabsBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.g_tabsBackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.g_tabsBackgroundPanel.Name = "g_tabsBackgroundPanel";
            this.g_tabsBackgroundPanel.Size = new System.Drawing.Size(891, 83);
            this.g_tabsBackgroundPanel.TabIndex = 4;
            // 
            // g_backupsButton
            // 
            this.g_backupsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.g_backupsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.g_backupsButton.FlatAppearance.BorderSize = 0;
            this.g_backupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_backupsButton.ForeColor = System.Drawing.Color.White;
            this.g_backupsButton.Image = ((System.Drawing.Image)(resources.GetObject("g_backupsButton.Image")));
            this.g_backupsButton.Location = new System.Drawing.Point(173, 0);
            this.g_backupsButton.Margin = new System.Windows.Forms.Padding(0);
            this.g_backupsButton.Name = "g_backupsButton";
            this.g_backupsButton.Size = new System.Drawing.Size(104, 83);
            this.g_backupsButton.TabIndex = 1;
            this.g_backupsButton.Text = "Backups";
            this.g_backupsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.g_backupsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.g_backupsButton.UseVisualStyleBackColor = false;
            // 
            // g_revertButton
            // 
            this.g_revertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.g_revertButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.g_revertButton.FlatAppearance.BorderSize = 0;
            this.g_revertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_revertButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_revertButton.ForeColor = System.Drawing.Color.White;
            this.g_revertButton.Image = ((System.Drawing.Image)(resources.GetObject("g_revertButton.Image")));
            this.g_revertButton.Location = new System.Drawing.Point(277, 0);
            this.g_revertButton.Margin = new System.Windows.Forms.Padding(0);
            this.g_revertButton.Name = "g_revertButton";
            this.g_revertButton.Size = new System.Drawing.Size(104, 83);
            this.g_revertButton.TabIndex = 2;
            this.g_revertButton.Text = "Revert";
            this.g_revertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.g_revertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.g_revertButton.UseVisualStyleBackColor = false;
            // 
            // ReportError
            // 
            this.ReportError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportError.Location = new System.Drawing.Point(384, 3);
            this.ReportError.Name = "ReportError";
            this.ReportError.Size = new System.Drawing.Size(75, 23);
            this.ReportError.TabIndex = 3;
            this.ReportError.Text = "button1";
            this.ReportError.UseVisualStyleBackColor = true;
            // 
            // g_backupLabel
            // 
            this.g_backupLabel.AutoSize = true;
            this.g_backupLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_backupLabel.ForeColor = System.Drawing.Color.White;
            this.g_backupLabel.Location = new System.Drawing.Point(0, 83);
            this.g_backupLabel.Name = "g_backupLabel";
            this.g_backupLabel.Size = new System.Drawing.Size(169, 40);
            this.g_backupLabel.TabIndex = 8;
            this.g_backupLabel.Text = "Backups:";
            // 
            // g_backupFileLocation
            // 
            this.g_backupFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_backupFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_backupFileLocation.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_backupFileLocation.ForeColor = System.Drawing.Color.White;
            this.g_backupFileLocation.Location = new System.Drawing.Point(12, 153);
            this.g_backupFileLocation.Name = "g_backupFileLocation";
            this.g_backupFileLocation.ReadOnly = true;
            this.g_backupFileLocation.Size = new System.Drawing.Size(409, 27);
            this.g_backupFileLocation.TabIndex = 9;
            // 
            // g_changeBackupLocationButton
            // 
            this.g_changeBackupLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeBackupLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeBackupLocationButton.FlatAppearance.BorderSize = 15;
            this.g_changeBackupLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_changeBackupLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_changeBackupLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.g_changeBackupLocationButton.Location = new System.Drawing.Point(428, 153);
            this.g_changeBackupLocationButton.Name = "g_changeBackupLocationButton";
            this.g_changeBackupLocationButton.Size = new System.Drawing.Size(94, 29);
            this.g_changeBackupLocationButton.TabIndex = 10;
            this.g_changeBackupLocationButton.Text = "Change";
            this.g_changeBackupLocationButton.UseVisualStyleBackColor = false;
            this.g_changeBackupLocationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_changeBackupLocationButton_MouseClick);
            // 
            // g_backupSaveLocationLabel
            // 
            this.g_backupSaveLocationLabel.AutoSize = true;
            this.g_backupSaveLocationLabel.Location = new System.Drawing.Point(12, 127);
            this.g_backupSaveLocationLabel.Name = "g_backupSaveLocationLabel";
            this.g_backupSaveLocationLabel.Size = new System.Drawing.Size(230, 23);
            this.g_backupSaveLocationLabel.TabIndex = 11;
            this.g_backupSaveLocationLabel.Text = "Backup Save Location";
            // 
            // g_mainTimerLoop
            // 
            this.g_mainTimerLoop.Interval = 500;
            this.g_mainTimerLoop.Tick += new System.EventHandler(this.g_mainTimerLoopRun);
            // 
            // g_arkSaveLocationLabel
            // 
            this.g_arkSaveLocationLabel.AutoSize = true;
            this.g_arkSaveLocationLabel.Location = new System.Drawing.Point(12, 198);
            this.g_arkSaveLocationLabel.Name = "g_arkSaveLocationLabel";
            this.g_arkSaveLocationLabel.Size = new System.Drawing.Size(197, 23);
            this.g_arkSaveLocationLabel.TabIndex = 11;
            this.g_arkSaveLocationLabel.Text = "Ark Save Location";
            // 
            // g_arkSaveLocationFilePathDisplay
            // 
            this.g_arkSaveLocationFilePathDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_arkSaveLocationFilePathDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_arkSaveLocationFilePathDisplay.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_arkSaveLocationFilePathDisplay.ForeColor = System.Drawing.Color.White;
            this.g_arkSaveLocationFilePathDisplay.Location = new System.Drawing.Point(12, 224);
            this.g_arkSaveLocationFilePathDisplay.Name = "g_arkSaveLocationFilePathDisplay";
            this.g_arkSaveLocationFilePathDisplay.ReadOnly = true;
            this.g_arkSaveLocationFilePathDisplay.Size = new System.Drawing.Size(409, 27);
            this.g_arkSaveLocationFilePathDisplay.TabIndex = 9;
            // 
            // g_changeArkSaveLocationButton
            // 
            this.g_changeArkSaveLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeArkSaveLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeArkSaveLocationButton.FlatAppearance.BorderSize = 15;
            this.g_changeArkSaveLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_changeArkSaveLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_changeArkSaveLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.g_changeArkSaveLocationButton.Location = new System.Drawing.Point(427, 224);
            this.g_changeArkSaveLocationButton.Name = "g_changeArkSaveLocationButton";
            this.g_changeArkSaveLocationButton.Size = new System.Drawing.Size(94, 29);
            this.g_changeArkSaveLocationButton.TabIndex = 10;
            this.g_changeArkSaveLocationButton.Text = "Change";
            this.g_changeArkSaveLocationButton.UseVisualStyleBackColor = false;
            this.g_changeArkSaveLocationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_changeArkSaveLocationButton_MouseClick);
            // 
            // g_saveTimer
            // 
            this.g_saveTimer.Tick += new System.EventHandler(this.g_saveTimer_Tick);
            // 
            // g_saveIntervalLabel
            // 
            this.g_saveIntervalLabel.AutoSize = true;
            this.g_saveIntervalLabel.Location = new System.Drawing.Point(543, 155);
            this.g_saveIntervalLabel.Name = "g_saveIntervalLabel";
            this.g_saveIntervalLabel.Size = new System.Drawing.Size(274, 23);
            this.g_saveIntervalLabel.TabIndex = 11;
            this.g_saveIntervalLabel.Text = "AutoSave interval (mins)";
            // 
            // g_manualBackupButton
            // 
            this.g_manualBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_manualBackupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.g_manualBackupButton.FlatAppearance.BorderSize = 15;
            this.g_manualBackupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_manualBackupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_manualBackupButton.Location = new System.Drawing.Point(543, 224);
            this.g_manualBackupButton.Name = "g_manualBackupButton";
            this.g_manualBackupButton.Size = new System.Drawing.Size(336, 29);
            this.g_manualBackupButton.TabIndex = 10;
            this.g_manualBackupButton.Text = "Manual Backup";
            this.g_manualBackupButton.UseVisualStyleBackColor = false;
            this.g_manualBackupButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_manualBackupLocationButton_MouseClick);
            // 
            // g_garbageCollectionTimer
            // 
            this.g_garbageCollectionTimer.Interval = 120000;
            this.g_garbageCollectionTimer.Tick += new System.EventHandler(this.g_garbageCollectionTimer_Tick);
            // 
            // g_MinimizeButton
            // 
            this.g_MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.g_MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_MinimizeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.g_MinimizeButton.Location = new System.Drawing.Point(860, 0);
            this.g_MinimizeButton.Name = "g_MinimizeButton";
            this.g_MinimizeButton.Size = new System.Drawing.Size(31, 33);
            this.g_MinimizeButton.TabIndex = 1;
            this.g_MinimizeButton.Text = "-";
            this.g_MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.g_MinimizeButton.UseVisualStyleBackColor = false;
            this.g_MinimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_MinimizeButton_MouseClick);
            // 
            // g_TrayIcon
            // 
            this.g_TrayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.g_TrayIcon.BalloonTipText = "Open Ark Backup Handler";
            this.g_TrayIcon.BalloonTipTitle = "Ark Backup Handler";
            this.g_TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("g_TrayIcon.Icon")));
            this.g_TrayIcon.Text = "Open Ark Backup Handler (Stable)";
            this.g_TrayIcon.Visible = true;
            this.g_TrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_TrayIcon_MouseClick);
            // 
            // g_manualSaveBox
            // 
            this.g_manualSaveBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.g_manualSaveBox.BackColor = System.Drawing.Color.Gray;
            this.g_manualSaveBox.Controls.Add(this.g_submitButton);
            this.g_manualSaveBox.Controls.Add(this.g_milestoneCheckbox);
            this.g_manualSaveBox.Controls.Add(this.g_backupName);
            this.g_manualSaveBox.Controls.Add(this.g_manualBackupPanelLabel);
            this.g_manualSaveBox.Location = new System.Drawing.Point(330, 211);
            this.g_manualSaveBox.Name = "g_manualSaveBox";
            this.g_manualSaveBox.Size = new System.Drawing.Size(250, 125);
            this.g_manualSaveBox.TabIndex = 14;
            this.g_manualSaveBox.Visible = false;
            // 
            // g_submitButton
            // 
            this.g_submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_submitButton.Location = new System.Drawing.Point(69, 96);
            this.g_submitButton.Name = "g_submitButton";
            this.g_submitButton.Size = new System.Drawing.Size(94, 29);
            this.g_submitButton.TabIndex = 3;
            this.g_submitButton.Text = "Backup";
            this.g_submitButton.UseVisualStyleBackColor = false;
            this.g_submitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_submitButton_MouseClick);
            // 
            // g_milestoneCheckbox
            // 
            this.g_milestoneCheckbox.AutoSize = true;
            this.g_milestoneCheckbox.Location = new System.Drawing.Point(21, 64);
            this.g_milestoneCheckbox.Name = "g_milestoneCheckbox";
            this.g_milestoneCheckbox.Size = new System.Drawing.Size(142, 27);
            this.g_milestoneCheckbox.TabIndex = 2;
            this.g_milestoneCheckbox.Text = "Milestone?";
            this.g_milestoneCheckbox.UseVisualStyleBackColor = true;
            // 
            // g_backupName
            // 
            this.g_backupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_backupName.Location = new System.Drawing.Point(9, 26);
            this.g_backupName.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.g_backupName.Name = "g_backupName";
            this.g_backupName.PlaceholderText = "Indy Forge built";
            this.g_backupName.Size = new System.Drawing.Size(227, 31);
            this.g_backupName.TabIndex = 1;
            // 
            // g_manualBackupPanelLabel
            // 
            this.g_manualBackupPanelLabel.AutoSize = true;
            this.g_manualBackupPanelLabel.Location = new System.Drawing.Point(21, 0);
            this.g_manualBackupPanelLabel.Name = "g_manualBackupPanelLabel";
            this.g_manualBackupPanelLabel.Size = new System.Drawing.Size(186, 23);
            this.g_manualBackupPanelLabel.TabIndex = 0;
            this.g_manualBackupPanelLabel.Text = "Name this Backup";
            // 
            // g_maxSavesLabel
            // 
            this.g_maxSavesLabel.AutoSize = true;
            this.g_maxSavesLabel.Location = new System.Drawing.Point(653, 275);
            this.g_maxSavesLabel.Name = "g_maxSavesLabel";
            this.g_maxSavesLabel.Size = new System.Drawing.Size(164, 23);
            this.g_maxSavesLabel.TabIndex = 15;
            this.g_maxSavesLabel.Text = "Max Auto Saves";
            // 
            // g_MaxMapSaves
            // 
            this.g_MaxMapSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_MaxMapSaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_MaxMapSaves.ForeColor = System.Drawing.Color.White;
            this.g_MaxMapSaves.Location = new System.Drawing.Point(823, 274);
            this.g_MaxMapSaves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.g_MaxMapSaves.Name = "g_MaxMapSaves";
            this.g_MaxMapSaves.Size = new System.Drawing.Size(56, 31);
            this.g_MaxMapSaves.TabIndex = 16;
            this.g_MaxMapSaves.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.g_MaxMapSaves.ValueChanged += new System.EventHandler(this.g_MaxMapSaves_ValueChanged);
            // 
            // g_updateMoDButton
            // 
            this.g_updateMoDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_updateMoDButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.g_updateMoDButton.FlatAppearance.BorderSize = 15;
            this.g_updateMoDButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_updateMoDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_updateMoDButton.Location = new System.Drawing.Point(695, 484);
            this.g_updateMoDButton.Name = "g_updateMoDButton";
            this.g_updateMoDButton.Size = new System.Drawing.Size(184, 29);
            this.g_updateMoDButton.TabIndex = 17;
            this.g_updateMoDButton.Text = "Update MoD";
            this.g_updateMoDButton.UseVisualStyleBackColor = false;
            this.g_updateMoDButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_updateMoDButton_MouseClick);
            // 
            // g_transferDataSaveIntervalChooser
            // 
            this.g_transferDataSaveIntervalChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_transferDataSaveIntervalChooser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_transferDataSaveIntervalChooser.DecimalPlaces = 1;
            this.g_transferDataSaveIntervalChooser.ForeColor = System.Drawing.Color.White;
            this.g_transferDataSaveIntervalChooser.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.g_transferDataSaveIntervalChooser.Location = new System.Drawing.Point(823, 320);
            this.g_transferDataSaveIntervalChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.g_transferDataSaveIntervalChooser.Name = "g_transferDataSaveIntervalChooser";
            this.g_transferDataSaveIntervalChooser.Size = new System.Drawing.Size(56, 31);
            this.g_transferDataSaveIntervalChooser.TabIndex = 18;
            this.g_transferDataSaveIntervalChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.g_transferDataSaveIntervalChooser.ValueChanged += new System.EventHandler(this.g_transferDataSaveIntervalChooser_ValueChanged);
            // 
            // g_transferDataSaveIntLabel
            // 
            this.g_transferDataSaveIntLabel.AutoSize = true;
            this.g_transferDataSaveIntLabel.Location = new System.Drawing.Point(510, 322);
            this.g_transferDataSaveIntLabel.Name = "g_transferDataSaveIntLabel";
            this.g_transferDataSaveIntLabel.Size = new System.Drawing.Size(307, 23);
            this.g_transferDataSaveIntLabel.TabIndex = 19;
            this.g_transferDataSaveIntLabel.Text = "Transfer Data Save Interval";
            // 
            // g_transferDataSaveTimer
            // 
            this.g_transferDataSaveTimer.Tick += new System.EventHandler(this.g_transferDataSaveTimer_Tick);
            // 
            // g_saveIntervalChooser
            // 
            this.g_saveIntervalChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_saveIntervalChooser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_saveIntervalChooser.DecimalPlaces = 1;
            this.g_saveIntervalChooser.ForeColor = System.Drawing.Color.White;
            this.g_saveIntervalChooser.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.g_saveIntervalChooser.Location = new System.Drawing.Point(823, 155);
            this.g_saveIntervalChooser.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.g_saveIntervalChooser.Name = "g_saveIntervalChooser";
            this.g_saveIntervalChooser.Size = new System.Drawing.Size(56, 31);
            this.g_saveIntervalChooser.TabIndex = 20;
            this.g_saveIntervalChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UIProcess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.g_saveIntervalChooser);
            this.Controls.Add(this.g_transferDataSaveIntLabel);
            this.Controls.Add(this.g_transferDataSaveIntervalChooser);
            this.Controls.Add(this.g_updateMoDButton);
            this.Controls.Add(this.g_MaxMapSaves);
            this.Controls.Add(this.g_maxSavesLabel);
            this.Controls.Add(this.g_manualSaveBox);
            this.Controls.Add(this.g_errorDisplay);
            this.Controls.Add(this.g_MinimizeButton);
            this.Controls.Add(this.g_manualBackupButton);
            this.Controls.Add(this.g_saveIntervalLabel);
            this.Controls.Add(this.g_changeArkSaveLocationButton);
            this.Controls.Add(this.g_arkSaveLocationFilePathDisplay);
            this.Controls.Add(this.g_arkSaveLocationLabel);
            this.Controls.Add(this.g_backupSaveLocationLabel);
            this.Controls.Add(this.g_changeBackupLocationButton);
            this.Controls.Add(this.g_backupFileLocation);
            this.Controls.Add(this.g_backupLabel);
            this.Controls.Add(this.g_tabsBackgroundPanel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UIProcess";
            this.Text = "Ark Backup Handler (Stable)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIProcess_Closing);
            this.g_tabsBackgroundPanel.ResumeLayout(false);
            this.g_manualSaveBox.ResumeLayout(false);
            this.g_manualSaveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_MaxMapSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_transferDataSaveIntervalChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_saveIntervalChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip g_mainToolTip;
        private System.Windows.Forms.Panel g_LogoBlock;
        private System.Windows.Forms.FlowLayoutPanel g_tabsBackgroundPanel;
        private System.Windows.Forms.Label g_backupLabel;
        private System.Windows.Forms.TextBox g_backupFileLocation;
        private System.Windows.Forms.Button g_changeBackupLocationButton;
        private System.Windows.Forms.Label g_backupSaveLocationLabel;
        private System.Windows.Forms.FolderBrowserDialog g_backupLocationDialog;
        private System.Windows.Forms.Timer g_mainTimerLoop;
        private System.Windows.Forms.Label g_arkSaveLocationLabel;
        private System.Windows.Forms.TextBox g_arkSaveLocationFilePathDisplay;
        private System.Windows.Forms.Button g_changeArkSaveLocationButton;
        private System.Windows.Forms.FolderBrowserDialog g_arkSaveLocationDialog;
        private System.Windows.Forms.Timer g_saveTimer;
        private System.Windows.Forms.Label g_saveIntervalLabel;
        private System.Windows.Forms.Button g_manualBackupButton;
        private System.Windows.Forms.Label g_errorDisplay;
        private System.Windows.Forms.Timer g_garbageCollectionTimer;
        private System.Windows.Forms.Button g_MinimizeButton;
        private System.Windows.Forms.NotifyIcon g_TrayIcon;
        private System.Windows.Forms.Panel g_manualSaveBox;
        private System.Windows.Forms.Label g_manualBackupPanelLabel;
        private System.Windows.Forms.TextBox g_backupName;
        private System.Windows.Forms.Button g_submitButton;
        private System.Windows.Forms.CheckBox g_milestoneCheckbox;
        private System.Windows.Forms.Label g_maxSavesLabel;
        private System.Windows.Forms.NumericUpDown g_MaxMapSaves;
        private System.Windows.Forms.Button g_updateMoDButton;
        private System.Windows.Forms.NumericUpDown g_transferDataSaveIntervalChooser;
        private System.Windows.Forms.Label g_transferDataSaveIntLabel;
        private System.Windows.Forms.Timer g_transferDataSaveTimer;
        private System.Windows.Forms.Button g_backupsButton;
        private System.Windows.Forms.Button g_revertButton;
        private System.Windows.Forms.Button ReportError;
        private System.Windows.Forms.NumericUpDown g_saveIntervalChooser;
    }
}

