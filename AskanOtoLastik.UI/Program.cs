using AskanOtoLastik.Data;
using Microsoft.Win32;

namespace AskanOtoLastik.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitialDbSetup.Create();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}