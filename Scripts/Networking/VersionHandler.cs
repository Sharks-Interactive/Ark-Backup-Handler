using Octokit;
using System.Diagnostics;
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
            GitHubClient _client = new GitHubClient(new ProductHeaderValue("Ark-Backup-Handler"));
            var releases = await _client.Repository.Release.GetAll("Sharks-Interactive", "octokit.net");
            Release latest = releases[0];
            Debug.WriteLine(
                "The latest release is tagged at {0} and is named {1}",
                latest.TagName,
                latest.Name);

            LatestVersion = latest.TagName;

            return latest;
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
        public static bool CheckUpToDate() => CurrentVersion == LatestVersion;

        /// <summary>
        /// Informs the user if there is an update
        /// </summary>
        /// <returns> Whether the user has heeded the notification </returns>
        public static async Task<bool> InformAboutUpdate()
        {
            await GetLatestVersion();

            if (!CheckUpToDate())
            {
                DialogResult _result = MessageBox.Show(
                    "Update Available",
                    $"Your Backup Handler is out of date. The current version is v{CurrentVersion} and the latest is v{LatestVersion}. You can download it at https://github.com/Sharks-Interactive/Ark-Backup-Handler/releases/tag/v{LatestVersion}.",
                    MessageBoxButtons.AbortRetryIgnore,
                    MessageBoxIcon.Exclamation
                );

                // Return true if the user hits either of these buttons
                return _result == DialogResult.Abort || _result == DialogResult.Retry;
            }

            return false;
        }
    }
}
