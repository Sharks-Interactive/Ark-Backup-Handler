﻿using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABH
{
    static class VersionHandler
    {
        /// <summary>
        /// Retrieves the number of the latest release from the GitHub page
        /// </summary>
        /// <returns> Octokit.Release object of the latest release </returns>
        public static async Task<Release> GetLatestVersion()
        {
            GitHubClient _client = new GitHubClient(new ProductHeaderValue(Program.AppName));
            var releases = await _client.Repository.Release.GetAll(Program.Owner, Program.AppName);
            Release latest = releases[0];
            Debug.WriteLine(
                $"The latest release is tagged at {latest.TagName} and is named {latest.Name}"
                );

            LatestVersion = latest.TagName;

            return latest;
        }

        /// <summary>
        /// Downloads the latest release and relaunches the application
        /// </summary>
        /// <returns></returns>
        public static async Task DownloadUpdate(Release latest)
        {
            // User feedback
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Run(() =>
            {
                MessageBox.Show(
                   $"Downloading update, please wait. Ark Backup Handler will restart automatically if the download completes successfully.",
                   "Updating Now",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation
                );
            });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

            GitHubClient _client = new GitHubClient(new ProductHeaderValue(Program.AppName));
            string _latestPath = Directory.GetParent(System.Windows.Forms.Application.StartupPath).FullName; // Get the parent directory of the .exe
            _latestPath = Directory.GetParent(_latestPath).FullName; // Get the parent of the parent directory
            _latestPath += $"\\Ark Backup Handler {latest.TagName}";
            Directory.CreateDirectory(_latestPath); // Verify the path to our new download

            // Get a list of release assets
            var latestAsset = await _client.Repository.Release.GetAllAssets(Program.Owner, Program.AppName, latest.Id);

            // Download Release.zip to ram here
            var response = await _client.Connection.Get<object>(new Uri(latestAsset[0].BrowserDownloadUrl), new Dictionary<string, string>(), "application/octet-stream");

            // Save the download to disk
            byte[] bytes = (byte[])response.HttpResponse.Body;
            File.WriteAllBytes($"{_latestPath}\\Release {latest.TagName}.zip", bytes);

            // Extract the downloaded zip, check if it contains an executable and then run that executable, if all that suceeds exit the current instance
            if (!Directory.Exists($"{_latestPath}\\Ark Backup Handler Stable\\")) ZipFile.ExtractToDirectory($"{_latestPath}\\Release {latest.TagName}.zip", _latestPath);
            if (!File.Exists($"{_latestPath}\\Ark Backup Handler Stable\\Ark Backup Handler.exe")) return;
            if (Process.Start($"{_latestPath}\\Ark Backup Handler Stable\\Ark Backup Handler.exe") != null) System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// A string containing the current version of Ark Backup Handler
        /// </summary>
        public static string CurrentVersion { get => typeof(Program).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion; set => CurrentVersion = value; }

        public static string LatestVersion = "";

        /// <summary>
        /// Checks whether the application is up to date. Please run GetLatestVersion first.
        /// </summary>
        /// <returns></returns>
        public static bool CheckUpToDate() => $"v{CurrentVersion}" == LatestVersion;

        /// <summary>
        /// Informs the user if there is an update
        /// </summary>
        /// <returns> Whether the user has heeded the notification </returns>
        public static async Task<bool> InformAboutUpdate()
        {
            Release _latest = null;
            try { _latest = await GetLatestVersion(); } catch { Debug.WriteLine("Unable to check for updates."); }

            if (!CheckUpToDate())
            {
                DialogResult _result = MessageBox.Show(
                    $"Your Backup Handler is out of date. Would you like to automatically update? The current version is v{CurrentVersion} and the latest is {LatestVersion}. You can download it manually at https://github.com/Sharks-Interactive/Ark-Backup-Handler/releases/tag/{LatestVersion}.",
                    "Update Available",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation
                );

                // Return true if the user hits either of these buttons
                if (_latest == null) return false;
                if (_result == DialogResult.Yes) await DownloadUpdate(_latest);
            }

            return false;
        }
    }
}
