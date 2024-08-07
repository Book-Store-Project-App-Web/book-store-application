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
    public partial class frmCategorie : Form
    {
        BLLCategory bllcategory = new BLLCategory();
        public frmCategorie()
        {
            InitializeComponent();
            this.Load += FrmCategorie_Load;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnNew.Click += BtnNew_Click;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string Search = txtSearch.Text.Trim();
            LoadCategories(Search);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateCategoryInput(out _))
            {
                MessageBox.Show("Vui lòng chọn thể loại muốn sửa thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txtIdCategory.Text, out int id))
            {
                var category = new Category
                {
                    id = id,
                    name = txtNameCategory.Text,
                    listCateId = (int)cbBoxListCategory.SelectedValue,
                    updatedAt = DateTime.Now
                };

                bllcategory.UpdateCategory(category);
                MessageBox.Show("Sửa thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadCategories();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!ValidateCategoryInput(out _))
            {
                MessageBox.Show("Vui lòng chọn thể loại sách muốn xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txtIdCategory.Text, out int id))
            {
                try
                {
                    bllcategory.DeleteCategory(id);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadCategories();  
                    ClearFields();   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateCategoryInput(out _))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn danh mục thể loại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var category = new Category
            {
                name = txtNameCategory.Text,
                listCateId = (int)cbBoxListCategory.SelectedValue,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now
            };

            bllcategory.AddCategory(category);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            LoadCategories();
            ClearFields();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtIdCategory.Text = row.Cells["id"].Value.ToString();
                txtNameCategory.Text = row.Cells["name"].Value.ToString();
                var listCateId = row.Cells["listCateId"].Value;
                cbBoxListCategory.SelectedValue = listCateId;
            }
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            LoadCategories();
            Load_Cate_category();
        }

        public void LoadCategories(string searchTerm = "")
        {
            var categories = bllcategory.LoadCategories();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                categories = categories.Where(c =>
            (!string.IsNullOrEmpty(c.name) && c.name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
            }

            dataGridView1.DataSource = categories;
            if (dataGridView1.Columns.Contains("List_Cate"))
            {
                dataGridView1.Columns.Remove("List_Cate");
            }
            dataGridView1.Columns["id"].HeaderText = "Mã thể loại";
            dataGridView1.Columns["listCateId"].HeaderText = "Danh mục thể loại";
            dataGridView1.Columns["name"].HeaderText = "Tên thể loại";
            dataGridView1.Columns["createdAt"].HeaderText = "Thời gian tạo";
            dataGridView1.Columns["updatedAt"].HeaderText = "Thời gian sửa";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridView1.Columns["updatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

        }

        public void Load_Cate_category()
        {
            var listCategories = bllcategory.Listcate_cate();
            cbBoxListCategory.DataSource = listCategories;
            cbBoxListCategory.DisplayMember = "Name";
            cbBoxListCategory.ValueMember = "id";
        }

        private void ClearFields()
        {
            txtIdCategory.Clear();
            txtNameCategory.Clear();
            cbBoxListCategory.SelectedIndex = -1;
        }
        private bool ValidateCategoryInput(out int id)
        {
            id = 0;

            if (string.IsNullOrWhiteSpace(txtNameCategory.Text) || cbBoxListCategory.SelectedValue == null)
            {
                return false;
            }

            return true;
        }
    }
}
