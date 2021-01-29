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
        #endregion

        #region Cache
        string fileName;
        string destFile;
        string path;
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
            #endregion

            #region Logical Initialization
            LoadSettings();
            mainTimerLoop.Start();
            UpdateMessegeOfTheDay();
            #endregion
        }

        private void LoadSettings ()
        {
            autoSaveInterval = Properties.Settings.Default.autoSaveInterval;
            if (autoSaveInterval <= 0)
                autoSaveInterval = 0.1M;
            saveInterval.Value = autoSaveInterval;
            numDisplay.Text = autoSaveInterval.ToString();
                
            //Setting saveTimer to autosave interval
            SaveTimer.Interval = (int)(autoSaveInterval * 1000);
            SaveTimer.Start();

            arkSaveLocationDialog.SelectedPath = Properties.Settings.Default.saveLocation;
            arkSaveLocationFilePathDisplay.Text = arkSaveLocationDialog.SelectedPath;
            saveLocation = arkSaveLocationFilePathDisplay.Text;

            saveLocationDialog.SelectedPath = Properties.Settings.Default.backupLocation;
            backupFileLocation.Text = saveLocationDialog.SelectedPath;
            backupLocation = backupFileLocation.Text;
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

        //When the autosaveinterval chooser is changed
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveTimer.Stop();
            SaveTimer.Interval = (int)(saveInterval.Value * 1000);
            numDisplay.Text = saveInterval.Value.ToString();
            autoSaveInterval = saveInterval.Value;
            Properties.Settings.Default.autoSaveInterval = autoSaveInterval;
            SaveTimer.Start();
        }

        private void manualBackupLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            BackupFiles(false);
        }

        #endregion

        #region Functions

        #region Misc Processors

        public void UpdateMessegeOfTheDay ()
        {
            string[] ini = new string[1];
            ini = File.ReadAllLines(saveLocation + @"\UWPConfig\UWP\GameUserSettings.ini");
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
            ini[line + 1] = $"Message=Welcome to the Toasty Bros Server Network. Today is {date}. Server network: {UnstableOrStable}. Save backups occur every {autoSaveInterval} minutes and transfer data backs-up every {autoSaveInterval / 3}. Last backup is {DateTime.Now.ToString("dd/M")}";
            File.Delete(saveLocation + @"\UWPConfig\UWP\GameUserSettings.ini");

            using (StreamWriter writer = new StreamWriter(saveLocation + @"\UWPConfig\UWP\GameUserSettings.ini"))
            {
                for (int i = 0; i < ini.Count(); i++)
                    writer.WriteLine(ini[i]);
            }
        }

        #endregion

        #region File Handling

        private void BackupFiles (bool automatic)
        {
            if (!Directory.Exists(backupLocation))
            {
                errorDisplay.ForeColor = Color.Red;
                errorDisplay.Text = "Error: Backup Location directory does not exist or other read error! Please validate file path.";
                return;
            }

            if (automatic)
            {
                if (!Directory.Exists(backupLocation + @"\Automatic Saves"))
                {
                    Directory.CreateDirectory(backupLocation + @"\Automatic Saves");
                    errorDisplay.ForeColor = Color.Yellow;
                    errorDisplay.Text = "Warning: No Sharks Folders detected in dir. New folders created. No action required.";
                }

                string Time = DateTime.Now.ToString("yyyy-MM-dd");
                Directory.CreateDirectory(backupLocation + @"\Automatic Saves\" + Time);

                try
                {
                    path = backupLocation + @"\Automatic Saves\" + Time;
                    string[] files = System.IO.Directory.GetFiles(saveLocation);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(path + @"\", fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                } catch (Exception E)
                {
                    errorDisplay.ForeColor = Color.Red;
                    errorDisplay.Text = "Error: Problem occured while copying files to backup path. Error: " + E.Message;
                }
            }
            else
            {
                if (!Directory.Exists(backupLocation + @"\Manual Saves"))
                {
                    Directory.CreateDirectory(backupLocation + @"\Manual Saves");
                    errorDisplay.ForeColor = Color.Yellow;
                    errorDisplay.Text = "Warning: No Sharks Folders detected in dir. New folders created. No action required.";
                }
                
                Directory.CreateDirectory(backupLocation + @"\Manual Saves\" + DateTime.Now.ToString());

                //File.Copy(sourceFile, destFile, true);
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
