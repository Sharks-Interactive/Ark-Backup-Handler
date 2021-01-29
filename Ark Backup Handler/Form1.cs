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
#endregion

namespace Ark_Backup_Handler
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
        #endregion

        #endregion

        #region Initialization Functions

        public UIProcess()
        {
            //Win Forms init
            InitializeComponent();

            #region Variable Initialization

            #endregion

            #region Apperance
            saveInterval.BringToFront();
            manualSaveBox.BringToFront();
            #endregion

            #region Logical Initialization
            LoadSettings();
            mainTimerLoop.Start();
            UpdateMessegeOfTheDay();
            #endregion
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
            //Find out how many autosave files their already are
            Directory.CreateDirectory(backupLocation + @"\Automatic Saves\");
            string[] autoSaves = Directory.GetFiles(backupLocation + @"\Automatic Saves\");
            saveNumber = autoSaves.Count();

            Directory.CreateDirectory(backupLocation + @"\Automatic Saves\[TRANSFERDATA]\");
            string[] saves = Directory.GetFiles(backupLocation + @"\Automatic Saves\[TRANSFERDATA]\");
            transferSaveNumber = saves.Count();

            Debug.WriteLine(transferSaveNumber + " " + saveNumber);
        }

        #endregion

        #region Main Loops

        //When the autoSaveTimer ticks
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            BackupFiles(true);
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
            BackupTransferData();
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
            BackupFiles(false);
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
            }

            int line = 0;

            for (line = 0; line < ini.Count(); ++line)
                if (ini[line].Contains("[MessageOfTheDay]"))
                    break;

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
        public string GetCurrentTime (bool appendZeroAKAClean)
        {
            tempTime = " @";
            if (appendZeroAKAClean)
            {
                if (DateTime.Now.Hour >= 10)
                    tempTime += DateTime.Now.Hour.ToString();
                else
                    tempTime += "0" + DateTime.Now.Hour.ToString();

                if (DateTime.Now.Minute <= 9)
                    tempTime += "0" + DateTime.Now.Minute.ToString();
                else
                    tempTime += DateTime.Now.Minute.ToString();
            }
            else
            {
                tempTime += DateTime.Now.Hour.ToString() + "_";
                if (DateTime.Now.Minute <= 9)
                    tempTime += "0" + DateTime.Now.Minute.ToString() + "_";
                else
                    tempTime += DateTime.Now.Minute.ToString() + "_";

                if (DateTime.Now.Millisecond <= 9)
                    tempTime += "0" + DateTime.Now.Millisecond.ToString();
                else
                    tempTime += DateTime.Now.Millisecond.ToString();
            }

            return tempTime;
        }
        #endregion

        #region File Handling

        private void BackupTransferData ()
        {
            //Check if the directory exists
            if (!Directory.Exists(backupLocation))
            {
                errorDisplay.ForeColor = Color.Red;
                errorDisplay.Text = "Error: Backup Location directory does not exist or other read error! Please validate file path.";
                return;
            }

            string Path = @"\Automatic Saves\[TRANSFERDATA]\" + "(Save " + transferSaveNumber + ")";
            Directory.CreateDirectory(backupLocation + Path);

            errorDisplay.ForeColor = Color.White;
            errorDisplay.Text = "Info: Transfer data copied succesfully! (Automatic) " + GetCurrentTime(false);
            transferSaveNumber++;

            Copy(saveLocation + @"\clusters", backupLocation + Path + @"\");

            if (transferSaveNumber >= maxSaves)
                transferSaveNumber = 0;
        }

        private void BackupFiles (bool automatic)
        {
            //Check if the directory exists
            if (!Directory.Exists(backupLocation))
            {
                errorDisplay.ForeColor = Color.Red;
                errorDisplay.Text = "Error: Backup Location directory does not exist or other read error! Please validate file path.";
                return;
            }

            //Choose which folders to copy into
            if (automatic)
                autoManual = @"\Automatic Saves\";
            else
                autoManual = @"\Manual Saves\";
            if (automatic) saveNumber++;

            Directory.CreateDirectory(backupLocation + autoManual);
            if (automatic)
                Time = "(Save " + saveNumber + ")";
            //Time = DateTime.Now.ToString("yyyy-MM-dd") + GetCurrentTime(false) + " (Save " + saveNumber + ")";
            else
            {
                if (milestoneCheckbox.Checked)
                    Time = @"\[MILESTONES]\" + backupName.Text + " " + DateTime.Now.ToString("yyyy-MM-dd") + GetCurrentTime(false);
                else
                    Time = backupName.Text + " " + DateTime.Now.ToString("yyyy-MM-dd") + GetCurrentTime(false);
            }

            Directory.CreateDirectory(backupLocation + autoManual + Time + @"\");
            errorDisplay.ForeColor = Color.White;
            errorDisplay.Text = "Info: Items copied succesfully! Manual: " + !automatic + GetCurrentTime(false);
            Copy(saveLocation, backupLocation + autoManual + Time + @"\");

            if (saveNumber >= maxSaves)
                saveNumber = 0;
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);
            Debug.WriteLine(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (Directory.Exists(target.FullName))
                Directory.Delete(target.FullName, true);

            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                try
                {
                    fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
                }
                catch (Exception E)
                {
                    Debug.WriteLine("Error copying files " + E.Message);
                }
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        #endregion

        #region Application Events

        private void UIProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Unregister event handlers and save settings
            Properties.Settings.Default.Save();
            mainTimerLoop.Dispose();
            SaveTimer.Dispose();
            GC.Collect();
        }

        #endregion

        #region Updating UI on events

        private void errorDisplay_TextChanged(object sender, EventArgs e)
        {
            mainToolTip.SetToolTip(errorDisplay, errorDisplay.Text);
        }

        #endregion

        #endregion
    }
}
