#region Imports
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ABH.Files.Backup;
using ABH.Files.MoD;
using ABH.Properties;
#endregion

namespace ABH.UI
{
    public partial class UIProcess : Form
    {
        #region Variables

        private const string c_closeConfirmationTitle = "Are you sure?";
        private const string c_closeConfirmationDesc = "Do you really want to quit?";

        #region Data
        public string backupLocation = "Init";
        public string saveLocation = "Init";
        public decimal autoSaveInterval = 0.1M;
        public decimal transferDataSaveInterval = 0.1M;
        #endregion

        #region Cache
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
            ModManager.UpdateMessegeOfTheDay();
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

        #region Functions

        #region Form Visibility Control

        private void OpenFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            g_TrayIcon.Visible = false;
        }

        private void MinimizeToTray()
        {
            WindowState = FormWindowState.Minimized;
            Hide();
            g_TrayIcon.Visible = true;
            GC.Collect();
        }

        #endregion

        private void UIProcess_FormClosing(object Sender, FormClosingEventArgs Event)
        {
            Settings.Default.lastAutoSave = saveNumber;
            Settings.Default.lastTransferAuto = transferSaveNumber;

            if (isDebug) return;

            DialogResult _result = MessageBox.Show(c_closeConfirmationDesc, 
                c_closeConfirmationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (_result == DialogResult.Yes)
            {
                Settings.Default.Save();
                mainTimerLoop.Dispose();
                SaveTimer.Dispose();
                GC.Collect();
            }
            else
                Event.Cancel = true;
        }

        #region Updating UI on events

        private void errorDisplay_TextChanged(object sender, EventArgs e)
        {
            mainToolTip.SetToolTip(errorDisplay, errorDisplay.Text);
        }

        #endregion

        #endregion
    }
}
