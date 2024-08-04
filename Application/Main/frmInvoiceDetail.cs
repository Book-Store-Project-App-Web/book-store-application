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
    public partial class frmInvoiceDetail : Form
    {
        private int _orderId;
        BLLBookOrders GUIBookOrders = new BLLBookOrders();
        public frmInvoiceDetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            this.Load += FrmInvoiceDetail_Load;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmInvoiceDetail_Load(object sender, EventArgs e)
        {
            LoadBookOrders();
        }
        public void LoadBookOrders()
        {
            dataGridView1.DataSource = GUIBookOrders.GetBookOrdersByOrderId(_orderId);
            if (dataGridView1.Columns.Contains("Book") || dataGridView1.Columns.Contains("Order") || dataGridView1.Columns.Contains("updatedAt"))
            {
                dataGridView1.Columns.Remove("Book");
                dataGridView1.Columns.Remove("Order");
                dataGridView1.Columns.Remove("updatedAt");
            }
            dataGridView1.Columns["id"].HeaderText = "Mã CT Hóa đơn";
            dataGridView1.Columns["bookId"].HeaderText = "Mã sách";
            dataGridView1.Columns["orderId"].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns["quantity"].HeaderText = "Số lượng";
            dataGridView1.Columns["unitPrice"].HeaderText = "Đơn giá";
            dataGridView1.Columns["createdAt"].HeaderText = "Ngày lập";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }

    }
}
