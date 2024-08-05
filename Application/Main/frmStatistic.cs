using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Main
{
    public partial class frmStatistic : Form
    {
        BLLBook bllBook = new BLLBook();

        public frmStatistic()
        {
            InitializeComponent();
            this.Load += FrmStatistic_Load;
        }
        void LoadGridView()
        {
            dataGridView1.DataSource = bllBook.Top10BookofMonth();
            dataGridView1.Columns["image"].Visible = false;
            if (dataGridView1.Columns["ImageColumn"] == null)
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                {
                    HeaderText = "Image",
                    Name = "ImageColumn",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };

                dataGridView1.Columns.Insert(0, imageColumn);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Image"] != null && row.Cells["Image"].Value != null)
                {
                    row.Cells["ImageColumn"].Value = Image.FromStream(new System.Net.WebClient().OpenRead(row.Cells["Image"].Value.ToString()));
                }
            }
            List<dynamic> ListTotal = bllBook.TotalOrder();

            double total = 0;

            foreach (var order in ListTotal)
            {
                double price = Convert.ToDouble(order.totalOrderPrice);
                total += price;
            }

            label3.Text = Convert.ToString(DateTime.Now.Month);
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongDT.Text = total.ToString("C0", culture);

        }
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
