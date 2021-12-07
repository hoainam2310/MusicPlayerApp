using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayerApp;
using MusicPlayer;

namespace MusicApp
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

            //Application.Run(new animated_rain_loading());

            //Application.Run(new sign_in());
            //Application.Run(new register());
            //Application.Run(new forgotpw());
            //Application.Run(new mainmenu());
            Application.Run(new frmMain());
           //Application.Run(new frmQuanLy());


        }
    }
}
