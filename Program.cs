using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinExtended
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainPage frmMain = new MainPage();
            frmMain.Show();

            Application.Run();
        }
    }
}
