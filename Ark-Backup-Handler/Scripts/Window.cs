using System;
using System.Drawing;
using System.Windows.Forms;
using ABH.Files.Backup;
using ABH.Files.MoD;
using ABH.Properties;
using ABH.Files;

namespace ABH.UI
{
    public partial class UIProcess : Form
    {
        private const string c_closeConfirmationTitle = "Are you sure?";
        private const string c_closeConfirmationDesc  = "Do you really want to quit?";

        public string _backupLocation = "Init";
        public string _saveLocation   = "Init";
        private decimal _autoSaveInterval         = 0.1M;
        private decimal _transferDataSaveInterval = 0.1M;

        private int _mapSaveNumber;
        private int _maxMapSaves = 30;
        private int _transferSaveNumber;

        private RevertController _revert;
        
        public UIProcess()
        {
            InitializeComponent();
            LoadSettings();
            
            g_manualSaveBox.BringToFront();
            g_mainTimerLoop.Start();

#if DEBUG
            Text = $"Ark Backup Handler v{VersionHandler.CurrentVersion} (Dev)";
#else
            Text = $"Ark Backup Handler v{VersionHandler.CurrentVersion} (Stable)";
#endif

            _revert = new RevertController();
        }

        /// <summary>
        /// Loads Settings from properties but also updates form controls to match the loaded values
        /// </summary>
        private void LoadSettings ()
        {
            // Transfer Data Save Updates
            _transferDataSaveInterval = Settings.Default.transferDataSaveInterval <= 0 ? 0.1M : Settings.Default.transferDataSaveInterval;
            g_transferDataSaveIntervalChooser.Value = _transferDataSaveInterval;
            g_transferDataSaveTimer.Interval = (int)(_transferDataSaveInterval * 60000);
            g_transferDataSaveTimer.Start();

            // Auto Save Relevant Updates
            _autoSaveInterval = Settings.Default.autoSaveInterval;
            _autoSaveInterval = _autoSaveInterval <= 0 ? 0.1M : _autoSaveInterval;
            g_saveIntervalChooser.Value = _autoSaveInterval;
            g_saveTimer.Interval = (int)(_autoSaveInterval * 60000);
            g_saveTimer.Start();

            // Max Map Save Relevant Updates
            _maxMapSaves = Settings.Default.maxSaves;
            g_MaxMapSaves.Value = _maxMapSaves;

            // Save Numbers
            _mapSaveNumber = Settings.Default.lastAutoSave;
            _transferSaveNumber = Settings.Default.lastTransferAuto;

            // Save Location Relevant Updates
            g_arkSaveLocationDialog.SelectedPath = Properties.Settings.Default.saveLocation;
            g_arkSaveLocationFilePathDisplay.Text = g_arkSaveLocationDialog.SelectedPath;
            _saveLocation = g_arkSaveLocationFilePathDisplay.Text;

            // Backup Location Relevant Updates
            g_backupLocationDialog.SelectedPath = Properties.Settings.Default.backupLocation;
            g_backupFileLocation.Text = g_backupLocationDialog.SelectedPath;
            _backupLocation = g_backupFileLocation.Text;
        }

        /// <summary>
        /// Manually set settings, used for unit tests
        /// </summary>
        /// <param name="backupLocation"> Path to desired backup location </param>
        /// <param name="saveLocation"> Path to Ark: Survival Evolved server save location </param>
        public void SetSettings(string backupLocation, string saveLocation)
        {
            Settings.Default.backupLocation = backupLocation;
            Settings.Default.saveLocation   = saveLocation;
        }

        /// <summary>
        /// Sets the text of the error text
        /// </summary>
        /// <param name="text"> The text to set the error text to </param>
        public void SetErrorText(string text) => g_errorDisplay.Text = text;

        /// <summary>
        /// Sets the color of the error text
        /// </summary>
        /// <param name="color"> The color to set the error text to </param>
        public void SetErrorColor(Color color) => g_errorDisplay.ForeColor = color;

        /// <summary>
        /// Ensures GC while minimized
        /// </summary>
        private void g_garbageCollectionTimer_Tick(object sender, EventArgs e) => GC.Collect();

        /// <summary>
        /// Runs every few seconds for misc. operations
        /// </summary>
        private void g_mainTimerLoopRun(object sender, EventArgs e)
        {
            // Check if the user has selected a new backup/save path and change accordingly
            if (g_backupLocationDialog.SelectedPath != _backupLocation)
            {
                _backupLocation = g_backupLocationDialog.SelectedPath;
                Properties.Settings.Default.backupLocation = _backupLocation;
                g_backupFileLocation.Text = _backupLocation;
                Properties.Settings.Default.Save();
            }
            if (g_arkSaveLocationDialog.SelectedPath != _saveLocation)
            {
                _saveLocation = g_arkSaveLocationDialog.SelectedPath;
                Properties.Settings.Default.saveLocation = _saveLocation;
                g_arkSaveLocationFilePathDisplay.Text = _saveLocation;
                Properties.Settings.Default.Save();
            }
        }

        public void g_transferDataSaveTimer_Tick(object sender, EventArgs e) => BackupManager.BackupTransferData(_transferSaveNumber);

        public void g_saveTimer_Tick(object sender, EventArgs e)
        {
            if (BackupManager.BackupMapAndConfigFiles(true, false, _mapSaveNumber.ToString())) _mapSaveNumber++;

            Properties.Settings.Default.lastAutoSave = _mapSaveNumber;
            Properties.Settings.Default.lastTransferAuto = _transferSaveNumber;

            if (_mapSaveNumber >= _maxMapSaves) _mapSaveNumber = 0;
        }

        /// <summary>
        /// Re-opens the window from the system tray
        /// </summary>
        private void OpenFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
            g_TrayIcon.Visible = false;
        }

        /// <summary>
        /// Minimizes the window to the system tray
        /// </summary>
        private void MinimizeToTray()
        {
            Hide();
            WindowState = FormWindowState.Minimized;
            g_TrayIcon.Visible = true;

            GC.Collect();
        }

        /// <summary>
        /// Prompt the user if they really want to exit to prevent accidental shutdowns of the backup manager
        /// </summary>
        private void UIProcess_Closing(object Sender, FormClosingEventArgs Event)
        {
            // Store what save we are on so we can pickup where we've left off
            Settings.Default.lastAutoSave     = _mapSaveNumber;
            Settings.Default.lastTransferAuto = _transferSaveNumber;

#if DEBUG
            return; // Debugging quality of life
#endif

            DialogResult _result = MessageBox.Show(c_closeConfirmationDesc, 
                c_closeConfirmationTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (_result == DialogResult.Yes)
            {
                Settings.Default.Save();
                g_mainTimerLoop.Dispose();
                g_saveTimer.Dispose();
                GC.Collect();
            }
            else Event.Cancel = true;
        }

        /// <summary>
        /// Update tooltip so it's accurate when the error display is hovered over
        /// </summary>
        private void g_errorDisplay_TextChanged(object sender, EventArgs e) => g_mainToolTip.SetToolTip(g_errorDisplay, g_errorDisplay.Text);
    }
}
