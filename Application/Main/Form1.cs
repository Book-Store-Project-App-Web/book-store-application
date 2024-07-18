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

namespace Main
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeMySqlConnection()
        {
            string connectionString = @"Data Source=DESKTOP-8I1VIDD\SQLEXPRESS;Initial Catalog=Module_DN;Persist Security Info=True;User ID=sa;Password =123";
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
        private void button1_Click(object sender, EventArgs e)
        {
            InitializeMySqlConnection();
        }
    }
}
