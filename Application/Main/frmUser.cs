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
    public partial class frmUser : Form
    {
        BLLUser blluser = new BLLUser();
        public frmUser()
        {
            InitializeComponent();
            this.Load += FrmUser_Load;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnRefresh.Click += btnRefresh_Click;
            this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            LoadUserList(searchTerm);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtIdUser.Text = row.Cells["id"].Value.ToString();
                txtFistName.Text = row.Cells["firstName"].Value.ToString();
                txtLastName.Text = row.Cells["lastName"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                var sex = row.Cells["sex"].Value.ToString();
                cboBoxSex.SelectedItem = sex;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                int id = int.Parse(row.Cells["id"].Value.ToString());
                var user = new User
                {
                    id = id,
                    firstName = txtFistName.Text,
                    lastName = txtLastName.Text,
                    phone = txtPhone.Text,
                    email = txtEmail.Text,
                    password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text),
                    sex = cboBoxSex.SelectedItem.ToString(),
                    updatedAt = DateTime.Now
                };

                blluser.UpdateUser(user);
                LoadUserList();
                MessageBox.Show("Cập nhật người dùng thành công!");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để cập nhật!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                int id = int.Parse(row.Cells["id"].Value.ToString());
                blluser.DeleteUser(id);
                LoadUserList();
                MessageBox.Show("Xóa người dùng thành công!");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn người dùng để xóa!");
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                firstName = txtFistName.Text,
                lastName = txtLastName.Text,
                phone = txtPhone.Text,
                email = txtEmail.Text,
                password = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text),
                sex = cboBoxSex.SelectedItem.ToString(),
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now
             };
    
            blluser.AddUser(user);
            LoadUserList();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            LoadSexComboBox();
            LoadUserList();
        }

        public void LoadUserList(string searchTerm = "")
        {
            var users = blluser.LoadUser(); 

            if (!string.IsNullOrEmpty(searchTerm))
            {
                users = users.Where(u =>
            (!string.IsNullOrEmpty(u.firstName) && u.firstName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (!string.IsNullOrEmpty(u.lastName) && u.lastName.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (!string.IsNullOrEmpty(u.email) && u.email.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
            }

            dataGridView1.DataSource = users;
            dataGridView1.Columns["id"].HeaderText = "Mã người dùng";
            dataGridView1.Columns["firstName"].HeaderText = "Tên riêng";
            dataGridView1.Columns["lastName"].HeaderText = "Họ";
            dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["password"].HeaderText = "Mật khẩu";
            dataGridView1.Columns["sex"].HeaderText = "Giới tính";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridView1.Columns["updatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

        }
        private void LoadSexComboBox()
        {
            cboBoxSex.Items.Add("Nam");
            cboBoxSex.Items.Add("Nữ");
        }
        private void ClearInputFields()
        {
            txtFistName.Clear();
            txtLastName.Clear();
            txtIdUser.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cboBoxSex.SelectedIndex = -1;
        }
    }
}
