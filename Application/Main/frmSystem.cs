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
            this.QuanLyHangMenu.Click += QuanLyHangMenu_Click;
            this.DecentralizationToolStripMenuItem.Click += DecentralizationToolStripMenuItem_Click;
        }

        private void DecentralizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DecentralizationForm.Show();
        }

        private void QuanLyHangMenu_Click(object sender, EventArgs e)
        {
            //Program.BookFrom.Show();
        }
    }
}
