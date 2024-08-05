using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class frmSystem : Form
    {
        public frmSystem()
        {
            InitializeComponent();
            this.BookToolStripMenuItem.Click += BookToolStripMenuItem_Click;
            this.CategoriesToolStripMenuItem.Click += CategoriesToolStripMenuItem_Click;
            this.ImportInvoiceToolStripMenuItem.Click += ImportInvoiceToolStripMenuItem_Click;
        }

        private void ImportInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Import_InvoicecForm.Show();
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CategorieForm.Show();
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formBooks.Show();
        }
    }
}
