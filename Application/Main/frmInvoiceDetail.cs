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
        BLLInvoice GUIInvoice = new BLLInvoice();
        BLLBook GUIBook = new BLLBook();
        public frmInvoiceDetail(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            this.Load += FrmInvoiceDetail_Load;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var bookId = Convert.ToInt32(selectedRow.Cells["bookId"].Value);
                var book = GUIBook.ListBooks().FirstOrDefault(b => b.id == bookId);
                if (book != null)
                {
                    txtIdBook.Text = book.id.ToString();
                    txtNameBook.Text = book.name;
                    txtBookPrice.Text = book.price.ToString();
                    txtPurchaseQuantity.Text = selectedRow.Cells["quantity"].Value.ToString();
                }
            }
        }

        private void FrmInvoiceDetail_Load(object sender, EventArgs e)
        {
            LoadBookOrders();
            LoadOrderDetails();
        }
        public void LoadBookOrders()
        {
            dataGridView1.DataSource = GUIBookOrders.GetBookOrdersByOrderId(_orderId);
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            var unwantedColumns = new[] { "Book", "Order", "updatedAt" };
            foreach (var column in unwantedColumns)
            {
                if (dataGridView1.Columns.Contains(column))
                {
                    dataGridView1.Columns.Remove(column);
                }
            }

            dataGridView1.Columns["id"].HeaderText = "Mã CT Hóa đơn";
            dataGridView1.Columns["bookId"].HeaderText = "Mã sách";
            dataGridView1.Columns["orderId"].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns["quantity"].HeaderText = "Số lượng";
            dataGridView1.Columns["unitPrice"].HeaderText = "Đơn giá";
            dataGridView1.Columns["createdAt"].HeaderText = "Ngày lập";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }
        private void LoadOrderDetails()
        {
            var order = GUIInvoice.LoadInvoice().FirstOrDefault(o => o.id == _orderId);
            if (order != null)
            {
                txtIdInvoice.Text = order.id.ToString();
                txtIdUser.Text = order.userId.ToString();
                txtFullName.Text = order.fullName;
                txtAddress.Text = order.address;
                txtPhone.Text = order.phone;
                txtTotalPrice.Text = order.totalOrderPrice.ToString();
                txtDateCreate.Text = order.createdAt.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }


    }
}
