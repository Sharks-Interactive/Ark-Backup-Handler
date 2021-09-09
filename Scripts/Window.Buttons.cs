using ABH.Files.Backup;
using ABH.Files.MoD;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABH.UI
{
    public partial class UIProcess
    {
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
            _transferDataSaveInterval = transferDataSaveIntervalChooser.Value;
            Properties.Settings.Default.transferDataSaveInterval = _transferDataSaveInterval;
            transferDataSaveTimer.Start();
        }

        //When the autosaveinterval chooser is changed
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveTimer.Stop();
            SaveTimer.Interval = (int)(saveInterval.Value * 60000);
            numDisplay.Text = saveInterval.Value.ToString();
            _autoSaveInterval = saveInterval.Value;
            Properties.Settings.Default.autoSaveInterval = _autoSaveInterval;
            SaveTimer.Start();
        }

        private void updateMoDButton_MouseClick(object sender, MouseEventArgs e)
        {
            errorDisplay.ForeColor = Color.White;
            errorDisplay.Text = "Info: Beginning MoD update.";
            ModManager.UpdateMessegeOfTheDay();
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

        private void g_MinimizeButton_MouseClick(object sender, MouseEventArgs e) => MinimizeToTray();

        private void g_TrayIcon_MouseClick(object Sender, MouseEventArgs Event) => OpenFromTray();

        private void submitButton_MouseClick(object sender, MouseEventArgs e)
        {
            BackupManager.BackupMapAndConfigFiles(false, milestoneCheckbox.Checked, backupName.Text);
            manualSaveBox.Visible = false;
            milestoneCheckbox.Checked = false;
            backupName.ResetText();
        }

        private void g_MaxMapSaves_ValueChanged(object Sender, EventArgs Event)
        {
            _maxMapSaves = (int)g_MaxMapSaves.Value;
            Properties.Settings.Default.maxSaves = _maxMapSaves;
            Properties.Settings.Default.Save();
        }
    }
}
