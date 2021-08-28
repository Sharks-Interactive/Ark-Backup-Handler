using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ABH.Logging;

namespace ABH.Files
{
    public static class FileHandler
    {
        /// <summary>
        /// Writes a message to a file on the hard drive
        /// </summary>
        /// <param name="Path"> The Directory the file should be created/written to in. </param>
        /// <param name="FileName"> The name of the file to be created/written to. </param>
        /// <param name="Data"> The data that should be written to the file. </param>
        /// <returns> Was the operation successfull? </returns>
        public static bool WriteToFile(string Path, string FileName, string Data)
        {
            try
            {
                Directory.CreateDirectory(Path);
                using (FileStream _stream = new FileStream(Path + FileName, FileMode.OpenOrCreate))
                using (StreamWriter _writer = new StreamWriter(_stream))
                    _writer.WriteLine(Data + "\n");
            }
            catch 
            { 
                Logger.Log($"Failed to create or write {Data} to file: {FileName} in {Path}!", Logger.ErrorLevel.Error); 
                return false; 
            }
            return true;
        }

        /// <summary>
        /// Adds data on to a file on the hard drive, creating one if it does not exist
        /// </summary>
        /// <param name="Path"> The Directory the file should be created/written to in. </param>
        /// <param name="FileName"> The name of the file to be created/written to. </param>
        /// <param name="Data"> The data that should be written to the file. </param>
        /// <returns> Was the operation successfull? </returns>
        public static bool AddToFile(string Path, string FileName, string Data)
        {
            List<string> _file;
            try
            {
                string[] _unmodifiedFile = File.ReadAllLines(Path + FileName);

                _file = _unmodifiedFile.ToList();
                _file.Add(Data);
            }
            catch
            {
                // Careful! Can lock into recursion provided logger calls this method...
                Logger.Log($"Failed to read file {FileName} at {Path}", Logger.ErrorLevel.Warning);
                return false;
            }
            try
            {
                Directory.CreateDirectory(Path);
                using (FileStream _stream = new FileStream(Path + FileName, FileMode.OpenOrCreate))
                using (StreamWriter _writer = new StreamWriter(_stream))
                    for (int x = 0; x < _file.Count; x++)
                        _writer.WriteLine(_file[x]);
            }
            catch
            {
                Logger.Log($"Failed to create or write {Data} to file: {FileName} in {Path}!", Logger.ErrorLevel.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validates file path and makes a call to Copy();
        /// </summary>
        /// <param name="SourceDirectory"> The directory you want to clone </param>
        /// <param name="TargetDirectory"> Where should the cloned files go </param>
        /// <returns> Did the operation suceed? </returns>
        public static bool CopyIntoFolder(string SourceDirectory, string TargetDirectory)
        {
            Directory.CreateDirectory(TargetDirectory); // Validate directory
            return Copy(SourceDirectory, TargetDirectory);
        }

        /// <summary>
        /// Copies all files including sub directories from the source dir to the target dir
        /// </summary>
        /// <param name="SourceDirectory"> Path to the files you want to copy </param>
        /// <param name="TargetDirectory"> Path to where the files should be copied to </param>
        /// <returns> Whether the operation was a success </returns>
        public static bool Copy(string SourceDirectory, string TargetDirectory)
        {
            if (!Directory.Exists(SourceDirectory) && Directory.Exists(TargetDirectory))
            {
                Logger.Log($"Failed to copy files, one or more directories does not exist!" +
                    $" Please validate the following directories: Source (What we're trying to copy from)" +
                    $" {SourceDirectory} Target (Where we're trying to copy to) {TargetDirectory}", 
                    Logger.ErrorLevel.Error);
                return false;
            }
            DirectoryInfo _diSource = new DirectoryInfo(SourceDirectory);
            DirectoryInfo _diTarget = new DirectoryInfo(TargetDirectory);

            return CopyAll(_diSource, _diTarget);
        }

        /// <summary>
        /// Recursive function to actually copy files in a directory
        /// </summary>
        /// <param name="SourceDirectory"> Path to the files you want copied </param>
        /// <param name="TargetDirectory"> Path to where you want the files copied </param>
        /// <returns> Whether the operation was a success</returns>
        public static bool CopyAll(DirectoryInfo SourceDirectory, DirectoryInfo TargetDirectory)
        {
            if (Directory.Exists(TargetDirectory.FullName))
                Directory.Delete(TargetDirectory.FullName, true);

            Directory.CreateDirectory(TargetDirectory.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo t_file in TargetDirectory.GetFiles())
            {
                try
                {
                    t_file.CopyTo(Path.Combine(TargetDirectory.FullName, t_file.Name), true);
                }
                catch (Exception E)
                {
                    Logger.Log($"Failed to copy file {t_file.Name} in {t_file.FullName} to " +
                        $"{TargetDirectory.FullName} the following error occured: {E.Message}", 
                        Logger.ErrorLevel.Error);
                    return false;
                }
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo _dirSourceSubDir in SourceDirectory.GetDirectories())
            {
                DirectoryInfo _nextTargetSubDir = TargetDirectory.CreateSubdirectory(_dirSourceSubDir.Name);
                if (!CopyAll(_dirSourceSubDir, _nextTargetSubDir))
                    return false;
            }

            return true;
        }
    }
}
