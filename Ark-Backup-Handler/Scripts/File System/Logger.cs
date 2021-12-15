using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ABH.Files;
using ABH.Utility;

namespace ABH.Logging
{
    public static class Logger
    {
        private static readonly string r_logDirectory = Application.LocalUserAppDataPath + @"/Logs/";
        private const string c_logFileName = "Log.sid";

        /// <summary>
        /// How bad is an error, based on whether or not it affects the 
        /// desired behaviour from being achieved
        /// </summary>
        public enum ErrorLevel
        {
            /// <summary>
            /// Something important
            /// </summary>
            Info,
            /// <summary>
            /// Something went wrong, but it won't affect anything
            /// </summary>
            Warning,
            /// <summary>
            /// Something went wrong and it has affected something
            /// </summary>
            Error
        }

        /// <summary>
        /// Logs an event to the log file, console and in app information system
        /// </summary>
        /// <param name="Message"> The event message </param>
        /// <param name="LogLevel"> The events affect </param>
        public static void Log(string Message, ErrorLevel LogLevel)
        {
            Message = TimeHelper.ExactTimeString + " - " + LogLevel.ToString()
                + ": " + Message;

            // Create the log file if it does not exist
            if (File.Exists(r_logDirectory + c_logFileName))
                FileHandler.AddToFile(r_logDirectory, c_logFileName, Message);
            else
                FileHandler.WriteToFileSingle(r_logDirectory, c_logFileName, Message);

            Program.UIProcess.SetErrorText(Message);
            Debug.WriteLine(Message);

            switch (LogLevel)
            {
                case ErrorLevel.Info:
                    Program.UIProcess.SetErrorColor(Color.White);
                    break;

                case ErrorLevel.Warning:
                    Program.UIProcess.SetErrorColor(Color.Yellow);
                    break;

                case ErrorLevel.Error:
                    Program.UIProcess.SetErrorColor(Color.Red);
                    break;

                default:
                    Program.UIProcess.ForeColor = Color.White;
                    break;
            }
        }
    }
}
