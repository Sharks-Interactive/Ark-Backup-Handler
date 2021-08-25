using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABH.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace ABH
{
    static class Program
    {
        #region Globals

        public static string Owner   = "Sharks-Interactive";
        public static string AppName = "Ark-Backup-Handler";

        #endregion

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
