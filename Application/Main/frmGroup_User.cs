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
    public partial class frmGroup_User : Form
    {
        BLLUser blluser = new BLLUser();
        BLLGroup bllGr = new BLLGroup();
        public frmGroup_User()
        {
            InitializeComponent();
            this.Load += FrmGroup_User_Load;
        }
        void ReLoad()
        {
            int groupId = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            dataGridView2.DataSource = bllGr.LoadGroup_User(groupId);
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                button2.Enabled = true;
                ReLoad();
            }
        }

        private void FrmGroup_User_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = blluser.LoadUserDK();
            button2.Enabled = false;
            comboBox1.DataSource = bllGr.LoadGroup();
            comboBox1.DisplayMember = "groupName";
            comboBox1.ValueMember = "id";
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            bool kq = bllGr.CheckExistGU(groupId, userId);
            if (kq == false)
            {
                bllGr.CreateGU(groupId, userId);
                MessageBox.Show("Thêm thành công");
                ReLoad();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int groupId = Convert.ToInt32(dataGridView2.CurrentRow.Cells["groupId"].Value.ToString());
            int userId = Convert.ToInt32(dataGridView2.CurrentRow.Cells["userId"].Value.ToString());
            if (bllGr.DeleteGU(groupId, userId) != null)
            {
                MessageBox.Show("Xóa thành công");
                ReLoad();
            }
        }
    }
}
