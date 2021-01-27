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
            this.TabBackgroundPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backupLabel = new System.Windows.Forms.Label();
            this.backupFileLocation = new System.Windows.Forms.TextBox();
            this.changeBackupLocationButton = new System.Windows.Forms.Button();
            this.backupSaveLocationLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.arkSaveLocationLabel = new System.Windows.Forms.Label();
            this.arkSaveLocationFilePathDisplay = new System.Windows.Forms.TextBox();
            this.changeArkSaveLocationButton = new System.Windows.Forms.Button();
            this.arkSaveLocationDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.saveInterval = new System.Windows.Forms.NumericUpDown();
            this.saveIntervalLabel = new System.Windows.Forms.Label();
            this.numDisplay = new System.Windows.Forms.TextBox();
            this.manualBackupButton = new System.Windows.Forms.Button();
            this.TabBackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveInterval)).BeginInit();
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
            // TabBackgroundPanel
            // 
            this.TabBackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.TabBackgroundPanel.Controls.Add(this.LogoBlock);
            this.TabBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabBackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.TabBackgroundPanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TabBackgroundPanel.Name = "TabBackgroundPanel";
            this.TabBackgroundPanel.Size = new System.Drawing.Size(891, 83);
            this.TabBackgroundPanel.TabIndex = 4;
            // 
            // backupLabel
            // 
            this.backupLabel.AutoSize = true;
            this.backupLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backupLabel.ForeColor = System.Drawing.Color.White;
            this.backupLabel.Location = new System.Drawing.Point(0, 83);
            this.backupLabel.Name = "backupLabel";
            this.backupLabel.Size = new System.Drawing.Size(169, 40);
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
            this.backupFileLocation.Size = new System.Drawing.Size(409, 27);
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
            this.backupSaveLocationLabel.Size = new System.Drawing.Size(230, 23);
            this.backupSaveLocationLabel.TabIndex = 11;
            this.backupSaveLocationLabel.Text = "Backup Save Location";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // arkSaveLocationLabel
            // 
            this.arkSaveLocationLabel.AutoSize = true;
            this.arkSaveLocationLabel.Location = new System.Drawing.Point(12, 198);
            this.arkSaveLocationLabel.Name = "arkSaveLocationLabel";
            this.arkSaveLocationLabel.Size = new System.Drawing.Size(197, 23);
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
            this.arkSaveLocationFilePathDisplay.Size = new System.Drawing.Size(409, 27);
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
            this.saveInterval.Size = new System.Drawing.Size(19, 31);
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
            this.saveIntervalLabel.Location = new System.Drawing.Point(543, 156);
            this.saveIntervalLabel.Name = "saveIntervalLabel";
            this.saveIntervalLabel.Size = new System.Drawing.Size(274, 23);
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
            this.numDisplay.Size = new System.Drawing.Size(44, 27);
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
            // UIProcess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(891, 525);
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
            this.Text = "Ark Backup Handler";
            this.TabBackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.saveInterval)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label arkSaveLocationLabel;
        private System.Windows.Forms.TextBox arkSaveLocationFilePathDisplay;
        private System.Windows.Forms.Button changeArkSaveLocationButton;
        private System.Windows.Forms.FolderBrowserDialog arkSaveLocationDialog;
        private System.Windows.Forms.Timer SaveTimer;
        private System.Windows.Forms.NumericUpDown saveInterval;
        private System.Windows.Forms.Label saveIntervalLabel;
        private System.Windows.Forms.TextBox numDisplay;
        private System.Windows.Forms.Button manualBackupButton;
    }
}

