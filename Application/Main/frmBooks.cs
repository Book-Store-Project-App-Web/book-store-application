using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using BLL;
using DTO;
using Utilities;

namespace Main
{
    public partial class frmBooks : Form
    {
        BLLBook bllBook = new BLLBook();
        Library lb = new Library();
        private Cloudinary _cloudinary;

        private ErrorProvider errorProvider;
        public frmBooks()
        {
            InitializeComponent();
            InitializeCloudinary();
            this.Load += FrmBooks_Load;
            this.btnSelectImage.Click += BtnSelectImage_Click;
            this.btnAddBook.Click += BtnAddBook_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnUpdateBook.Click += BtnUpdateBook_Click;
            this.btnDeleteBook.Click += BtnDeleteBook_Click;
            this.dataGridViewBook.CellClick += DataGridViewBook_CellClick; ;
            this.btnSearch.Click += BtnSearch_Click;
            errorProvider = new ErrorProvider();
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (searchTerm != string.Empty)
            {
                LoadGridView(searchTerm);
            }
            else
            {
                LoadGridView();
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.CurrentRow == null || dataGridViewBook.CurrentRow.Cells["id"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin sách muốn xóa!");
                return;
            }

            string bookId = dataGridViewBook.CurrentRow.Cells["id"].Value.ToString();
            bool isDeleted = bllBook.DeleteBook(Convert.ToInt32(bookId));
            if (isDeleted)
            {
                MessageBox.Show("Xóa sách thành công!");
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách để xóa!");
            }
        }
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if (lb.AreControlsValid(this, errorProvider, "txtName", "txtPrice", "txtPageNumber", "txtPublishingYear", "txtStock", "txtAuthor"))
            {
                string bookId = dataGridViewBook.CurrentRow.Cells["id"].Value.ToString();
                string name = txtName.Text;
                string author = txtAuthor.Text;
                int supplierId = Convert.ToInt32(cboSupplier.SelectedValue);
                int categoryId = Convert.ToInt32(cboCate.SelectedValue);
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                int pageNumber = Convert.ToInt32(txtPageNumber.Text);
                int publishingYear = Convert.ToInt32(txtPublishingYear.Text);

                var _book = new Book
                {
                    name = name,
                    supplierId = supplierId,
                    categoryId = categoryId,
                    price = price,
                    discount = discount,
                    stock = stock,
                    author = author,
                    pageNumber = pageNumber,
                    publishingYear = publishingYear
                };

                var isUpdated = bllBook.UpdateBook(Convert.ToInt32(bookId), _book);
                if (isUpdated != null)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadGridView();
                }
                
            }
        }

        void LoadGridView(string searchTerm = null)
        {
            SetControlsEnabled(false);
            var books = bllBook.ListBooks();
            if (!string.IsNullOrEmpty(searchTerm))
            {
               
                books = bllBook.SearchBook(searchTerm);
            }
            dataGridViewBook.DataSource = books;
            if(dataGridViewBook.Columns["Image"] != null)
            {
                dataGridViewBook.Columns["Image"].Visible = false;
            }

            if (dataGridViewBook.Columns["ImageColumn"] == null)
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                {
                    HeaderText = "Image",
                    Name = "ImageColumn",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };

                dataGridViewBook.Columns.Insert(0, imageColumn);
            }

            foreach (DataGridViewRow row in dataGridViewBook.Rows)
            {
                if (row.Cells["Image"] != null && row.Cells["Image"].Value != null)
                {
                    row.Cells["ImageColumn"].Value = Image.FromStream(new System.Net.WebClient().OpenRead(row.Cells["Image"].Value.ToString()));
                }
            }

            cboCate.DataSource = bllBook.ListCateBook();
            cboSupplier.DataSource = bllBook.ListSupBook();
        }
        void ClearTextBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control.HasChildren)
                {
                    ClearTextBox(control);
                }
            }
        }
        private void DataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteBook.Enabled = true;
            btnUpdateBook.Enabled = true;
            DataGridViewRow selectedRow = dataGridViewBook.CurrentRow;
            txtName.Text = selectedRow.Cells["name"].Value?.ToString();
            txtPrice.Text = selectedRow.Cells["price"].Value?.ToString();
            txtPageNumber.Text = selectedRow.Cells["pageNumber"].Value?.ToString();
            txtPublishingYear.Text = selectedRow.Cells["publishingYear"].Value?.ToString();
            txtStock.Text = selectedRow.Cells["stock"].Value?.ToString();
            txtAuthor.Text = selectedRow.Cells["author"].Value?.ToString();
            txtDiscount.Text = selectedRow.Cells["discount"].Value?.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lb.AreControlsValid(this, errorProvider, "txtName", "txtPrice", "txtPageNumber", "txtPublishingYear", "txtStock", "txtAuthor"))
            {
                string name = txtName.Text;
                int supplierId = Convert.ToInt32(cboSupplier.SelectedValue);
                int categoryId = Convert.ToInt32(cboCate.SelectedValue);
                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int stock = Convert.ToInt32(txtStock.Text);
                string author = txtAuthor.Text;
                int pageNumber = Convert.ToInt32(txtPageNumber.Text);
                int publishingYear = Convert.ToInt32(txtPublishingYear.Text);
                var book = bllBook.CheckExistBook(name);
                if (book != null)
                {
                    MessageBox.Show("Sách đã tồn tại !");
                    return;
                }

                if (pictureBox1.Image != null && pictureBox1.Tag != null )
                {
                    string filePath = pictureBox1.Tag.ToString();
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(filePath)
                    };

                    var uploadResult = _cloudinary.Upload(uploadParams);
                    string image = uploadResult.SecureUrl.ToString();

                    var _book = new Book
                    {
                        image = image,
                        name = name,
                        supplierId = supplierId,
                        categoryId = categoryId,
                        price = price,
                        discount = discount,
                        stock = stock,
                        author = author,
                        pageNumber = pageNumber,
                        publishingYear = publishingYear
                    };

                    var newBook = bllBook.CreatNewBook(_book);
                    if (newBook != null)
                    {
                        MessageBox.Show("Thêm sách thành công");
                        LoadGridView();
                        ClearTextBox(this);
                    }
                } 
                else
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh !!! ");
                }
            }                    
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
        private void SetControlsEnabled(bool enabled)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox || control is Button)
                {
                    if (control != btnAddBook)
                    {
                        control.Enabled = enabled;
                    }
                }
            }
        }
        private void InitializeCloudinary()
        {
            var account = new Account(
                "datdev",
                "395219759456727",
                "M7AuVPyhlLN7Uj23BFtVrqrppIk");

            _cloudinary = new Cloudinary(account);
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(true);
            btnDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
            ClearTextBox(this);
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.webp)|*.jpg;*.jpeg;*.png;*.webp";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.Tag = filePath;
            }
        }
    }
}
