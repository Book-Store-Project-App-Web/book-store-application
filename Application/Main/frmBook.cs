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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookDataSet1);

        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.bookDataSet1.Book);

        }
    }
}
