namespace Ark_Backup_Handler
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
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LogoBlock = new System.Windows.Forms.Panel();
            this.errorDisplay = new System.Windows.Forms.Label();
            this.TabBackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backupsButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backupLabel = new System.Windows.Forms.Label();
            this.backupFileLocation = new System.Windows.Forms.TextBox();
            this.changeBackupLocationButton = new System.Windows.Forms.Button();
            this.backupSaveLocationLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTimerLoop = new System.Windows.Forms.Timer(this.components);
            this.arkSaveLocationLabel = new System.Windows.Forms.Label();
            this.arkSaveLocationFilePathDisplay = new System.Windows.Forms.TextBox();
            this.changeArkSaveLocationButton = new System.Windows.Forms.Button();
            this.arkSaveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.saveInterval = new System.Windows.Forms.NumericUpDown();
            this.saveIntervalLabel = new System.Windows.Forms.Label();
            this.numDisplay = new System.Windows.Forms.TextBox();
            this.manualBackupButton = new System.Windows.Forms.Button();
            this.garbageCollectionTimer = new System.Windows.Forms.Timer(this.components);
            this.minimizeButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.manualSaveBox = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.milestoneCheckbox = new System.Windows.Forms.CheckBox();
            this.backupName = new System.Windows.Forms.TextBox();
            this.manualBackupPanelLabel = new System.Windows.Forms.Label();
            this.maxSavesLabel = new System.Windows.Forms.Label();
            this.maxSavesSetter = new System.Windows.Forms.NumericUpDown();
            this.updateMoDButton = new System.Windows.Forms.Button();
            this.transferDataSaveIntervalChooser = new System.Windows.Forms.NumericUpDown();
            this.transferDataSaveIntLabel = new System.Windows.Forms.Label();
            this.transferDataSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.revertButton = new System.Windows.Forms.Button();
            this.TabBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveInterval)).BeginInit();
            this.manualSaveBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSavesSetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDataSaveIntervalChooser)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBlock
            // 
            this.LogoBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.LogoBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoBlock.BackgroundImage")));
            this.LogoBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoBlock.Location = new System.Drawing.Point(0, 0);
            this.LogoBlock.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBlock.Name = "LogoBlock";
            this.LogoBlock.Size = new System.Drawing.Size(173, 83);
            this.LogoBlock.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.LogoBlock, "Visit us on sharksinteractive.net");
            // 
            // errorDisplay
            // 
            this.errorDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.errorDisplay.AutoSize = true;
            this.errorDisplay.ForeColor = System.Drawing.Color.Red;
            this.errorDisplay.Location = new System.Drawing.Point(10, 498);
            this.errorDisplay.Name = "errorDisplay";
            this.errorDisplay.Size = new System.Drawing.Size(189, 19);
            this.errorDisplay.TabIndex = 13;
            this.errorDisplay.Text = "No errors to display";
            this.errorDisplay.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mainToolTip.SetToolTip(this.errorDisplay, "Test");
            this.errorDisplay.TextChanged += new System.EventHandler(this.errorDisplay_TextChanged);
            this.errorDisplay.Click += new System.EventHandler(this.errorDisplay_Click);
            // 
            // TabBackgroundPanel
            // 
            this.TabBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.TabBackgroundPanel.Controls.Add(this.LogoBlock);
            this.TabBackgroundPanel.Controls.Add(this.backupsButton);
            this.TabBackgroundPanel.Controls.Add(this.revertButton);
            this.TabBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.TabBackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TabBackgroundPanel.Name = "TabBackgroundPanel";
            this.TabBackgroundPanel.Size = new System.Drawing.Size(891, 83);
            this.TabBackgroundPanel.TabIndex = 4;
            // 
            // backupsButton
            // 
            this.backupsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.backupsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backupsButton.FlatAppearance.BorderSize = 0;
            this.backupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backupsButton.ForeColor = System.Drawing.Color.White;
            this.backupsButton.Image = ((System.Drawing.Image)(resources.GetObject("backupsButton.Image")));
            this.backupsButton.Location = new System.Drawing.Point(173, 0);
            this.backupsButton.Margin = new System.Windows.Forms.Padding(0);
            this.backupsButton.Name = "backupsButton";
            this.backupsButton.Size = new System.Drawing.Size(104, 83);
            this.backupsButton.TabIndex = 1;
            this.backupsButton.Text = "Backups";
            this.backupsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backupsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.backupsButton.UseVisualStyleBackColor = false;
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupLabel.ForeColor = System.Drawing.Color.White;
            this.backupLabel.Location = new System.Drawing.Point(0, 83);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(134, 32);
            this.backupLabel.TabIndex = 8;
            this.backupLabel.Text = "Backups:";
            // 
            // backupFileLocation
            // 
            this.backupFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backupFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backupFileLocation.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupFileLocation.ForeColor = System.Drawing.Color.White;
            this.backupFileLocation.Location = new System.Drawing.Point(12, 153);
            this.backupFileLocation.Name = "backupFileLocation";
            this.backupFileLocation.ReadOnly = true;
            this.backupFileLocation.Size = new System.Drawing.Size(409, 23);
            this.backupFileLocation.TabIndex = 9;
            // 
            // changeBackupLocationButton
            // 
            this.changeBackupLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeBackupLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeBackupLocationButton.FlatAppearance.BorderSize = 15;
            this.changeBackupLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.changeBackupLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.changeBackupLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeBackupLocationButton.Location = new System.Drawing.Point(428, 153);
            this.changeBackupLocationButton.Name = "changeBackupLocationButton";
            this.changeBackupLocationButton.Size = new System.Drawing.Size(94, 29);
            this.changeBackupLocationButton.TabIndex = 10;
            this.changeBackupLocationButton.Text = "Change";
            this.changeBackupLocationButton.UseVisualStyleBackColor = false;
            this.changeBackupLocationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.changeBackupLocationButton_MouseClick);
            // 
            // backupSaveLocationLabel
            // 
            this.backupSaveLocationLabel.AutoSize = true;
            this.backupSaveLocationLabel.Location = new System.Drawing.Point(12, 127);
            this.backupSaveLocationLabel.Name = "backupSaveLocationLabel";
            this.backupSaveLocationLabel.Size = new System.Drawing.Size(189, 19);
            this.backupSaveLocationLabel.TabIndex = 11;
            this.backupSaveLocationLabel.Text = "Backup Save Location";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainTimerLoop
            // 
            this.mainTimerLoop.Interval = 500;
            this.mainTimerLoop.Tick += new System.EventHandler(this.mainTimerLoopRun);
            // 
            // arkSaveLocationLabel
            // 
            this.arkSaveLocationLabel.AutoSize = true;
            this.arkSaveLocationLabel.Location = new System.Drawing.Point(12, 198);
            this.arkSaveLocationLabel.Name = "arkSaveLocationLabel";
            this.arkSaveLocationLabel.Size = new System.Drawing.Size(162, 19);
            this.arkSaveLocationLabel.TabIndex = 11;
            this.arkSaveLocationLabel.Text = "Ark Save Location";
            // 
            // arkSaveLocationFilePathDisplay
            // 
            this.arkSaveLocationFilePathDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arkSaveLocationFilePathDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arkSaveLocationFilePathDisplay.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arkSaveLocationFilePathDisplay.ForeColor = System.Drawing.Color.White;
            this.arkSaveLocationFilePathDisplay.Location = new System.Drawing.Point(12, 224);
            this.arkSaveLocationFilePathDisplay.Name = "arkSaveLocationFilePathDisplay";
            this.arkSaveLocationFilePathDisplay.ReadOnly = true;
            this.arkSaveLocationFilePathDisplay.Size = new System.Drawing.Size(409, 23);
            this.arkSaveLocationFilePathDisplay.TabIndex = 9;
            // 
            // changeArkSaveLocationButton
            // 
            this.changeArkSaveLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeArkSaveLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeArkSaveLocationButton.FlatAppearance.BorderSize = 15;
            this.changeArkSaveLocationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.changeArkSaveLocationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.changeArkSaveLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeArkSaveLocationButton.Location = new System.Drawing.Point(427, 224);
            this.changeArkSaveLocationButton.Name = "changeArkSaveLocationButton";
            this.changeArkSaveLocationButton.Size = new System.Drawing.Size(94, 29);
            this.changeArkSaveLocationButton.TabIndex = 10;
            this.changeArkSaveLocationButton.Text = "Change";
            this.changeArkSaveLocationButton.UseVisualStyleBackColor = false;
            this.changeArkSaveLocationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.changeArkSaveLocationButton_MouseClick);
            // 
            // SaveTimer
            // 
            this.SaveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
            // 
            // saveInterval
            // 
            this.saveInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.saveInterval.Location = new System.Drawing.Point(860, 154);
            this.saveInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.saveInterval.Name = "saveInterval";
            this.saveInterval.Size = new System.Drawing.Size(19, 26);
            this.saveInterval.TabIndex = 12;
            this.saveInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.saveInterval.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // saveIntervalLabel
            // 
            this.saveIntervalLabel.AutoSize = true;
            this.saveIntervalLabel.Location = new System.Drawing.Point(543, 155);
            this.saveIntervalLabel.Name = "saveIntervalLabel";
            this.saveIntervalLabel.Size = new System.Drawing.Size(225, 19);
            this.saveIntervalLabel.TabIndex = 11;
            this.saveIntervalLabel.Text = "AutoSave interval (mins)";
            // 
            // numDisplay
            // 
            this.numDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDisplay.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDisplay.ForeColor = System.Drawing.Color.White;
            this.numDisplay.Location = new System.Drawing.Point(823, 156);
            this.numDisplay.Name = "numDisplay";
            this.numDisplay.ReadOnly = true;
            this.numDisplay.Size = new System.Drawing.Size(44, 23);
            this.numDisplay.TabIndex = 9;
            this.numDisplay.Text = "0.2";
            // 
            // manualBackupButton
            // 
            this.manualBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manualBackupButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.manualBackupButton.FlatAppearance.BorderSize = 15;
            this.manualBackupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.manualBackupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.manualBackupButton.Location = new System.Drawing.Point(543, 224);
            this.manualBackupButton.Name = "manualBackupButton";
            this.manualBackupButton.Size = new System.Drawing.Size(336, 29);
            this.manualBackupButton.TabIndex = 10;
            this.manualBackupButton.Text = "Manual Backup";
            this.manualBackupButton.UseVisualStyleBackColor = false;
            this.manualBackupButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualBackupLocationButton_MouseClick);
            // 
            // garbageCollectionTimer
            // 
            this.garbageCollectionTimer.Interval = 120000;
            this.garbageCollectionTimer.Tick += new System.EventHandler(this.garbageCollectionTimer_Tick);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.Location = new System.Drawing.Point(860, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 33);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.Text = "-";
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizeButton_MouseClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Open the backup Handler";
            this.notifyIcon1.BalloonTipTitle = "Ark Backup Handler";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Open Ark Backup Handler (Stable)";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // manualSaveBox
            // 
            this.manualSaveBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.manualSaveBox.BackColor = System.Drawing.Color.Gray;
            this.manualSaveBox.Controls.Add(this.submitButton);
            this.manualSaveBox.Controls.Add(this.milestoneCheckbox);
            this.manualSaveBox.Controls.Add(this.backupName);
            this.manualSaveBox.Controls.Add(this.manualBackupPanelLabel);
            this.manualSaveBox.Location = new System.Drawing.Point(330, 211);
            this.manualSaveBox.Name = "manualSaveBox";
            this.manualSaveBox.Size = new System.Drawing.Size(250, 125);
            this.manualSaveBox.TabIndex = 14;
            this.manualSaveBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Location = new System.Drawing.Point(69, 96);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Backup";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.submitButton_MouseClick);
            // 
            // milestoneCheckbox
            // 
            this.milestoneCheckbox.AutoSize = true;
            this.milestoneCheckbox.Location = new System.Drawing.Point(21, 64);
            this.milestoneCheckbox.Name = "milestoneCheckbox";
            this.milestoneCheckbox.Size = new System.Drawing.Size(118, 23);
            this.milestoneCheckbox.TabIndex = 2;
            this.milestoneCheckbox.Text = "Milestone?";
            this.milestoneCheckbox.UseVisualStyleBackColor = true;
            // 
            // backupName
            // 
            this.backupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backupName.Location = new System.Drawing.Point(9, 26);
            this.backupName.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.backupName.Name = "backupName";
            this.backupName.PlaceholderText = "Indy Forge built";
            this.backupName.Size = new System.Drawing.Size(227, 26);
            this.backupName.TabIndex = 1;
            // 
            // manualBackupPanelLabel
            // 
            this.manualBackupPanelLabel.AutoSize = true;
            this.manualBackupPanelLabel.Location = new System.Drawing.Point(21, 0);
            this.manualBackupPanelLabel.Name = "manualBackupPanelLabel";
            this.manualBackupPanelLabel.Size = new System.Drawing.Size(153, 19);
            this.manualBackupPanelLabel.TabIndex = 0;
            this.manualBackupPanelLabel.Text = "Name this Backup";
            // 
            // maxSavesLabel
            // 
            this.maxSavesLabel.AutoSize = true;
            this.maxSavesLabel.Location = new System.Drawing.Point(653, 275);
            this.maxSavesLabel.Name = "maxSavesLabel";
            this.maxSavesLabel.Size = new System.Drawing.Size(135, 19);
            this.maxSavesLabel.TabIndex = 15;
            this.maxSavesLabel.Text = "Max Auto Saves";
            // 
            // maxSavesSetter
            // 
            this.maxSavesSetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.maxSavesSetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxSavesSetter.ForeColor = System.Drawing.Color.White;
            this.maxSavesSetter.Location = new System.Drawing.Point(823, 274);
            this.maxSavesSetter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxSavesSetter.Name = "maxSavesSetter";
            this.maxSavesSetter.Size = new System.Drawing.Size(56, 26);
            this.maxSavesSetter.TabIndex = 16;
            this.maxSavesSetter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxSavesSetter.ValueChanged += new System.EventHandler(this.maxSavesSetter_ValueChanged);
            // 
            // updateMoDButton
            // 
            this.updateMoDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateMoDButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateMoDButton.FlatAppearance.BorderSize = 15;
            this.updateMoDButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.updateMoDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.updateMoDButton.Location = new System.Drawing.Point(695, 484);
            this.updateMoDButton.Name = "updateMoDButton";
            this.updateMoDButton.Size = new System.Drawing.Size(184, 29);
            this.updateMoDButton.TabIndex = 17;
            this.updateMoDButton.Text = "Update MoD";
            this.updateMoDButton.UseVisualStyleBackColor = false;
            this.updateMoDButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateMoDButton_MouseClick);
            // 
            // transferDataSaveIntervalChooser
            // 
            this.transferDataSaveIntervalChooser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.transferDataSaveIntervalChooser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transferDataSaveIntervalChooser.DecimalPlaces = 1;
            this.transferDataSaveIntervalChooser.ForeColor = System.Drawing.Color.White;
            this.transferDataSaveIntervalChooser.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.transferDataSaveIntervalChooser.Location = new System.Drawing.Point(823, 320);
            this.transferDataSaveIntervalChooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.transferDataSaveIntervalChooser.Name = "transferDataSaveIntervalChooser";
            this.transferDataSaveIntervalChooser.Size = new System.Drawing.Size(56, 26);
            this.transferDataSaveIntervalChooser.TabIndex = 18;
            this.transferDataSaveIntervalChooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transferDataSaveIntervalChooser.ValueChanged += new System.EventHandler(this.transferDataSaveIntervalChooser_ValueChanged);
            // 
            // transferDataSaveIntLabel
            // 
            this.transferDataSaveIntLabel.AutoSize = true;
            this.transferDataSaveIntLabel.Location = new System.Drawing.Point(510, 322);
            this.transferDataSaveIntLabel.Name = "transferDataSaveIntLabel";
            this.transferDataSaveIntLabel.Size = new System.Drawing.Size(252, 19);
            this.transferDataSaveIntLabel.TabIndex = 19;
            this.transferDataSaveIntLabel.Text = "Transfer Data Save Interval";
            // 
            // transferDataSaveTimer
            // 
            this.transferDataSaveTimer.Tick += new System.EventHandler(this.transferDataSaveTimer_Tick);
            // 
            // revertButton
            // 
            this.revertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.revertButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.revertButton.FlatAppearance.BorderSize = 0;
            this.revertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.revertButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.revertButton.ForeColor = System.Drawing.Color.White;
            this.revertButton.Image = ((System.Drawing.Image)(resources.GetObject("revertButton.Image")));
            this.revertButton.Location = new System.Drawing.Point(277, 0);
            this.revertButton.Margin = new System.Windows.Forms.Padding(0);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(104, 83);
            this.revertButton.TabIndex = 2;
            this.revertButton.Text = "Revert";
            this.revertButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.revertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.revertButton.UseVisualStyleBackColor = false;
            // 
            // UIProcess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.transferDataSaveIntLabel);
            this.Controls.Add(this.transferDataSaveIntervalChooser);
            this.Controls.Add(this.updateMoDButton);
            this.Controls.Add(this.maxSavesSetter);
            this.Controls.Add(this.maxSavesLabel);
            this.Controls.Add(this.manualSaveBox);
            this.Controls.Add(this.errorDisplay);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.manualBackupButton);
            this.Controls.Add(this.numDisplay);
            this.Controls.Add(this.saveIntervalLabel);
            this.Controls.Add(this.saveInterval);
            this.Controls.Add(this.changeArkSaveLocationButton);
            this.Controls.Add(this.arkSaveLocationFilePathDisplay);
            this.Controls.Add(this.arkSaveLocationLabel);
            this.Controls.Add(this.backupSaveLocationLabel);
            this.Controls.Add(this.changeBackupLocationButton);
            this.Controls.Add(this.backupFileLocation);
            this.Controls.Add(this.backupLabel);
            this.Controls.Add(this.TabBackgroundPanel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UIProcess";
            this.Text = "Ark Backup Handler (Stable)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UIProcess_FormClosing);
            this.TabBackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveInterval)).EndInit();
            this.manualSaveBox.ResumeLayout(false);
            this.manualSaveBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSavesSetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDataSaveIntervalChooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Panel LogoBlock;
        private System.Windows.Forms.FlowLayoutPanel TabBackgroundPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label backupLabel;
        private System.Windows.Forms.TextBox backupFileLocation;
        private System.Windows.Forms.Button changeBackupLocationButton;
        private System.Windows.Forms.Label backupSaveLocationLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog saveLocationDialog;
        private System.Windows.Forms.Timer mainTimerLoop;
        private System.Windows.Forms.Label arkSaveLocationLabel;
        private System.Windows.Forms.TextBox arkSaveLocationFilePathDisplay;
        private System.Windows.Forms.Button changeArkSaveLocationButton;
        private System.Windows.Forms.FolderBrowserDialog arkSaveLocationDialog;
        private System.Windows.Forms.Timer SaveTimer;
        private System.Windows.Forms.NumericUpDown saveInterval;
        private System.Windows.Forms.Label saveIntervalLabel;
        private System.Windows.Forms.TextBox numDisplay;
        private System.Windows.Forms.Button manualBackupButton;
        private System.Windows.Forms.Label errorDisplay;
        private System.Windows.Forms.Timer garbageCollectionTimer;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel manualSaveBox;
        private System.Windows.Forms.Label manualBackupPanelLabel;
        private System.Windows.Forms.TextBox backupName;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox milestoneCheckbox;
        private System.Windows.Forms.Label maxSavesLabel;
        private System.Windows.Forms.NumericUpDown maxSavesSetter;
        private System.Windows.Forms.Button updateMoDButton;
        private System.Windows.Forms.NumericUpDown transferDataSaveIntervalChooser;
        private System.Windows.Forms.Label transferDataSaveIntLabel;
        private System.Windows.Forms.Timer transferDataSaveTimer;
        private System.Windows.Forms.Button backupsButton;
        private System.Windows.Forms.Button revertButton;
    }
}

