using System.Diagnostics;
using System.Windows.Forms;
using ABH.Files;
using ABH.Utility;

namespace ABH.Logging
{
    public static class Logger
    {
        private static readonly string r_logDirectory = Application.LocalUserAppDataPath + @"/Sharks Interactive/Ark Backup Handler/";
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

            FileHandler.WriteToFile(r_logDirectory, c_logFileName, Message);
            Debug.WriteLine(Message);

            switch (LogLevel)
            {
                case ErrorLevel.Info:
                    //errorDisplay.ForeColor = Color.White;
                    //errorDisplay.Text = "Info: " + Messege;
                    // Update in app error display
                    break;

                case ErrorLevel.Warning:
                    //errorDisplay.ForeColor = Color.Yellow;
                    //errorDisplay.Text = "Warning: " + Messege;
                    break;

                case ErrorLevel.Error:
                    //errorDisplay.ForeColor = Color.Red;
                    //errorDisplay.Text = "Error: " + Messege;
                    break;
            }
        }
    }
}
