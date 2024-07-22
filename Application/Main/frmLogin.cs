﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class frmLogin : Form
    {
        private SqlConnection connection;

        public frmLogin()
        {
            InitializeComponent();
            InitializeMySqlConnection();
            this.chkBoxShowpassword.CheckedChanged += ChkBoxShowpassword_CheckedChanged;
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

        private void InitializeMySqlConnection()
        {
            string connectionString = @"Data Source=LAPTOP-3JB6IQD2;Initial Catalog=book;Persist Security Info=True;User ID=sa;Password =sa123";
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex.Message);
            }
        }
    }
}
