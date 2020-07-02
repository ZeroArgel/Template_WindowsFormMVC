using System;
using System.Windows.Forms;
using TemplateMVC.Views.Login;

namespace TemplateMVC
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
            Application.Run(mainForm: new Login());
        }
    }
}