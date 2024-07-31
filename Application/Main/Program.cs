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
        public static frmSystem SystemForm = null;
        public static frmDecentralization DecentralizationForm = null;
        public static frmBooks formBooks = null;
        public static frmUser UserForm = null;
        public static frmCategorie CategorieForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new frmLogin();
            SystemForm = new frmSystem();
            //BookFrom = new frmBook();
            DecentralizationForm = new frmDecentralization();
            formBooks = new frmBooks();
            CategorieForm = new frmCategorie();
            UserForm = new frmUser();
            Application.Run(UserForm);
        }
    }
}
