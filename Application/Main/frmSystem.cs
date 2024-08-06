using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Main
{
    public partial class frmSystem : Form
    {
        private int loggedInUserId;
        BLLUser GUIUser = new BLLUser();
        public frmSystem(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            this.FormClosed += FrmSystem_FormClosed;
            this.Load += FrmSystem_Load;
            this.BookToolStripMenuItem.Click += BookToolStripMenuItem_Click;
            this.CategoriesToolStripMenuItem.Click += CategoriesToolStripMenuItem_Click;
            this.ImportInvoiceToolStripMenuItem.Click += ImportInvoiceToolStripMenuItem_Click;
            this.InvoiceToolStripMenuItem.Click += InvoiceToolStripMenuItem_Click;
            this.AccountToolStripMenuItem.Click += AccountToolStripMenuItem_Click;
            this.DecentraliAccountToolStripMenuItem.Click += DecentraliAccountToolStripMenuItem_Click;
            this.Top10ToolStripMenuItem.Click += Top10ToolStripMenuItem_Click;
            this.StatisticBookSalesToolStripMenuItem.Click += StatisticBookSalesToolStripMenuItem_Click;
            this.RevenueToolStripMenuItem.Click += RevenueToolStripMenuItem_Click;
            this.ExpenditurreToolStripMenuItem.Click += ExpenditurreToolStripMenuItem_Click;
        }

        private void ExpenditurreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ExpenditureForm == null || Program.ExpenditureForm.IsDisposed)
            {
                Program.ExpenditureForm = new frmExpenditure();
            }
            Program.ExpenditureForm.Show();
        }

        private void RevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.RevenueForm == null || Program.RevenueForm.IsDisposed)
            {
                Program.RevenueForm = new frmRevenue();
            }
            Program.RevenueForm.Show();
        }

        private void StatisticBookSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.StatiscticBookSales == null || Program.StatiscticBookSales.IsDisposed)
            {
                Program.StatiscticBookSales = new frmStatisticBook_Sales();
            }
            Program.StatiscticBookSales.Show();
        }

        private void FrmSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void FrmSystem_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }
        public void LoadStaff()
        {
            var loggedInUser = GUIUser.GetUserById(loggedInUserId);
            if (loggedInUser != null)
            {
                lbFullname.Text = $"{loggedInUser.firstName} {loggedInUser.lastName}";
            }

        }

        private void Top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.StaticticalTop10Form == null || Program.StaticticalTop10Form.IsDisposed)
            {
                Program.StaticticalTop10Form = new frmStatisticTop10();
            }
            Program.StaticticalTop10Form.Show();
        }

        private void DecentraliAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UserForm == null || Program.UserForm.IsDisposed)
            {
                Program.UserForm = new frmUser();
            }
            Program.UserForm.Show();
        }

        private void InvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.InvoiceForm == null || Program.InvoiceForm.IsDisposed)
            {
                Program.InvoiceForm = new frmInvoice();
            }
            Program.InvoiceForm.Show();
        }

        private void ImportInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Import_InvoicecForm == null || Program.Import_InvoicecForm.IsDisposed)
            {
                Program.Import_InvoicecForm = new frmImport_Invoicecs(loggedInUserId);
            }
            Program.Import_InvoicecForm.Show();
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CategorieForm == null || Program.CategorieForm.IsDisposed)
            {
                Program.CategorieForm = new frmCategorie();
            }
            Program.CategorieForm.Show();
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formBooks.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

    }
}
