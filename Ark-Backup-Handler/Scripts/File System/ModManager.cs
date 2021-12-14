using ABH.Logging;
using System;
using ABH.Utility;
using System.IO;
using System.Linq;
using ABH.Properties;

namespace ABH.Files.MoD
{
    public static class ModManager
    {
        private const string c_gameIniPath = @"\UWPConfig\UWP\Game.ini";
        private const string c_gusIniPath  = @"\UWPConfig\UWP\GameUserSettings.ini";

        private const string c_modHeader = "[MessageOfTheDay]";

        private const string c_unstableMessage = "Unstable";
        private const string c_stableMessage   = "Stable";

        private static readonly string r_saveLocation = Settings.Default.saveLocation;
        private static readonly string r_modTemplate  = Settings.Default.modTemplate;

        private static readonly decimal r_mapSaveInterval      = Settings.Default.autoSaveInterval;
        private static readonly decimal r_transferSaveInterval = Settings.Default.transferDataSaveInterval;


        private static object _formatModel;

        /// <summary>
        /// Updates the message of the day
        /// </summary>
        public static void UpdateMessegeOfTheDay()
        {
            string[] _ini = new string[1];
            if (!FileHandler.ReadFromFile(ref _ini, r_saveLocation + c_gusIniPath, 3))
            {
                Logger.Log($"Unable to read GameUserSettings.ini at: {r_saveLocation + c_gusIniPath}", Logger.ErrorLevel.Error);
                return;
            }

            int _line;
            for (_line = 0; _line < _ini.Count(); ++_line)
                if (_ini[_line].Contains(c_modHeader))
                    break;

            if (_line == 0)
            {
                Logger.Log("Unable to parse GameUserSettings.ini", Logger.ErrorLevel.Error);
                return;
            }

            string _unstableOrStable = DateTime.Now.Day - File.GetLastWriteTime(r_saveLocation + c_gameIniPath).Day < 5 ?
                c_unstableMessage : c_stableMessage;
            string _date = DateTime.Now.ToString("D");

            _formatModel = new { Date = _date, UnstableOrStable = _unstableOrStable, 
                MapSaveInterval = r_mapSaveInterval, TransferSaveInterval = r_transferSaveInterval };
            _ini[_line + 1] = Format.FormatTemplate(r_modTemplate, _formatModel);

            if (FileHandler.WriteFile(_ini, r_saveLocation + c_gusIniPath))
                Logger.Log("MoD update complete.", Logger.ErrorLevel.Info);
            else
                Logger.Log("Unable to update MoD", Logger.ErrorLevel.Error);
        }
    }
}
