using Hotel_Management_System.GUI;
using Hotel_Management_System.CustomControl;
using Hotel_Management_System.DAO;
using Hotel_Management_System.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Hotel_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormKetNoiCSDL());
        }
    }
}
