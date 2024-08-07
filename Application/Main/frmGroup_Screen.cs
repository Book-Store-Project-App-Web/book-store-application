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
    public partial class frmGroup_Screen : Form
    {
        BLLGroup bllGr = new BLLGroup();

        public frmGroup_Screen()
        {
            InitializeComponent();
            this.Load += FrmGroup_Screen_Load;
        }
        void LoadDG2()
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id"].Value;
            List<dynamic> list_dynamic = bllGr.LoadGroupScreen(id);
            var group_screen = bllGr.ConvertToGroupScreenList(list_dynamic);
            dataGridView2.DataSource = group_screen;
        }
        private void FrmGroup_Screen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllGr.LoadGroup();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            LoadDG2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int groupId =(int)dataGridView1.CurrentRow.Cells["id"].Value;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                int screenId = Convert.ToInt32(dataGridView2.Rows[i].Cells["screenId"].Value);
                bool isRole = (bool)dataGridView2.Rows[i].Cells["isRole"].Value;
                if(bllGr.CheckIsRoleExist(groupId, screenId) != null)
                {
                    bllGr.UpdateIsRole(groupId, screenId, isRole);
                }
                else
                {
                    bllGr.CreateRole(groupId, screenId,isRole);
                    MessageBox.Show("Thêm role thành công");
                }
            }
            MessageBox.Show("Cập nhật role thành công");

        }
    }
}
