using ABH.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ABH.Files.MoD
{
    public static class ModManager
    {
        private const string c_gameIniPath = @"\UWPConfig\UWP\Game.ini";
        private const string c_gusIniPath = @"\UWPConfig\UWP\GameUserSettings.ini";

        private const string c_modHeader = "[MessageOfTheDay]";

        private const string c_unstableMessage = "Unstable";
        private const string c_stableMessage = "Stable";

        private static readonly string r_saveLocation = Properties.Settings.Default.saveLocation;

        private static readonly decimal r_mapSaveInterval = Properties.Settings.Default.autoSaveInterval;
        private static readonly decimal r_transferSaveInterval = Properties.Settings.Default.transferDataSaveInterval;

        /// <summary>
        /// Updates the message of the day
        /// </summary>
        public static void UpdateMessegeOfTheDay()
        {
            string[] _ini = new string[1];
            if (!ReadFromIni(ref _ini)) return;

            int _line = 0;

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

            // DYNAMIC STRING INTERPOLATION HERE READ FROM SETTINGS
            _ini[_line + 1] = $"Message=Welcome to the Toasty Bros Server Network. Today is {_date}. Server network: {_unstableOrStable}. Toast quote of the year: \"Toast!\". Save backups occur every {r_mapSaveInterval} minutes and transfer data backs-up every {r_transferSaveInterval} minutes. Last backup is {DateTime.Now.ToString("dd/M")}. Stay Toasty!";
            
            if (WriteToIni(_ini))
                Logger.Log("MoD update complete.", Logger.ErrorLevel.Info);
        }

        // MOVE THESE TO FILEHANDLER

        /// <summary>
        /// Reads and verifies the INI file.
        /// </summary>
        /// <param name="Ini"> The array to store the read file in </param>
        /// <returns> Was the operation a success </returns>
        private static bool ReadFromIni(ref string[] Ini)
        {
            try
            {
                Ini = File.ReadAllLines(r_saveLocation + c_gusIniPath);
            }
            catch (Exception _ex)
            {
                Logger.Log($"Problem while reading GameUserSettings.ini, problem: {_ex.Message}", Logger.ErrorLevel.Error);
                return false;
            }

            // If the ini is less than 3 lines we can assume there was a read error
            if (Ini.Count() < 4)
            {
                Logger.Log("Unspecified error reading ini.", Logger.ErrorLevel.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Writes the array to the INI file
        /// </summary>
        /// <param name="Ini"> The array to write to the file </param>
        /// <returns> Was the operation a success </returns>
        private static bool WriteToIni(string[] Ini)
        {
            try { File.Delete(r_saveLocation + c_gusIniPath); } catch (Exception _ex) { Logger.Log($"Problem while deleting old GameUserSettings.ini problem: {_ex.Message}", Logger.ErrorLevel.Error); }
            using (FileStream _stream = new FileStream(r_saveLocation + c_gusIniPath, FileMode.OpenOrCreate))
            using (StreamWriter _writer = new StreamWriter(_stream, Encoding.UTF8))
                for (int i = 0; i < Ini.Count(); i++)
                    try
                    {
                        _writer.WriteLine(Ini[i]);
                    }
                    catch (Exception _exc)
                    {
                        Logger.Log($"Problem while writing to GameUserSettings.ini file. Problem: {_exc.Message}", Logger.ErrorLevel.Error);
                        return false;
                    }

            return true;
        }
    }
}
