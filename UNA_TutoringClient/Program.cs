using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA_TutoringClient.Forms;

namespace UNA_TutoringClient
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
            //Application.Run(new FormMainMenu());

            FormLogin login = new FormLogin();

            Application.Run(login);

            if (login.valid_user())
            {
                Application.Run(new FormMainMenu());
            }
        }

    }
}
