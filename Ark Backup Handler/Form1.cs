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

namespace Ark_Backup_Handler
{
    public partial class UIProcess : Form
    {
        public string backupLocation = "Init";
        public string saveLocation = "Init";

        public UIProcess()
        {
            InitializeComponent();
            SaveTimer.Start();
            timer1.Start();
            saveInterval.BringToFront();
            LoadSettings();
        }

        private void LoadSettings ()
        {
            arkSaveLocationDialog.SelectedPath = Properties.Settings.Default.saveLocation;
            arkSaveLocationFilePathDisplay.Text = arkSaveLocationDialog.SelectedPath;
            saveLocation = arkSaveLocationFilePathDisplay.Text;

            saveLocationDialog.SelectedPath = Properties.Settings.Default.backupLocation;
            backupFileLocation.Text = saveLocationDialog.SelectedPath;
            backupLocation = backupFileLocation.Text;
        }

        private void changeBackupLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            saveLocationDialog.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saveLocationDialog.SelectedPath != backupLocation)
            {
                backupLocation = saveLocationDialog.SelectedPath;
                Properties.Settings.Default.backupLocation = backupLocation;
                backupFileLocation.Text = backupLocation;
                Properties.Settings.Default.Save();
            }

            if (arkSaveLocationDialog.SelectedPath != saveLocation)
            {
                saveLocation = arkSaveLocationDialog.SelectedPath;
                Properties.Settings.Default.saveLocation = saveLocation;
                arkSaveLocationFilePathDisplay.Text = saveLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void changeArkSaveLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            arkSaveLocationDialog.ShowDialog();
        }

        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            BackupFiles(true);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SaveTimer.Stop();
            SaveTimer.Interval = (int)(saveInterval.Value * 1000);
            numDisplay.Text = saveInterval.Value.ToString();
            SaveTimer.Start();
        }

        private void manualBackupLocationButton_MouseClick(object sender, MouseEventArgs e)
        {
            BackupFiles(false);
        }

        private void BackupFiles (bool automatic)
        {
            if (automatic)
            {
                if (!Directory.Exists(backupLocation + @"\Automatic Saves"))
                {
                    Directory.CreateDirectory(backupLocation + @"\Automatic Saves");
                }
                string Time = DateTime.Now.ToString();
                Time = Time.Replace("\\\"", "");
                Directory.CreateDirectory(backupLocation + @"\Automatic Saves\" + Time);

                File.Copy(saveLocation, backupLocation + @"\Automatic Saves\" + Time, true);
            }
            else
            {
                if (!Directory.Exists(backupLocation + @"\Manual Saves"))
                {
                    Directory.CreateDirectory(backupLocation + @"\Manual Saves");
                }
                Directory.CreateDirectory(backupLocation + @"\Manual Saves\" + DateTime.Now.ToString());

                //File.Copy(sourceFile, destFile, true);
            }
        }
    }
}
