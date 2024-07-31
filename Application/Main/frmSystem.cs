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
            this.DecentralizationToolStripMenuItem.Click += DecentralizationToolStripMenuItem_Click;
            this.BookToolStripMenuItem.Click += BookToolStripMenuItem_Click;
            this.CategoriesToolStripMenuItem.Click += CategoriesToolStripMenuItem_Click;
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CategorieForm.Show();
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formBooks.Show();
        }

        private void DecentralizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DecentralizationForm.Show();
        }
    }
}
