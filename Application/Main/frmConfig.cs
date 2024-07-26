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

namespace Main
{
    public partial class frmConfig : Form
    {
        private string connectionString;
        private Loginclass loginClass;
        public frmConfig()
        {
            InitializeComponent();
            connectionString = Properties.Settings.Default.conn;
            loginClass = new Loginclass(connectionString);

            this.btnSave.Click += BtnSave_Click;
            this.cboSeverName.DropDown += CboSeverName_DropDown;
            this.cboDatabase.DropDown += CboDatabase_DropDown;
        }

        private void CboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.DataSource = loginClass.GetDBName(cboSeverName.Text, txtUsername.Text, txtPassword.Text);
            cboDatabase.DisplayMember = "name";
        }

        private void CboSeverName_DropDown(object sender, EventArgs e)
        {
            cboSeverName.DataSource = loginClass.getServerName();
            cboSeverName.DisplayMember = "ServerName";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.conn = "Data Source=" + cboSeverName.Text + ";Initial Catalog=" + cboDatabase.Text + ";User ID=" + txtUsername.Text + ";pwd=" + txtPassword.Text + ""; ;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
