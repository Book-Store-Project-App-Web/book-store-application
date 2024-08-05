﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Main
{
    static class Program
    {
        public static frmLogin loginForm = null;
        public static frmSystem SystemForm = null;
        public static frmBooks formBooks = null;
        public static frmUser UserForm = null;
        public static frmCategorie CategorieForm = null;
        public static frmInvoice InvoiceForm = null;
        public static frmGroup_User GUForm = null;
        public static frmGroup_Screen GCForm = null;
        public static frmStatistic StaticticalForm = null;
        public static frmImport_Invoicecs Import_InvoicecForm = null;

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
            formBooks = new frmBooks();
            CategorieForm = new frmCategorie();
            UserForm = new frmUser();
            InvoiceForm = new frmInvoice();
            GUForm = new frmGroup_User();
            GCForm = new frmGroup_Screen();
            StaticticalForm = new frmStatistic();
            Import_InvoicecForm = new frmImport_Invoicecs(loginForm.LoggedInUserId);
            Application.Run(loginForm);
        }
    }
}
