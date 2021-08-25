using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ABH.Files;
using ABH.Utility;

namespace ABH.Files.Backup
{
    public static class BackupManager
    {
        public static void BackupTransferData()
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

            Properties.Settings.Default.lastAutoSave = saveNumber;
            Properties.Settings.Default.lastTransferAuto = transferSaveNumber;

            Copy(saveLocation + @"\clusters", backupLocation + Path + @"\");

            if (transferSaveNumber >= maxSaves)
                transferSaveNumber = 0;
        }

        public static bool BackupMapAndConfigFiles(bool automatic)
        {
            //Check if the directory exists
            if (!Directory.Exists(backupLocation))
            {
                return false;
            }

            //Choose which folders to copy into
            string _autoManual;
            if (automatic)
                _autoManual = @"\Automatic Saves\";
            else
                _autoManual = @"\Manual Saves\";

            Directory.CreateDirectory(backupLocation + _autoManual);
            
            if (automatic)
                Time = "(Save " + saveNumber + ")";
            else
            {
                if (milestoneCheckbox.Checked)
                    Time = @"\[MILESTONES]\" + backupName.Text + " " + DateTime.Now.ToString("yyyy-MM-dd") + GetCurrentTime(false);
                else
                    Time = backupName.Text + " " + DateTime.Now.ToString("yyyy-MM-dd") + TimeHelper.ExactTimeString;
            }

            Directory.CreateDirectory(backupLocation + _autoManual + Time + @"\");
            return FileHandler.Copy(saveLocation, backupLocation + _autoManual + Time + @"\");
        }
    }
}
