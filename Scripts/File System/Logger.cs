using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

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
                    // Read old log file first if it exists
                    WriteToFile(
                        Application.LocalUserAppDataPath + @"/Sharks Interactive/Ark Backup Handler/",
                        Message + "_" + LogLevel.ToString()
                        );

                    FileStream _stream = new FileStream(Application.LocalUserAppDataPath + @"/Sharks Interactive/Ark Backup Handler/Log.sid", FileMode.OpenOrCreate);
                    StreamWriter _writer = new StreamWriter();
                    _writer.WriteLine(Message + "\n"); // Write to log files
                    
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

        private static bool WriteToFile(string _path, string _data)
        {
            Directory.CreateDirectory(_path);
        }
    }
}
