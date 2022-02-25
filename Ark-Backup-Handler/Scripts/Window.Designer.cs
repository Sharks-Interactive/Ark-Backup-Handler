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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MILESTONES");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("MANUAL", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("AUTOMATIC");
            this.g_mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.g_LogoBlock = new System.Windows.Forms.Panel();
            this.g_errorDisplay = new System.Windows.Forms.Label();
            this.g_backupFileLocation = new System.Windows.Forms.TextBox();
            this.g_backupSaveLocationLabel = new System.Windows.Forms.Label();
            this.g_arkSaveLocationLabel = new System.Windows.Forms.Label();
            this.g_arkSaveLocationFilePathDisplay = new System.Windows.Forms.TextBox();
            this.g_saveIntervalLabel = new System.Windows.Forms.Label();
            this.g_manualBackupButton = new System.Windows.Forms.Button();
            this.g_MinimizeButton = new System.Windows.Forms.Button();
            this.g_submitButton = new System.Windows.Forms.Button();
            this.g_milestoneCheckbox = new System.Windows.Forms.CheckBox();
            this.g_backupName = new System.Windows.Forms.TextBox();
            this.g_maxSavesLabel = new System.Windows.Forms.Label();
            this.g_MaxMapSaves = new System.Windows.Forms.NumericUpDown();
            this.g_updateMoDButton = new System.Windows.Forms.Button();
            this.g_transferDataSaveIntervalChooser = new System.Windows.Forms.NumericUpDown();
            this.g_transferDataSaveIntLabel = new System.Windows.Forms.Label();
            this.g_saveIntervalChooser = new System.Windows.Forms.NumericUpDown();
            this.g_reportProblemButton = new System.Windows.Forms.Button();
            this.g_tabsBackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.g_backupsButton = new System.Windows.Forms.Button();
            this.g_revertButton = new System.Windows.Forms.Button();
            this.g_backupLabel = new System.Windows.Forms.Label();
            this.g_changeBackupLocationButton = new System.Windows.Forms.Button();
            this.g_backupLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.g_mainTimerLoop = new System.Windows.Forms.Timer(this.components);
            this.g_changeArkSaveLocationButton = new System.Windows.Forms.Button();
            this.g_arkSaveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.g_saveTimer = new System.Windows.Forms.Timer(this.components);
            this.g_garbageCollectionTimer = new System.Windows.Forms.Timer(this.components);
            this.g_TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.g_manualSaveBox = new System.Windows.Forms.Panel();
            this.g_manualBackupPanelLabel = new System.Windows.Forms.Label();
            this.g_transferDataSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.g_tabs = new System.Windows.Forms.TabControl();
            this.g_backup = new System.Windows.Forms.TabPage();
            this.g_revert = new System.Windows.Forms.TabPage();
            this.g_container = new System.Windows.Forms.SplitContainer();
            this.g_backupsList = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.g_MaxMapSaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_transferDataSaveIntervalChooser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_saveIntervalChooser)).BeginInit();
            this.g_tabsBackgroundPanel.SuspendLayout();
            this.g_manualSaveBox.SuspendLayout();
            this.g_tabs.SuspendLayout();
            this.g_backup.SuspendLayout();
            this.g_revert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_container)).BeginInit();
            this.g_container.Panel2.SuspendLayout();
            this.g_container.SuspendLayout();
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
            // g_backupFileLocation
            // 
            this.g_backupFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_backupFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_backupFileLocation.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_backupFileLocation.ForeColor = System.Drawing.Color.White;
            this.g_backupFileLocation.Location = new System.Drawing.Point(6, 118);
            this.g_backupFileLocation.Name = "g_backupFileLocation";
            this.g_backupFileLocation.ReadOnly = true;
            this.g_backupFileLocation.Size = new System.Drawing.Size(409, 27);
            this.g_backupFileLocation.TabIndex = 9;
            this.g_mainToolTip.SetToolTip(this.g_backupFileLocation, "The directory to put our backups in.");
            // 
            // g_backupSaveLocationLabel
            // 
            this.g_backupSaveLocationLabel.AutoSize = true;
            this.g_backupSaveLocationLabel.Location = new System.Drawing.Point(5, 85);
            this.g_backupSaveLocationLabel.Name = "g_backupSaveLocationLabel";
            this.g_backupSaveLocationLabel.Size = new System.Drawing.Size(230, 23);
            this.g_backupSaveLocationLabel.TabIndex = 11;
            this.g_backupSaveLocationLabel.Text = "Backup Save Location";
            this.g_mainToolTip.SetToolTip(this.g_backupSaveLocationLabel, "The directory to put our backups in.");
            // 
            // g_arkSaveLocationLabel
            // 
            this.g_arkSaveLocationLabel.AutoSize = true;
            this.g_arkSaveLocationLabel.Location = new System.Drawing.Point(3, 160);
            this.g_arkSaveLocationLabel.Name = "g_arkSaveLocationLabel";
            this.g_arkSaveLocationLabel.Size = new System.Drawing.Size(197, 23);
            this.g_arkSaveLocationLabel.TabIndex = 11;
            this.g_arkSaveLocationLabel.Text = "Ark Save Location";
            this.g_mainToolTip.SetToolTip(this.g_arkSaveLocationLabel, "The location of your Ark saves.");
            // 
            // g_arkSaveLocationFilePathDisplay
            // 
            this.g_arkSaveLocationFilePathDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_arkSaveLocationFilePathDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_arkSaveLocationFilePathDisplay.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_arkSaveLocationFilePathDisplay.ForeColor = System.Drawing.Color.White;
            this.g_arkSaveLocationFilePathDisplay.Location = new System.Drawing.Point(8, 189);
            this.g_arkSaveLocationFilePathDisplay.Name = "g_arkSaveLocationFilePathDisplay";
            this.g_arkSaveLocationFilePathDisplay.ReadOnly = true;
            this.g_arkSaveLocationFilePathDisplay.Size = new System.Drawing.Size(409, 27);
            this.g_arkSaveLocationFilePathDisplay.TabIndex = 9;
            this.g_mainToolTip.SetToolTip(this.g_arkSaveLocationFilePathDisplay, "The location of your Ark saves.");
            // 
            // g_saveIntervalLabel
            // 
            this.g_saveIntervalLabel.AutoSize = true;
            this.g_saveIntervalLabel.Location = new System.Drawing.Point(536, 120);
            this.g_saveIntervalLabel.Name = "g_saveIntervalLabel";
            this.g_saveIntervalLabel.Size = new System.Drawing.Size(274, 23);
            this.g_saveIntervalLabel.TabIndex = 11;
            this.g_saveIntervalLabel.Text = "AutoSave interval (mins)";
            this.g_mainToolTip.SetToolTip(this.g_saveIntervalLabel, "How often a backup will be carried out");
            // 
            // g_manualBackupButton
            // 
            this.g_manualBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_manualBackupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.g_manualBackupButton.FlatAppearance.BorderSize = 15;
            this.g_manualBackupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_manualBackupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_manualBackupButton.Location = new System.Drawing.Point(539, 189);
            this.g_manualBackupButton.Name = "g_manualBackupButton";
            this.g_manualBackupButton.Size = new System.Drawing.Size(336, 29);
            this.g_manualBackupButton.TabIndex = 10;
            this.g_manualBackupButton.Text = "Manual Backup";
            this.g_mainToolTip.SetToolTip(this.g_manualBackupButton, "Click to open the dialog to make a manual backup");
            this.g_manualBackupButton.UseVisualStyleBackColor = false;
            this.g_manualBackupButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_manualBackupLocationButton_MouseClick);
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
            this.g_mainToolTip.SetToolTip(this.g_MinimizeButton, "Minimizes the window to the system tray.");
            this.g_MinimizeButton.UseVisualStyleBackColor = false;
            this.g_MinimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_MinimizeButton_MouseClick);
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
            this.g_mainToolTip.SetToolTip(this.g_submitButton, "Creates the manual backup.");
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
            this.g_mainToolTip.SetToolTip(this.g_milestoneCheckbox, "Milestones are saved in a seperate folder for easier acess and show up seperately" +
        " in the revert tab.");
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
            this.g_mainToolTip.SetToolTip(this.g_backupName, "What should the folder be named. Give it a descriptive title of what was accompli" +
        "shed. Date/Time is appended automatically.");
            // 
            // g_maxSavesLabel
            // 
            this.g_maxSavesLabel.AutoSize = true;
            this.g_maxSavesLabel.Location = new System.Drawing.Point(646, 235);
            this.g_maxSavesLabel.Name = "g_maxSavesLabel";
            this.g_maxSavesLabel.Size = new System.Drawing.Size(164, 23);
            this.g_maxSavesLabel.TabIndex = 15;
            this.g_maxSavesLabel.Text = "Max Auto Saves";
            this.g_mainToolTip.SetToolTip(this.g_maxSavesLabel, "The maximum number of saves to keep on the hard drive at any given time. After th" +
        "is we will start overwriting previous saves.");
            // 
            // g_MaxMapSaves
            // 
            this.g_MaxMapSaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_MaxMapSaves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.g_MaxMapSaves.ForeColor = System.Drawing.Color.White;
            this.g_MaxMapSaves.Location = new System.Drawing.Point(819, 236);
            this.g_MaxMapSaves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.g_MaxMapSaves.Name = "g_MaxMapSaves";
            this.g_MaxMapSaves.Size = new System.Drawing.Size(56, 31);
            this.g_MaxMapSaves.TabIndex = 16;
            this.g_mainToolTip.SetToolTip(this.g_MaxMapSaves, "The maximum number of saves to keep on the hard drive at any given time. After th" +
        "is we will start overwriting previous saves.");
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
            this.g_updateMoDButton.Location = new System.Drawing.Point(691, 449);
            this.g_updateMoDButton.Name = "g_updateMoDButton";
            this.g_updateMoDButton.Size = new System.Drawing.Size(184, 29);
            this.g_updateMoDButton.TabIndex = 17;
            this.g_updateMoDButton.Text = "Update MoD";
            this.g_mainToolTip.SetToolTip(this.g_updateMoDButton, "Updates the message of the day with the latest information.");
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
            this.g_transferDataSaveIntervalChooser.Location = new System.Drawing.Point(819, 285);
            this.g_transferDataSaveIntervalChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.g_transferDataSaveIntervalChooser.Name = "g_transferDataSaveIntervalChooser";
            this.g_transferDataSaveIntervalChooser.Size = new System.Drawing.Size(56, 31);
            this.g_transferDataSaveIntervalChooser.TabIndex = 18;
            this.g_mainToolTip.SetToolTip(this.g_transferDataSaveIntervalChooser, "How often we backup transfer (cluster) data.");
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
            this.g_transferDataSaveIntLabel.Location = new System.Drawing.Point(503, 284);
            this.g_transferDataSaveIntLabel.Name = "g_transferDataSaveIntLabel";
            this.g_transferDataSaveIntLabel.Size = new System.Drawing.Size(307, 23);
            this.g_transferDataSaveIntLabel.TabIndex = 19;
            this.g_transferDataSaveIntLabel.Text = "Transfer Data Save Interval";
            this.g_mainToolTip.SetToolTip(this.g_transferDataSaveIntLabel, "How often we backup transfer (cluster) data.");
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
            this.g_saveIntervalChooser.Location = new System.Drawing.Point(819, 121);
            this.g_saveIntervalChooser.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.g_saveIntervalChooser.Name = "g_saveIntervalChooser";
            this.g_saveIntervalChooser.Size = new System.Drawing.Size(56, 31);
            this.g_saveIntervalChooser.TabIndex = 20;
            this.g_mainToolTip.SetToolTip(this.g_saveIntervalChooser, "How often a backup will be carried out");
            this.g_saveIntervalChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.g_saveIntervalChooser.ValueChanged += new System.EventHandler(this.g_saveIntervalChooser_ValueChanged);
            // 
            // g_reportProblemButton
            // 
            this.g_reportProblemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.g_reportProblemButton.BackColor = System.Drawing.Color.Red;
            this.g_reportProblemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g_reportProblemButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.g_reportProblemButton.Location = new System.Drawing.Point(653, 0);
            this.g_reportProblemButton.Name = "g_reportProblemButton";
            this.g_reportProblemButton.Size = new System.Drawing.Size(201, 33);
            this.g_reportProblemButton.TabIndex = 21;
            this.g_reportProblemButton.Text = "Report Problem";
            this.g_reportProblemButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.g_mainToolTip.SetToolTip(this.g_reportProblemButton, "Opens the GitHub issues page in your browser where you can report problems, reque" +
        "st features and more.");
            this.g_reportProblemButton.UseVisualStyleBackColor = false;
            this.g_reportProblemButton.Click += new System.EventHandler(this.g_reportProblemButton_Click);
            // 
            // g_tabsBackgroundPanel
            // 
            this.g_tabsBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.g_tabsBackgroundPanel.Controls.Add(this.g_LogoBlock);
            this.g_tabsBackgroundPanel.Controls.Add(this.g_backupsButton);
            this.g_tabsBackgroundPanel.Controls.Add(this.g_revertButton);
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
            this.g_backupsButton.Image = global::ABH.Properties.Resources.Settings;
            this.g_backupsButton.Location = new System.Drawing.Point(173, 0);
            this.g_backupsButton.Margin = new System.Windows.Forms.Padding(0);
            this.g_backupsButton.Name = "g_backupsButton";
            this.g_backupsButton.Size = new System.Drawing.Size(104, 83);
            this.g_backupsButton.TabIndex = 1;
            this.g_backupsButton.Text = "Backups";
            this.g_backupsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.g_backupsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.g_backupsButton.UseVisualStyleBackColor = false;
            this.g_backupsButton.Click += new System.EventHandler(this.g_backupsButton_Click);
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
            this.g_revertButton.Click += new System.EventHandler(this.g_revertButton_Click);
            // 
            // g_backupLabel
            // 
            this.g_backupLabel.AutoSize = true;
            this.g_backupLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.g_backupLabel.ForeColor = System.Drawing.Color.White;
            this.g_backupLabel.Location = new System.Drawing.Point(-3, 45);
            this.g_backupLabel.Name = "g_backupLabel";
            this.g_backupLabel.Size = new System.Drawing.Size(169, 40);
            this.g_backupLabel.TabIndex = 8;
            this.g_backupLabel.Text = "Backups:";
            // 
            // g_changeBackupLocationButton
            // 
            this.g_changeBackupLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeBackupLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeBackupLocationButton.FlatAppearance.BorderSize = 15;
            this.g_changeBackupLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_changeBackupLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_changeBackupLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.g_changeBackupLocationButton.Location = new System.Drawing.Point(423, 117);
            this.g_changeBackupLocationButton.Name = "g_changeBackupLocationButton";
            this.g_changeBackupLocationButton.Size = new System.Drawing.Size(94, 29);
            this.g_changeBackupLocationButton.TabIndex = 10;
            this.g_changeBackupLocationButton.Text = "Change";
            this.g_changeBackupLocationButton.UseVisualStyleBackColor = false;
            this.g_changeBackupLocationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.g_changeBackupLocationButton_MouseClick);
            // 
            // g_mainTimerLoop
            // 
            this.g_mainTimerLoop.Interval = 500;
            this.g_mainTimerLoop.Tick += new System.EventHandler(this.g_mainTimerLoopRun);
            // 
            // g_changeArkSaveLocationButton
            // 
            this.g_changeArkSaveLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeArkSaveLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.g_changeArkSaveLocationButton.FlatAppearance.BorderSize = 15;
            this.g_changeArkSaveLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.g_changeArkSaveLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.g_changeArkSaveLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.g_changeArkSaveLocationButton.Location = new System.Drawing.Point(423, 189);
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
            // g_garbageCollectionTimer
            // 
            this.g_garbageCollectionTimer.Interval = 120000;
            this.g_garbageCollectionTimer.Tick += new System.EventHandler(this.g_garbageCollectionTimer_Tick);
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
            this.g_manualSaveBox.Location = new System.Drawing.Point(338, 184);
            this.g_manualSaveBox.Name = "g_manualSaveBox";
            this.g_manualSaveBox.Size = new System.Drawing.Size(250, 125);
            this.g_manualSaveBox.TabIndex = 14;
            this.g_manualSaveBox.Visible = false;
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
            // g_transferDataSaveTimer
            // 
            this.g_transferDataSaveTimer.Tick += new System.EventHandler(this.g_transferDataSaveTimer_Tick);
            // 
            // g_tabs
            // 
            this.g_tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.g_tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.g_tabs.Controls.Add(this.g_backup);
            this.g_tabs.Controls.Add(this.g_revert);
            this.g_tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.g_tabs.ItemSize = new System.Drawing.Size(100, 0);
            this.g_tabs.Location = new System.Drawing.Point(-9, 0);
            this.g_tabs.Margin = new System.Windows.Forms.Padding(0);
            this.g_tabs.Name = "g_tabs";
            this.g_tabs.Padding = new System.Drawing.Point(0, 0);
            this.g_tabs.SelectedIndex = 0;
            this.g_tabs.Size = new System.Drawing.Size(906, 533);
            this.g_tabs.TabIndex = 22;
            // 
            // g_backup
            // 
            this.g_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.g_backup.Controls.Add(this.g_manualSaveBox);
            this.g_backup.Controls.Add(this.g_updateMoDButton);
            this.g_backup.Controls.Add(this.g_transferDataSaveIntLabel);
            this.g_backup.Controls.Add(this.g_changeArkSaveLocationButton);
            this.g_backup.Controls.Add(this.g_saveIntervalChooser);
            this.g_backup.Controls.Add(this.g_transferDataSaveIntervalChooser);
            this.g_backup.Controls.Add(this.g_backupLabel);
            this.g_backup.Controls.Add(this.g_manualBackupButton);
            this.g_backup.Controls.Add(this.g_maxSavesLabel);
            this.g_backup.Controls.Add(this.g_MaxMapSaves);
            this.g_backup.Controls.Add(this.g_changeBackupLocationButton);
            this.g_backup.Controls.Add(this.g_backupFileLocation);
            this.g_backup.Controls.Add(this.g_backupSaveLocationLabel);
            this.g_backup.Controls.Add(this.g_arkSaveLocationLabel);
            this.g_backup.Controls.Add(this.g_arkSaveLocationFilePathDisplay);
            this.g_backup.Controls.Add(this.g_saveIntervalLabel);
            this.g_backup.Location = new System.Drawing.Point(4, 35);
            this.g_backup.Margin = new System.Windows.Forms.Padding(0);
            this.g_backup.Name = "g_backup";
            this.g_backup.Size = new System.Drawing.Size(898, 494);
            this.g_backup.TabIndex = 0;
            this.g_backup.Text = "tabPage1";
            // 
            // g_revert
            // 
            this.g_revert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.g_revert.Controls.Add(this.g_container);
            this.g_revert.Location = new System.Drawing.Point(4, 35);
            this.g_revert.Name = "g_revert";
            this.g_revert.Padding = new System.Windows.Forms.Padding(3);
            this.g_revert.Size = new System.Drawing.Size(898, 494);
            this.g_revert.TabIndex = 1;
            this.g_revert.Text = "tabPage2";
            // 
            // g_container
            // 
            this.g_container.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.g_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g_container.IsSplitterFixed = true;
            this.g_container.Location = new System.Drawing.Point(3, 3);
            this.g_container.Name = "g_container";
            // 
            // g_container.Panel2
            // 
            this.g_container.Panel2.AutoScroll = true;
            this.g_container.Panel2.Controls.Add(this.g_backupsList);
            this.g_container.Size = new System.Drawing.Size(892, 488);
            this.g_container.SplitterDistance = 218;
            this.g_container.SplitterWidth = 1;
            this.g_container.TabIndex = 0;
            this.g_container.TabStop = false;
            // 
            // g_backupsList
            // 
            this.g_backupsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.g_backupsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.g_backupsList.FullRowSelect = true;
            this.g_backupsList.HotTracking = true;
            this.g_backupsList.Indent = 10;
            this.g_backupsList.ItemHeight = 35;
            this.g_backupsList.Location = new System.Drawing.Point(29, 65);
            this.g_backupsList.Name = "g_backupsList";
            treeNode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            treeNode1.Checked = true;
            treeNode1.Name = "Milestones";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Tag = "Milestone";
            treeNode1.Text = "MILESTONES";
            treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode2.Checked = true;
            treeNode2.Name = "ManualNode";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Tag = "Manual";
            treeNode2.Text = "MANUAL";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            treeNode3.Name = "AutomaticNode";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Tag = "Automatic";
            treeNode3.Text = "AUTOMATIC";
            this.g_backupsList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.g_backupsList.ShowLines = false;
            this.g_backupsList.ShowPlusMinus = false;
            this.g_backupsList.ShowRootLines = false;
            this.g_backupsList.Size = new System.Drawing.Size(608, 418);
            this.g_backupsList.TabIndex = 0;
            this.g_backupsList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.g_backupsList_NodeMouseClick);
            // 
            // UIProcess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.g_errorDisplay);
            this.Controls.Add(this.g_MinimizeButton);
            this.Controls.Add(this.g_reportProblemButton);
            this.Controls.Add(this.g_tabsBackgroundPanel);
            this.Controls.Add(this.g_tabs);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "UIProcess";
            this.Text = "Ark Backup Handler (Stable)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIProcess_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.g_MaxMapSaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_transferDataSaveIntervalChooser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_saveIntervalChooser)).EndInit();
            this.g_tabsBackgroundPanel.ResumeLayout(false);
            this.g_manualSaveBox.ResumeLayout(false);
            this.g_manualSaveBox.PerformLayout();
            this.g_tabs.ResumeLayout(false);
            this.g_backup.ResumeLayout(false);
            this.g_backup.PerformLayout();
            this.g_revert.ResumeLayout(false);
            this.g_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_container)).EndInit();
            this.g_container.ResumeLayout(false);
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
        private System.Windows.Forms.NumericUpDown g_saveIntervalChooser;
        private System.Windows.Forms.Button g_reportProblemButton;
        private System.Windows.Forms.TabControl g_tabs;
        private System.Windows.Forms.TabPage g_backup;
        private System.Windows.Forms.TabPage g_revert;
        private System.Windows.Forms.SplitContainer g_container;
        private System.Windows.Forms.TreeView g_backupsList;
    }
}

