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
        BLLInvoice bllInvoice = new BLLInvoice();
        BLLUser bllUser = new BLLUser();
        public frmInvoice()
        {
            InitializeComponent();
            this.Load += FrmInvoice_Load;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnRefresh.Click += BtnRefresh_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnViewDetail.Click += BtnViewDetail_Click;
        }

        private void BtnViewDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var orderId = (int)selectedRow.Cells["id"].Value;

                var detailForm = new frmInvoiceDetail(orderId);
                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết.");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var invoiceId = (int)selectedRow.Cells["id"].Value;
                var updatedOrder = new Order
                {
                    id = invoiceId,
                    fullName = txtFullname.Text,
                    phone = txtPhone.Text,
                    address = txtAddress.Text,
                    totalOrderPrice = double.Parse(txtTotalPrice.Text),
                    userId = (int)cboBoxIdUser.SelectedValue,
                    updatedAt = DateTime.Now
                };
                bllInvoice.UpdateInvoice(updatedOrder);
                MessageBox.Show("Hóa đơn đã được cập nhật thành công.");
                RefreshInvoiceList();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để cập nhật!");
            }
            
        }

        public void RefreshInvoiceList()
        {
            txt_Id_Invoice.Clear();
            txtFullname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtTotalPrice.Clear();
            cboBoxIdUser.SelectedIndex = -1;

            dataGridView1.ClearSelection();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInvoiceList();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            var invoiceId = (int)selectedRow.Cells["id"].Value; 

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bllInvoice.DeleteInvoice(invoiceId);
                MessageBox.Show("Hóa đơn đã được xóa thành công.");
                RefreshInvoiceList();
                LoadInvoice();
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                !decimal.TryParse(txtTotalPrice.Text, out var totalOrderPrice) ||
                cboBoxIdUser.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            var invoice = new Order
            {
                fullName = txtFullname.Text,
                phone = txtPhone.Text,
                address = txtAddress.Text,
                userId = (int)cboBoxIdUser.SelectedValue,
                totalOrderPrice = Convert.ToDouble(txtTotalPrice.Text),
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now
            };

            bllInvoice.AddInvoice(invoice);
            RefreshInvoiceList();
            LoadInvoice();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            bool isRowSelected = dataGridView1.SelectedRows.Count > 0;

            btnCreate.Enabled = !isRowSelected;

            UpdateButtonStates();

            if (isRowSelected)
            {
                var row = dataGridView1.SelectedRows[0];
                txt_Id_Invoice.Text = row.Cells["id"].Value.ToString();
                var idUser = row.Cells["userId"].Value;
                cboBoxIdUser.SelectedValue = idUser;
                txtFullname.Text = row.Cells["fullname"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtTotalPrice.Text = row.Cells["totalOrderPrice"].Value.ToString();
            }
            else
            {
                RefreshInvoiceList();
            }
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            LoadInvoice();
            LoadIdUser();
        }

        public void LoadInvoice()
        {
            dataGridView1.DataSource = bllInvoice.LoadInvoice();
            if (dataGridView1.Columns.Contains("User"))
            {
                dataGridView1.Columns.Remove("User");
            }
            dataGridView1.Columns["id"].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns["userId"].HeaderText = "Mã khách hàng";
            dataGridView1.Columns["fullname"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["totalOrderPrice"].HeaderText = "Tổng tiền";
            dataGridView1.Columns["createdAt"].HeaderText = "Ngày lập";
            dataGridView1.Columns["updatedAt"].HeaderText = "Ngày cập nhật";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridView1.Columns["updatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

        }
        public void LoadIdUser()
        {
            cboBoxIdUser.DataSource = bllUser.LoadUser();
            cboBoxIdUser.ValueMember = "id";
        }
        private void UpdateButtonStates()
        {
            bool isRowSelected = dataGridView1.SelectedRows.Count > 0;

            btnDelete.Enabled = isRowSelected;
            btnEdit.Enabled = isRowSelected;
            btnRefresh.Enabled = isRowSelected;
            btnViewDetail.Enabled = isRowSelected; // Nếu có nút Xem Chi Tiết
        }
    }
}
