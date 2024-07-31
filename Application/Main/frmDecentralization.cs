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
    public partial class frmDecentralization : Form
    {
        BLLUser bllUser = new BLLUser();
        public frmDecentralization()
        {
            InitializeComponent();
            this.Load += FrnDecentralization_Load;
        }

        private void FrnDecentralization_Load(object sender, EventArgs e)
        {
            User();
        }

        public void User()
        {
            dataGVUser.DataSource = bllUser.LoadUserDK();
        }
    }
}
