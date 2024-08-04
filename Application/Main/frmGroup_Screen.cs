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

        private void FrmGroup_Screen_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            dataGridView1.DataSource = bllGr.LoadGroup();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView2.DataSource = bllGr.LoadGroupScreen(2);
            DataGridViewCheckBoxColumn isRoleColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "isRole",
                HeaderText = "Is Role",
                Name = "isRole",  // Đảm bảo tên cột đúng
                ReadOnly = false  // Cột checkbox cho phép chỉnh sửa
            };
            dataGridView2.Columns.Add(isRoleColumn);
            dataGridView2.Columns["isRole"].Visible = false;
            dataGridView2.CellContentClick += DataGridView2_CellContentClick;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["isRole"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView2.Rows[e.RowIndex].Cells["isRole"];
                checkBoxCell.Value = !(bool)checkBoxCell.Value;
            }
        }

        private void ConfigureDataGridView()
        {
            
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
