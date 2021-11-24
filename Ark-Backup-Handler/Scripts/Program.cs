using System;
using System.Windows.Forms;
using ABH.UI;

namespace ABH
{
    static class Program
    {
        public static readonly string Owner = "Sharks-Interactive";
        public static readonly string AppName = "Ark-Backup-Handler";

        public static UIProcess UIProcess;

        /// <summary>
        /// The entry point for ABH.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            VersionHandler.InformAboutUpdate();
            Application.Run(UIProcess = new UIProcess()); 
        }
    }
}
