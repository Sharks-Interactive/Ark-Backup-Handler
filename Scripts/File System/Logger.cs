using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ABH.Files.Logging
{
    public static class Logger
    {
        public enum ErrorLevel
        {
            Info,
            Warning,
            Error
        }

        public static void Log(string Message, ErrorLevel LogLevel)
        {
            switch (LogLevel)
            {
                case ErrorLevel.Info:
                    new StreamWriter(@"") // Write to log files
                        // Log to console
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
