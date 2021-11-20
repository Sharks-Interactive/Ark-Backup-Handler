using NUnit.Framework;
using ABH.UI;
using System.IO;

namespace ABH.Tests
{
    public class Tests
    {
        private const string c_transferBackupFolder = @"[TRANSFERDATA]\";
        private const string c_milestoneBackupFolder = @"[MILESTONES]\";

        private const string c_clusterDataFolder = @"\clusters";

        private const string c_manualBackupFolder = @"\Manual Saves\";
        private const string c_automaticBackupFolder = @"\Automatic Saves\";

        private UIProcess UI;

        /// <summary>
        /// TODO: Make a fixture that creates empty files and directories @locauserappdata for the backup manager to then copy files from
        /// This way it will work on hosted runners as well (EG, as part of GitHub CI/CD)
        /// </summary>

        [SetUp]
        public void Setup() => UI = new UIProcess();

        [Test]
        public void BackupTest()
        {
            UI.g_saveTimer_Tick(null, null);

            Assert.IsTrue(Directory.GetFiles(UI._backupLocation + c_automaticBackupFolder).Length > 0);
        }

        [Test]
        public void BackupTransferTest()
        {
            UI.g_transferDataSaveTimer_Tick(null, null);

            Assert.IsTrue(Directory.GetFiles(UI._backupLocation + c_automaticBackupFolder + c_transferBackupFolder).Length > 0);
        }

        
    }
}