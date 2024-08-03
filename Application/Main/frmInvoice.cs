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
    public partial class frmInvoice : Form
    {
        BLLInvoice bllinvoice = new BLLInvoice();
        public frmInvoice()
        {
            InitializeComponent();
            this.Load += FrmInvoice_Load;
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            LoadInvoice();
        }

        public void LoadInvoice()
        {
            dataGridView1.DataSource = bllinvoice.LoadInvoice();
        }
    }
}
