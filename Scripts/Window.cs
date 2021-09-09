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
        private const string c_closeConfirmationTitle = "Are you sure?";
        private const string c_closeConfirmationDesc = "Do you really want to quit?";

        #region Data
        private string _backupLocation = "Init";
        private string _saveLocation = "Init";
        private decimal _autoSaveInterval = 0.1M;
        private decimal _transferDataSaveInterval = 0.1M;
        #endregion

        #region Cache
        private int _mapSaveNumber;
        private int _maxMapSaves = 30;
        private int _transferSaveNumber;
        protected bool isDebug;
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
            _transferDataSaveInterval = Settings.Default.transferDataSaveInterval;
            if (_transferDataSaveInterval <= 0)
                _transferDataSaveInterval = 0.1M;
            transferDataSaveIntervalChooser.Value = _transferDataSaveInterval;
            transferDataSaveTimer.Interval = (int)(_transferDataSaveInterval * 60000);
            transferDataSaveTimer.Start();

            _autoSaveInterval = Settings.Default.autoSaveInterval;
            _autoSaveInterval = _autoSaveInterval <= 0 ? 0.1M : _autoSaveInterval;
            
            saveInterval.Value = _autoSaveInterval;
            numDisplay.Text = _autoSaveInterval.ToString();

            _maxMapSaves = Settings.Default.maxSaves;
            g_MaxMapSaves.Value = _maxMapSaves;

            _mapSaveNumber = Settings.Default.lastAutoSave;
            _transferSaveNumber = Settings.Default.lastTransferAuto;

            //Setting saveTimer to autosave interval
            SaveTimer.Interval = (int)(_autoSaveInterval * 60000);
            SaveTimer.Start();

            arkSaveLocationDialog.SelectedPath = Properties.Settings.Default.saveLocation;
            arkSaveLocationFilePathDisplay.Text = arkSaveLocationDialog.SelectedPath;
            _saveLocation = arkSaveLocationFilePathDisplay.Text;

            saveLocationDialog.SelectedPath = Properties.Settings.Default.backupLocation;
            backupFileLocation.Text = saveLocationDialog.SelectedPath;
            _backupLocation = backupFileLocation.Text;

            LoadFiles();
        }

        public void LoadFiles ()
        {
            Directory.CreateDirectory(_backupLocation + @"\Automatic Saves\[TRANSFERDATA]\");
            string[] saves = Directory.GetDirectories(_backupLocation + @"\Automatic Saves\[TRANSFERDATA]\");
            _transferSaveNumber = saves.Count();

            //Find out how many autosave files their already are
            Directory.CreateDirectory(_backupLocation + @"\Automatic Saves\");
            string[] autoSaves = Directory.GetDirectories(_backupLocation + @"\Automatic Saves\");
            _mapSaveNumber = autoSaves.Count() - 1;

            Debug.WriteLine(_transferSaveNumber + " " + _mapSaveNumber);
        }

        #endregion

        #region Main Loops

        //When the autoSaveTimer ticks
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            if (BackupManager.BackupMapAndConfigFiles(true, false, _mapSaveNumber.ToString()))
                _mapSaveNumber++;

            Properties.Settings.Default.lastAutoSave = _mapSaveNumber;
            Properties.Settings.Default.lastTransferAuto = _transferSaveNumber;

            
            if (_mapSaveNumber >= _maxMapSaves)
                _mapSaveNumber = 0;
        }

        //GC
        private void garbageCollectionTimer_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        //When the logic or main loop timer ticks
        private void mainTimerLoopRun(object sender, EventArgs e)
        {
            if (saveLocationDialog.SelectedPath != _backupLocation)
            {
                _backupLocation = saveLocationDialog.SelectedPath;
                Properties.Settings.Default.backupLocation = _backupLocation;
                backupFileLocation.Text = _backupLocation;
                Properties.Settings.Default.Save();
            }
            //Else give warning and set a bool to not give error again

            if (arkSaveLocationDialog.SelectedPath != _saveLocation)
            {
                _saveLocation = arkSaveLocationDialog.SelectedPath;
                Properties.Settings.Default.saveLocation = _saveLocation;
                arkSaveLocationFilePathDisplay.Text = _saveLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void transferDataSaveTimer_Tick(object sender, EventArgs e)
        {
            BackupManager.BackupTransferData(_transferSaveNumber);
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
            Settings.Default.lastAutoSave = _mapSaveNumber;
            Settings.Default.lastTransferAuto = _transferSaveNumber;

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
