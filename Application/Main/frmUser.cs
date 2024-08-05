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
using Utilities;
using DTO;

namespace Main
{
    public partial class frmUser : Form
    {
        BLLUser blluser = new BLLUser();
        Library lb = new Library();
        private ErrorProvider errorProvider;

        public frmUser()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            this.Load += FrmUser_Load;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnRefresh.Click += btnRefresh_Click;
            this.dataGridView1.CellClick += DataGridView1_CellClick;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtIdUser.Text = row.Cells["id"].Value?.ToString();
            txtLastName.Text = row.Cells["lastName"].Value?.ToString();
            txtFirstName.Text = row.Cells["firstName"].Value?.ToString();
            txtPhone.Text = row.Cells["phone"].Value?.ToString();
            txtEmail.Text = row.Cells["email"].Value?.ToString();
            var sex = row.Cells["sex"].Value;
            cboBoxSex.SelectedItem = sex;
            txtPassword.Enabled = false;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            LoadUserList(searchTerm);
        }

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            ClearInputFields();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                int id = int.Parse(row.Cells["id"].Value.ToString());
                if (cboBoxSex.SelectedItem == null)
                {
                    MessageBox.Show("Phải chọn giới tính !!!");
                    return;
                }
                var user = new User
                {
                    firstName = txtLastName.Text,
                    lastName = txtFirstName.Text,
                    phone = txtPhone.Text,
                    email = txtEmail.Text,
                    sex = cboBoxSex.SelectedItem.ToString()
                };

                blluser.UpdateUser(id,user);
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
            if (lb.AreControlsValid(this,errorProvider, "txtLastName", "txtFirstName", "txtPhone", "txtEmail", "txtPassword"))
            {
                var user = new User
                {
                    firstName = txtFirstName.Text,
                    lastName = txtLastName.Text,
                    phone = txtPhone.Text,
                    email = txtEmail.Text,
                    password = txtPassword.Text,
                    sex = cboBoxSex.SelectedItem.ToString()
                };

                blluser.AddUser(user);
                MessageBox.Show("Thêm người dùng thành công");
                LoadUserList();
            }
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
                users = blluser.SearchUser(searchTerm);
            }
            dataGridView1.DataSource = users;
            dataGridView1.Columns["id"].HeaderText = "Mã người dùng";
            dataGridView1.Columns["firstName"].HeaderText = "Họ";
            dataGridView1.Columns["lastName"].HeaderText = "Tên riêng";
            dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["sex"].HeaderText = "Giới tính";
            dataGridView1.Columns["createdAt"].HeaderText = "Ngày tạo";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }
        private void LoadSexComboBox()
        {
            cboBoxSex.Items.Add("Nam");
            cboBoxSex.Items.Add("Nữ");
        }
        private void ClearInputFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtIdUser.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            //txtPassword.Clear();
            cboBoxSex.SelectedIndex = -1;
        }
    }
}
