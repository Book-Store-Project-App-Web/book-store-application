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
        private BLL_Login bll_login;
        public frmLogin()
        {
            InitializeComponent();
            bll_login = new BLL_Login();
            this.btnSignIn.Click += BtnSignIn_Click;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (bll_login.ValidateUser(email, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                Program.SystemForm.Show();
            }
            else
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng.");
            }
        }

    }
}
