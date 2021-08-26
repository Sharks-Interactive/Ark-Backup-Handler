using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABH.UI;

namespace ABH
{
    static class Program
    {
        public static readonly string Owner   = "Sharks-Interactive";
        public static readonly string AppName = "Ark-Backup-Handler";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if DEBUG
            Application.Run(new UIProcess());
#else
            if (await VersionHandler.InformAboutUpdate())
                Application.Run(new UIProcess());
            else
                Application.Exit();
#endif
        }
    }
}
