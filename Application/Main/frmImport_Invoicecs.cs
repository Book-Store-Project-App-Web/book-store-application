using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Main
{
    public partial class frmImport_Invoicecs : Form
    {
        BLLSuppliers GUISuppeliers = new BLLSuppliers();
        BLLBook GUIBooks = new BLLBook();
        BLLBook_ImportInvoice GUIBook_ImportInvoice = new BLLBook_ImportInvoice();
        BLLImport_Invoice GUIImport_Invoice = new BLLImport_Invoice();
        BLLUser GUIUser = new BLLUser();
        private int loggedInUserId;

        public frmImport_Invoicecs(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            this.Load += FrmImport_Invoicecs_Load;
            this.dataGvBook_Import.SelectionChanged += DataGvBook_Import_SelectionChanged;
            this.cbBoxSupplier.SelectedValueChanged += CbBoxSupplier_SelectedValueChanged;
            this.cbBoxIdBook.SelectedValueChanged += CbBoxIdBook_SelectedValueChanged;
            this.txtQuantity.TextChanged += TxtQuantity_TextChanged;
            this.txtUnitPriceBook.TextChanged += TxtUnitPriceBook_TextChanged;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnSave.Click += BtnSave_Click;
        }

        private void DataGvBook_Import_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGvBook_Import.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGvBook_Import.SelectedRows[0];

                cbBoxIdBook.SelectedValue = selectedRow.Cells["idBook"].Value;
                txtNameBook.Text = selectedRow.Cells["nameBook"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["quantity"].Value.ToString();
                txtUnitPriceBook.Text = selectedRow.Cells["unitPrice"].Value.ToString();
                txtTotalPrice.Text = selectedRow.Cells["totalPrice"].Value.ToString();
            }
        }

        private void TxtUnitPriceBook_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Import_Invoice importInvoice = new Import_Invoice
            {
                userId = int.Parse(txtIdUser.Text),
                supplier = txtNameSupplier.Text,
                totalInvoice = UpdateTotalPriceAll(),
                createdAt = DateTime.Now
            };

            // Lưu ImportInvoice vào cơ sở dữ liệu và lấy ID của nó
            int importInvoiceId = GUIImport_Invoice.AddImportInvoice(importInvoice);
            // Lưu từng dòng từ DataGridView vào bảng Book_ImportInvoices
            foreach (DataGridViewRow row in dataGvBook_Import.Rows)
            {
                if (row.Cells["idBook"].Value != null && row.Cells["quantity"].Value != null && row.Cells["unitPrice"].Value != null)
                {
                    Book_ImportInvoice bookImportInvoice = new Book_ImportInvoice
                    {
                        importInvoiceId = importInvoiceId,
                        bookId = int.Parse(row.Cells["idBook"].Value.ToString()),
                        quantity = int.Parse(row.Cells["quantity"].Value.ToString()),
                        unitPrice = double.Parse(row.Cells["unitPrice"].Value.ToString()),
                        createdAt = DateTime.Now
                    };

                    // Lưu Book_ImportInvoice vào cơ sở dữ liệu
                    GUIBook_ImportInvoice.AddBook_ImportInvoice(bookImportInvoice);
                }
            }
            MessageBox.Show("Lưu thành công");
            // Xóa dữ liệu trên DataGridView
            dataGvBook_Import.Rows.Clear();

            // Xóa các TextBox thông tin sách
            txtNameBook.Clear();
            txtQuantity.Clear();
            txtUnitPriceBook.Clear();
            txtTotalPrice.Clear();
            txtNameSupplier.Clear();
            txtAddressSupplier.Clear();
            txtPhoneSupplier.Clear();
 
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGvBook_Import.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGvBook_Import.SelectedRows[0];

                // Cập nhật giá trị của dòng đã chọn
                selectedRow.Cells["idBook"].Value = cbBoxIdBook.SelectedValue;
                selectedRow.Cells["nameBook"].Value = txtNameBook.Text;
                selectedRow.Cells["quantity"].Value = txtQuantity.Text;
                selectedRow.Cells["unitPrice"].Value = txtUnitPriceBook.Text;

                // Tính toán lại tổng tiền
                double unitPrice = double.Parse(txtUnitPriceBook.Text);
                int quantity = int.Parse(txtQuantity.Text);
                double totalPrice = unitPrice * quantity;
                txtTotalPrice.Text = totalPrice.ToString();
                selectedRow.Cells["totalPrice"].Value = totalPrice;

                // Cập nhật tổng tiền trong textbox tổng
                UpdateTotalPrice();
                UpdateTotalPriceAll();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGvBook_Import.SelectedRows.Count > 0)
            {
                // Xóa tất cả các dòng đã chọn
                foreach (DataGridViewRow row in dataGvBook_Import.SelectedRows)
                {
                   if (!row.IsNewRow) // Đảm bảo không xóa dòng mới
                   {
                        dataGvBook_Import.Rows.Remove(row);
                   }
                }
                    UpdateTotalPrice();
                    UpdateTotalPriceAll();
             }
            else
            {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu có hợp lệ không
            if (cbBoxIdBook.SelectedValue is int bookId &&
                int.TryParse(txtQuantity.Text, out int quantity) &&
                double.TryParse(txtUnitPriceBook.Text, out double unitPrice))
            {
                // Tính tổng giá
                double totalPrice = quantity * unitPrice;

                bool bookExists = false;

                // Duyệt qua các hàng của DataGridView để kiểm tra idBook có tồn tại không
                foreach (DataGridViewRow row in dataGvBook_Import.Rows)
                {
                    if (row.Cells[0].Value is int existingBookId && existingBookId == bookId)
                    {
                        // Nếu tồn tại, cập nhật số lượng và tổng giá
                        int existingQuantity = Convert.ToInt32(row.Cells[2].Value);
                        double existingTotalPrice = Convert.ToDouble(row.Cells[4].Value);

                        // Cập nhật số lượng và tổng tiền
                        existingQuantity += quantity;
                        existingTotalPrice = existingQuantity * unitPrice;

                        row.Cells[2].Value = existingQuantity;
                        row.Cells[4].Value = existingTotalPrice;

                        bookExists = true;
                        break;
                    }
                }

                if (!bookExists)
                {
                    // Nếu không tồn tại, thêm một dòng mới
                    var row = new DataGridViewRow();
                    row.CreateCells(dataGvBook_Import);

                    row.Cells[0].Value = bookId;
                    row.Cells[1].Value = txtNameBook.Text;
                    row.Cells[2].Value = quantity;
                    row.Cells[3].Value = unitPrice;
                    row.Cells[4].Value = totalPrice;

                    // Thêm dòng mới vào DataGridView
                    dataGvBook_Import.Rows.Add(row);
                }

                // Xóa dữ liệu đầu vào sau khi thêm
                cbBoxIdBook.SelectedIndex = -1;
                txtNameBook.Clear();
                txtQuantity.Clear();
                txtUnitPriceBook.Clear();
                txtTotalPrice.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập liệu.");
            }
            UpdateTotalPriceAll();
        }

        private void CbBoxIdBook_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBoxIdBook.SelectedValue is int idSelectBook)
            {
                Book selectedBook = GUIBooks.GetBookById(idSelectBook);
                Book_ImportInvoice selectBook_ImportInvoice = GUIBook_ImportInvoice.GetbyIdBook(idSelectBook);
                if (selectedBook != null)
                {
                    txtNameBook.Text = selectedBook.name;
                }
                if (selectBook_ImportInvoice != null)
                {
                    txtUnitPriceBook.Text = selectBook_ImportInvoice.unitPrice.ToString();
                }
            }
        }

        private void CbBoxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBoxSupplier.SelectedValue is int selectedIdSupplier)
            {
                Supplier selectedSupplier = GUISuppeliers.GetSupplierById(selectedIdSupplier);
                if (selectedSupplier != null)
                {
                    txtNameSupplier.Text = selectedSupplier.name;
                    txtAddressSupplier.Text = selectedSupplier.address;
                    txtPhoneSupplier.Text = selectedSupplier.phone;

                }
                List<Book> books = GUIBooks.GetBookByIdSupplier(selectedIdSupplier);
                cbBoxIdBook.DataSource = books;
                cbBoxIdBook.DisplayMember = "id";
                cbBoxIdBook.ValueMember = "id";
            }
        }

        private void FrmImport_Invoicecs_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            LoadComboBoxSuppliers();
            LoadStaff();
        }

        public void LoadStaff()
        {
            var loggedInUser = GUIUser.GetUserById(loggedInUserId);
            if (loggedInUser != null)
            {
                txtIdUser.Text = loggedInUser.id.ToString();
                txtFullName.Text = $"{loggedInUser.firstName} {loggedInUser.lastName}";
                txtPhone.Text = loggedInUser.phone;
            }

        }

        public void LoadSuppliers()
        {
            dataGvSuppliers.DataSource = GUISuppeliers.ListSuppliers();
            var unwantedColumns = new[] { "phone", "address", "createdAt", "updatedAt" };
            foreach (var column in unwantedColumns)
            {
                if (dataGvSuppliers.Columns.Contains(column))
                {
                    dataGvSuppliers.Columns.Remove(column);
                }
            }

            dataGvSuppliers.Columns["id"].HeaderText = "Mã NCC";
            dataGvSuppliers.Columns["name"].HeaderText = "Tên NCC";
        }

        public void LoadComboBoxSuppliers()
        {
            cbBoxSupplier.DataSource = GUISuppeliers.ListSuppliers();
            cbBoxSupplier.DisplayMember = "name";
            cbBoxSupplier.ValueMember = "id";
        }

        public void UpdateTotalPrice()
        {
            if (double.TryParse(txtQuantity.Text, out double quantity) &&
               double.TryParse(txtUnitPriceBook.Text, out double unitPrice))
            {
                double totalPrice = quantity * unitPrice;
                txtTotalPrice.Text = totalPrice.ToString("F3");
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        public double UpdateTotalPriceAll()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGvBook_Import.Rows)
            {
                if (row.Cells["totalPrice"].Value != null)
                {
                    total += Convert.ToDouble(row.Cells["totalPrice"].Value);
                }
            }
            lbTotalAll.Text = total.ToString("N0") + "₫";
            return total;
        }

    }
}
