using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    static class Program
    {
        public static frmLogin loginForm = null;
        public static frmUser UserForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new frmLogin();
            UserForm = new frmUser();
            Application.Run(new frmSystem());
        }
    }
}
