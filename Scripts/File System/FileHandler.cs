using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using ABH.Files.Logging;

namespace ABH.Files
{
    public static class FileHandler
    {
        /// <summary>
        /// Copies all files including sub directories from the source dir to the target dir
        /// </summary>
        /// <param name="_sourceDirectory"> Path to the files you want to copy </param>
        /// <param name="_targetDirectory"> Path to where the files should be copied to </param>
        /// <returns> Whether the operation was a success </returns>
        public static bool Copy(string _sourceDirectory, string _targetDirectory)
        {
            if (!Directory.Exists(_sourceDirectory) && Directory.Exists(_targetDirectory))
            {
                Debug.WriteLine("Error: One copy dir was not valid!");
                return false;
            }
            DirectoryInfo _diSource = new DirectoryInfo(_sourceDirectory);
            DirectoryInfo _diTarget = new DirectoryInfo(_targetDirectory);

            return CopyAll(_diSource, _diTarget);
        }

        /// <summary>
        /// Recursive function to actually copy files in a directory
        /// </summary>
        /// <param name="_source"> Path to the files you want copied </param>
        /// <param name="_target"> Path to where you want the files copied </param>
        /// <returns> Whether the operation was a success</returns>
        public static bool CopyAll(DirectoryInfo _source, DirectoryInfo _target)
        {
            if (Directory.Exists(_target.FullName))
                Directory.Delete(_target.FullName, true);

            Directory.CreateDirectory(_target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo t_file in _source.GetFiles())
            {
                try
                {
                    t_file.CopyTo(Path.Combine(_target.FullName, t_file.Name), true);
                }
                catch (Exception E)
                {
                    Debug.WriteLine("Error copying files " + E.Message);
                    return false;
                }
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo _dirSourceSubDir in _source.GetDirectories())
            {
                DirectoryInfo _nextTargetSubDir = _target.CreateSubdirectory(_dirSourceSubDir.Name);
                if (!CopyAll(_dirSourceSubDir, _nextTargetSubDir))
                    return false;
            }

            return true;
        }
    }
}
