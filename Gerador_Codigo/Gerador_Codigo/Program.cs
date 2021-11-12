using Gerador_Codigo.Services;
using System;
using System.Windows.Forms;

namespace Gerador_Codigo
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEscolherBanco());
            //FormResolve.Resolve<FormEscolherBanco>().Show();
        }
    }
}
