using System;
using System.Collections.Generic;
using System.IO;
using static ABH.Files.Backup.Directories;
using ABH.Files.Backup;
using System.Windows.Forms;
using ABH.Utility;

namespace ABH.Files
{
    public class RevertController
    {
        public enum DataType
        {
            MapData = 0,
            TransferData = 0,
            ConfigData = 0
        }

        public class Map
        {
            public const string Island = "TheIsland";
            public const string Center = "TheCenter";
            public const string Scorched = "ScorchedEarth_P";
            public const string Ragnarok = "Ragnarok";
            public const string Aberration = "Aberration_P";
            public const string Extinction = "Extinction";
            public const string Valguero = "Valguero_P";
            public const string GenesisOne = "Genesis";
            public const string Crystal = "CrystalIsles";
            public const string GenesisTwo = "Gen2";
            public const string LostIsland = "LostIsland";
        }

        public enum MapType
        {
            Island     = 0,
            Center     = 1,
            Scorched   = 2,
            Ragnarok   = 3,
            Aberration = 4,
            Extinction = 5,
            Valguero   = 6,
            GenesisOne = 7,
            Crystal    = 8,
            GenesisTwo = 9,
            LostIsland = 10,
        }

        public string[] MapFolders = new string[11] { "TheIsland", "TheCenter", "ScorchedEarth_P", "Ragnarok", "Aberration_P", "Extinction", "Valguero_P", "Genesis", "CrystalIsles", "Gen2", "LostIsland" };

        /// <summary>
        /// Defention for a Backup in memory
        /// </summary>
        public struct Backup
        {
            /// <summary>
            /// What Data Types does this backup contain?
            /// </summary>
            public List<DataType> Data;

            /// <summary>
            /// What maps, if any, this backup contains
            /// </summary>
            public List<MapType> Maps;

            /// <summary>
            /// Is this backup automatic?
            /// </summary>
            public bool Automatic;

            /// <summary>
            /// Is this backup a milestone?
            /// </summary>
            public bool Milestone;

            /// <summary>
            /// What's the name/folder name of this backup
            /// </summary>
            public string Name;

            /// <summary>
            /// When was this backup created
            /// </summary>
            public DateTime DateCreated;

            /// <summary>
            /// The full path to this backup
            /// </summary>
            public string Path;

            /// <summary>
            /// The name of this backups folder
            /// </summary>
            public string FolderName;

            /// <summary>
            /// The unique identifier for this backup
            /// </summary>
            public Guid Id;
        }

        private List<Backup> _manualBackups = new List<Backup>();
        private List<Backup> _automaticBackups = new List<Backup>();
        private List<Backup> _milestoneBackups = new List<Backup>();

        private List<Backup> _allBackups = new List<Backup>();

        public void InitPage ()
        {
            LoadToMemory();

            ReadFilters();
        }

        /// <summary>
        /// Loads the backup folders into representations in memory for manipulation
        /// </summary>
        private void LoadToMemory()
        {
            List<DirectoryInfo> manualBackups    = FileHandler.GetAllDirectories(r_backupLocation + c_manualBackupFolder);
            List<DirectoryInfo> milestoneBackups = FileHandler.GetAllDirectories(r_backupLocation + c_manualBackupFolder + c_milestoneBackupFolder);

            List<DirectoryInfo> automaticBackups = FileHandler.GetAllDirectories(r_backupLocation + c_automaticBackupFolder);

            _manualBackups.Clear();
            foreach (DirectoryInfo folder in manualBackups)
            {
                Logging.Logger.Log($"Parent folder name {folder.Parent.Name}", Logging.Logger.ErrorLevel.Info);
                if (folder.Name == FolderNames.Milestones) continue; // The Milestones folder is not a backup

                Backup backup = new Backup()
                {
                    Data = GetDataTypesInBackup(folder),
                    Maps = GetMapsInBackup(folder),
                    Automatic = false,
                    Milestone = false,
                    FolderName = folder.Name,
                    Path = folder.FullName,
                    DateCreated = folder.CreationTime,
                    Name = folder.Name,
                    Id = Guid.NewGuid()
                };
                    
                _manualBackups.Add(backup);
                _allBackups.Add(backup);
            }

            _automaticBackups.Clear();
            foreach (DirectoryInfo folder in automaticBackups)
            {
                Logging.Logger.Log($"Parent folder name {folder.Parent.Name}", Logging.Logger.ErrorLevel.Info);
                if (folder.Name == FolderNames.TransferData) continue; // The Transfers folder is not a backup

                Backup backup = new Backup()
                {
                    Data = GetDataTypesInBackup(folder),
                    Maps = GetMapsInBackup(folder),
                    Automatic = true,
                    Milestone = false,
                    FolderName = folder.Name,
                    Path = folder.FullName,
                    DateCreated = folder.CreationTime,
                    Name = folder.Name,
                    Id = Guid.NewGuid()
                };

                _automaticBackups.Add(backup);
                _allBackups.Add(backup);
            }

            _milestoneBackups.Clear();
            foreach (DirectoryInfo folder in milestoneBackups)
            {
                Backup backup = new Backup()
                {
                    Data = GetDataTypesInBackup(folder),
                    Maps = GetMapsInBackup(folder),
                    Automatic = false,
                    Milestone = true,
                    FolderName = folder.Name,
                    Path = folder.FullName,
                    DateCreated = folder.CreationTime,
                    Name = folder.Name,
                    Id = Guid.NewGuid()
                };

                _milestoneBackups.Add(backup);
                _allBackups.Add(backup);
            }
        }
        

        /// <summary>
        /// Returns a list of the data types in a folder
        /// </summary>
        /// <param name="backup"> The directoryinfo of the backup </param>
        /// <returns></returns>
        private List<DataType> GetDataTypesInBackup (DirectoryInfo backup)
        {
            List<DataType> types = new List<DataType>();
            DirectoryInfo[] directories = backup.GetDirectories();

            for (int x = 0; x < directories.Length; x++)
                switch (directories[x].Name)
                {
                    case FolderNames.Clusters:
                        types.Add(DataType.TransferData);
                        break;

                    case FolderNames.Configs:
                        types.Add(DataType.ConfigData);
                        break;

                    case FolderNames.Maps:
                        types.Add(DataType.MapData);
                        break;
                }

            return types;
        }

        /// <summary>
        /// Returns a list of the maps in a backup
        /// </summary>
        /// <param name="backup"> The DirectoryInfo of the backup to parse </param>
        /// <returns> A list of maps in the backup </returns>
        private List<MapType> GetMapsInBackup (DirectoryInfo backup)
        {
            List<MapType> maps = new List<MapType>();
            if (FileHandler.GetSubFolder(backup, FolderNames.Maps) == null) return maps;
            DirectoryInfo[] mapsFolders = FileHandler.GetSubFolder(backup, FolderNames.Maps).GetDirectories();

            for (int i = 0; i < mapsFolders.Length; i++)
                switch(mapsFolders[i].Name)
                {
                    case Map.Aberration:
                        maps.Add(MapType.Aberration);
                        break;

                    case Map.Center:
                        maps.Add(MapType.Center);
                        break;

                    case Map.Crystal:
                        maps.Add(MapType.Crystal);
                        break;

                    case Map.Extinction:
                        maps.Add(MapType.Extinction);
                        break;

                    case Map.GenesisOne:
                        maps.Add(MapType.GenesisOne);
                        break;

                    case Map.Island:
                        maps.Add(MapType.Island);
                        break;

                    case Map.Ragnarok:
                        maps.Add(MapType.Ragnarok);
                        break;

                    case Map.Scorched:
                        maps.Add(MapType.Scorched);
                        break;

                    case Map.Valguero:
                        maps.Add(MapType.Valguero);
                        break;

                    case Map.GenesisTwo:
                        maps.Add(MapType.GenesisTwo);
                        break;
                }

            return maps;
        }

        private void ReadFilters ()
        {

        }

        /// <summary>
        /// Returns a Backup with the specified GUID
        /// </summary>
        /// <param name="backupId"> GUID of backup to retrieve </param>
        /// <returns> Retrieved backup </returns>
        public Backup GetBackup(Guid backupId)
        {
            foreach (Backup backup in _allBackups)
                if (backup.Id == backupId) return backup;

            return new Backup();
        }
        
        public List<TreeNode> GetManualBackups()
        {
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (Backup backup in _manualBackups)
                nodes.Add(new TreeNode(backup.Name) { Tag = backup.Id });

            return nodes;
        }

        public List<TreeNode> GetAutomaticBackups()
        {
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (Backup backup in _automaticBackups)
                nodes.Add(new TreeNode(backup.Name) { Tag = backup.Id });

            return nodes;
        }

        public List<TreeNode> GetMilestoneBackups()
        {
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (Backup backup in _milestoneBackups)
                nodes.Add(new TreeNode(backup.Name) { Tag = backup.Id });

            return nodes;
        }
    }
}
