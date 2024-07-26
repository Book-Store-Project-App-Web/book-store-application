using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Main
{
    public partial class frmLogin : Form
    {
        Loginclass config = new Loginclass();
        //private SqlConnection connection;

        public frmLogin()
        {
            InitializeComponent();
            //InitializeMySqlConnection();
            string connect = Properties.Settings.Default.conn;
            connect = new Loginclass();
            this.chkBoxShowpassword.CheckedChanged += ChkBoxShowpassword_CheckedChanged;
            this.btnSignIn.Click += BtnSignIn_Click;
            this.Load += FrmLogin_Load;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int resultConfig = config.Check_config(connect);

            //if (string.IsNullOrEmpty(email.Trim()))
            //{
            //    MessageBox.Show("");
            //    this.txtEmail.Focus();
            //    return;
            //}
            //if (string.IsNullOrEmpty(password.Trim()))
            //{
            //    MessageBox.Show("");
            //    this.txtPassword.Focus();
            //    return;
            //}

            if (resultConfig == 0)
            {
                MessageBox.Show("Chuỗi cấu hình tồn tại");// Xử lý cấu hình
                //ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (resultConfig == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (resultConfig == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            
        }
        public void ProcessLogin()
        {
            Utilities.LoginResult result;
            result = config.Check_User(txtEmail.Text, txtPassword.Text);
            // Wrong username or pass
            if (result == Utilities.LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + label1.Text + " Hoặc " +
                label2.Text);
                return;
            }
            // Account had been disabled
            else if (result == Utilities.LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            this.Visible = false;       
        }

        private void ChkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != null)
            {
                if (chkBoxShowpassword.Checked)
                {
                    txtPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }

        public void ProcessConfig()
        {
            Program.cofigFrom.Show();
        }

        //private void InitializeMySqlConnection()
        //{

        //    string connectionString = @"Data Source=LAPTOP-3JB6IQD2;Initial Catalog=dsdsdsd;Persist Security Info=True;User ID=sa;Password =sa123";
        //    connection = new SqlConnection(connectionString);

        //    try
        //    {
        //        connection.Open();
        //        MessageBox.Show("Kết nối thành công!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Kết nối thất bại" + ex.Message);
        //    }
        //}
    }
}
