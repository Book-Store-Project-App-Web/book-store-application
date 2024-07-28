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
        BLLUser bllUser = new BLLUser();
        public frmLogin()
        {
            InitializeComponent();
            this.btnSignIn.Click += BtnSignIn_Click;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            //bllUser.logInUser(email, password);

            try
            {
                string loginResult = bllUser.logInUser(email, password);
                MessageBox.Show(loginResult);

                if (loginResult == "Đăng nhập thành công")
                {
                    Program.SystemForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
