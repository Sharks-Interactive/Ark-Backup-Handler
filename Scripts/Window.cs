#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABH.Files.FileHandler;
using ABH.Files.Backup;
using ABH.Logging;
#endregion

namespace ABH.UI
{
    public partial class UIProcess : Form
    {
        #region Variables

        #region Data
        public string backupLocation = "Init";
        public string saveLocation = "Init";
        public decimal autoSaveInterval = 0.1M;
        public decimal transferDataSaveInterval = 0.1M;
        #endregion

        #region Cache
        string Time;
        string autoManual;
        string tempTime;
        int saveNumber;
        int maxSaves = 30;
        int transferSaveNumber;
        bool isDebug;
        #endregion

        #endregion

        #region Initialization Functions

        public UIProcess()
        {
            //Win Forms init
            InitializeComponent();

#if DEBUG
            isDebug = true;
#endif

            saveInterval.BringToFront();
            manualSaveBox.BringToFront();

            LoadSettings();
            mainTimerLoop.Start();
            UpdateMessegeOfTheDay();
        }

        private void LoadSettings ()
        {
            transferDataSaveInterval = Properties.Settings.Default.transferDataSaveInterval;
            if (transferDataSaveInterval <= 0)
                transferDataSaveInterval = 0.1M;
            transferDataSaveIntervalChooser.Value = transferDataSaveInterval;
            transferDataSaveTimer.Interval = (int)(transferDataSaveInterval * 60000);
            transferDataSaveTimer.Start();

            autoSaveInterval = Properties.Settings.Default.autoSaveInterval;
            if (autoSaveInterval <= 0)
                autoSaveInterval = 0.1M;
            saveInterval.Value = autoSaveInterval;
            numDisplay.Text = autoSaveInterval.ToString();

            maxSaves = Properties.Settings.Default.maxSaves;
            maxSavesSetter.Value = maxSaves;

            saveNumber = Properties.Settings.Default.lastAutoSave;
            transferSaveNumber = Properties.Settings.Default.lastTransferAuto;

            //Setting saveTimer to autosave interval
            SaveTimer.Interval = (int)(autoSaveInterval * 60000);
            SaveTimer.Start();

            arkSaveLocationDialog.SelectedPath = Properties.Settings.Default.saveLocation;
            arkSaveLocationFilePathDisplay.Text = arkSaveLocationDialog.SelectedPath;
            saveLocation = arkSaveLocationFilePathDisplay.Text;

            saveLocationDialog.SelectedPath = Properties.Settings.Default.backupLocation;
            backupFileLocation.Text = saveLocationDialog.SelectedPath;
            backupLocation = backupFileLocation.Text;

            LoadFiles();
        }

        public void LoadFiles ()
        {
            Directory.CreateDirectory(backupLocation + @"\Automatic Saves\[TRANSFERDATA]\");
            string[] saves = Directory.GetDirectories(backupLocation + @"\Automatic Saves\[TRANSFERDATA]\");
            transferSaveNumber = saves.Count();

            //Find out how many autosave files their already are
            Directory.CreateDirectory(backupLocation + @"\Automatic Saves\");
            string[] autoSaves = Directory.GetDirectories(backupLocation + @"\Automatic Saves\");
            saveNumber = autoSaves.Count() - 1;

            Debug.WriteLine(transferSaveNumber + " " + saveNumber);
        }

        #endregion

        #region Main Loops

        //When the autoSaveTimer ticks
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            if (BackupManager.BackupMapAndConfigFiles(true, false, saveNumber.ToString()))
                saveNumber++;

            Properties.Settings.Default.lastAutoSave = saveNumber;
            Properties.Settings.Default.lastTransferAuto = transferSaveNumber;

            
            if (saveNumber >= maxSaves)
                saveNumber = 0;
        }

        //GC
        private void garbageCollectionTimer_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        //When the logic or main loop timer ticks
        private void mainTimerLoopRun(object sender, EventArgs e)
        {
            if (saveLocationDialog.SelectedPath != backupLocation)
            {
                backupLocation = saveLocationDialog.SelectedPath;
                Properties.Settings.Default.backupLocation = backupLocation;
                backupFileLocation.Text = backupLocation;
                Properties.Settings.Default.Save();
            }
            //Else give warning and set a bool to not give error again

            if (arkSaveLocationDialog.SelectedPath != saveLocation)
            {
                saveLocation = arkSaveLocationDialog.SelectedPath;
                Properties.Settings.Default.saveLocation = saveLocation;
                arkSaveLocationFilePathDisplay.Text = saveLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void transferDataSaveTimer_Tick(object sender, EventArgs e)
        {
            BackupManager.BackupTransferData(transferSaveNumber);
        }

        #endregion

        #region Button Presses

        #region FileLocationChangeButtons
        private void changeBackupLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            saveLocationDialog.ShowDialog();
        }

        private void changeArkSaveLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            arkSaveLocationDialog.ShowDialog();
        }
        #endregion

        private void transferDataSaveIntervalChooser_ValueChanged(object sender, EventArgs e)
        {
            transferDataSaveTimer.Stop();
            transferDataSaveTimer.Interval = (int)(transferDataSaveIntervalChooser.Value * 60000);
            transferDataSaveInterval = transferDataSaveIntervalChooser.Value;
            Properties.Settings.Default.transferDataSaveInterval = transferDataSaveInterval;
            transferDataSaveTimer.Start();
        }

        //When the autosaveinterval chooser is changed
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveTimer.Stop();
            SaveTimer.Interval = (int)(saveInterval.Value * 60000);
            numDisplay.Text = saveInterval.Value.ToString();
            autoSaveInterval = saveInterval.Value;
            Properties.Settings.Default.autoSaveInterval = autoSaveInterval;
            SaveTimer.Start();
        }

        private void updateMoDButton_MouseClick(object sender, MouseEventArgs e)
        {
            errorDisplay.ForeColor = Color.White;
            errorDisplay.Text = "Info: Beginning MoD update.";
            UpdateMessegeOfTheDay();
        }

        private void errorDisplay_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.StringFormat, errorDisplay.Text);
            errorDisplay.Text = "No errors to display.";
        }

        private void manualBackupLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            manualSaveBox.Visible = !manualSaveBox.Visible;
        }

        private void minimizeButton_MouseClick(object sender, MouseEventArgs e)
        {
            minimizeToTray();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Open();
        }

        private void submitButton_MouseClick(object sender, MouseEventArgs e)
        {
            BackupManager.BackupMapAndConfigFiles(false, milestoneCheckbox.Checked, backupName.Text);
            manualSaveBox.Visible = false;
            milestoneCheckbox.Checked = false;
            backupName.ResetText();
        }

        private void maxSavesSetter_ValueChanged(object sender, EventArgs e)
        {
            maxSaves = (int)maxSavesSetter.Value;
            Properties.Settings.Default.maxSaves = maxSaves;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region Functions

        #region Misc Processors

        public void UpdateMessegeOfTheDay ()
        {
            string[] ini = new string[1];
            try
            {
                ini = File.ReadAllLines(saveLocation + @"\UWPConfig\UWP\GameUserSettings.ini");
            }
            catch (Exception E)
            {
                errorDisplay.ForeColor = Color.Red;
                errorDisplay.Text = "Error: Problem while reading GameUserSettings.ini, problem: " + E.Message;
                return;
            }

            int line = 0;
            
            //If the ini is less than 3 lines then there was probably a read error
            if (ini.Count() > 3)
                for (line = 0; line < ini.Count(); ++line)
                    if (ini[line].Contains("[MessageOfTheDay]"))
                        break;

            if (ini.Count() < 4)
            {
                Logger.Log("Unspecified error reading ini.", Logger.ErrorLevel.Error);
                return;
            }

            string UnstableOrStable;
            if (DateTime.Now.Day - File.GetLastWriteTime(saveLocation + @"\UWPConfig\UWP\Game.ini").Day < 5)
                UnstableOrStable = "Unstable";
            else
                UnstableOrStable = "Stable";

            string date = DateTime.Now.ToString("D");
            Debug.WriteLine(UnstableOrStable + date);
            ini[line + 1] = $"Message=Welcome to the Toasty Bros Server Network. Today is {date}. Server network: {UnstableOrStable}. Toast quote of the year: \"Toast!\". Save backups occur every {autoSaveInterval} minutes and transfer data backs-up every {transferDataSaveInterval} minutes. Last backup is {DateTime.Now.ToString("dd/M")}. Stay Toasty!";
            try { File.Delete(saveLocation + @"\UWPConfig\UWP\GameUserSettings.ini"); } catch (Exception E) { errorDisplay.ForeColor = Color.Red; errorDisplay.Text = "Error: Problem while deleting old GameUserSettings.ini problem: " + E.Message; }
            using (FileStream stream = new FileStream(saveLocation + @"\UWPConfig\UWP\GameUserSettings.ini", FileMode.OpenOrCreate)) {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    for (int i = 0; i < ini.Count(); i++)
                    {
                        try
                        {
                            writer.WriteLine(ini[i]);
                        }
                        catch (Exception E)
                        {
                            errorDisplay.ForeColor = Color.Red;
                            errorDisplay.Text = "Errors: Problem while writing to GameUserSettings.ini file. Problem: " + E.Message;
                        }
                    }
                }
            }

            errorDisplay.Text += " MoD Update Complete.";
        }

        #endregion

        #region Form Visibility Control

        private void Open()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void minimizeToTray()
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.Visible = true;
            GC.Collect();
        }

        #endregion

        #region Utility
        
        #endregion

        #region Application Events

        private void UIProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.lastAutoSave = saveNumber;
            Properties.Settings.Default.lastTransferAuto = transferSaveNumber;
            Properties.Settings.Default.Save();
            GC.Collect();

            //Unregister event handlers and save settings
            if (isDebug)
            {
                Properties.Settings.Default.Save();
                mainTimerLoop.Dispose();
                SaveTimer.Dispose();
                GC.Collect();
                return;
            }

            var closeMsg = MessageBox.Show("Do you really want to quit?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (closeMsg == DialogResult.Yes)
            {
                Properties.Settings.Default.Save();
                mainTimerLoop.Dispose();
                SaveTimer.Dispose();
                GC.Collect();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Updating UI on events

        private void errorDisplay_TextChanged(object sender, EventArgs e)
        {
            mainToolTip.SetToolTip(errorDisplay, errorDisplay.Text);
        }

        #endregion

        #endregion

        private void UIProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
