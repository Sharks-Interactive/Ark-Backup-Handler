using System;
using System.IO;
using ABH.Utility;
using ABH.Properties;

namespace ABH.Files.Backup
{
    public static class BackupManager
    {
        private const string c_transferBackupFolder  = @"[TRANSFERDATA]\";
        private const string c_milestoneBackupFolder = @"[MILESTONES]\";

        private const string c_clusterDataFolder = @"\clusters";

        private const string c_manualBackupFolder    = @"\Manual Saves\";
        private const string c_automaticBackupFolder = @"\Automatic Saves\";

        private static readonly string r_backupLocation = Settings.Default.backupLocation;
        private static readonly string r_saveLocation   = Settings.Default.saveLocation;

        /// <summary>
        /// Backs up transfer data
        /// </summary>
        /// <param name="SaveNumber"> Which save folder to backup to </param>
        /// <returns> Was the operation a success? </returns>
        public static bool BackupTransferData(int SaveNumber)
        {
            string _source = r_saveLocation + c_clusterDataFolder;
            string _target = r_backupLocation + c_automaticBackupFolder + 
                c_transferBackupFolder + "(Save " + SaveNumber + @") \";

            return FileHandler.CopyIntoFolder(_source, _target);
        }

        /// <summary>
        /// Backs up all map save data and server configs
        /// </summary>
        /// <param name="Automatic"> Is this backup being performed automatically? </param>
        /// <param name="Milestone"> If this backup is manual, is it a milestone? </param>
        /// <param name="Data"> Additional information, if this is automatic supply
        /// the save number here, if it's manual supply the backup name here. </param>
        /// <returns> Whether or not the operation concluded successfully </returns>
        public static bool BackupMapAndConfigFiles(bool Automatic, bool Milestone, string Data = "")
        {
            string _parentFolder = Automatic ? c_automaticBackupFolder : c_manualBackupFolder;
            _parentFolder = Milestone ? _parentFolder + c_milestoneBackupFolder : _parentFolder;
            Directory.CreateDirectory(r_backupLocation + _parentFolder);

            string _folder = Automatic ? "(Save " + Data + ")" : Data + " " + DateTime.Now.ToString("yyyy-MM-dd") + TimeHelper.ExactTimeString;
            string _target = r_backupLocation + _parentFolder + _folder + @"\";

            return FileHandler.CopyIntoFolder(r_saveLocation, _target);
        }
    }
}
