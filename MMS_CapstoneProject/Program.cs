using System;
using System.Windows.Forms;

namespace MMS_CapstoneProject
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
            //Application.Run(new ClientForm());
            //Application.Run(new TracksForm());
            Application.Run(new MainForm());
        }
    }
}
