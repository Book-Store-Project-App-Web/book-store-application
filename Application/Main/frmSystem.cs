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
using DTO;

namespace Main
{
    public partial class frmSystem : Form
    {
        private int loggedInUserId;
        BLLUser bllUser = new BLLUser();
        BLLGroup bllGroup = new BLLGroup();

        public frmSystem(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
            this.FormClosing += FrmSystem_FormClosing;
            this.Load += FrmSystem_Load;
            this.BookToolStripMenuItem.Click += BookToolStripMenuItem_Click;
            this.CategoriesToolStripMenuItem.Click += CategoriesToolStripMenuItem_Click;
            this.ImportInvoiceToolStripMenuItem.Click += ImportInvoiceToolStripMenuItem_Click;
            this.InvoiceToolStripMenuItem.Click += InvoiceToolStripMenuItem_Click;
            this.AccountToolStripMenuItem.Click += AccountToolStripMenuItem_Click;
            this.PhanQuyenAccountToolStripMenuItem.Click += PhanQuyenAccountToolStripMenuItem_Click; ;
            this.GroupUsersToolStripMenuItem.Click += GroupUsersToolStripMenuItem_Click;
            this.Top10ToolStripMenuItem.Click += Top10ToolStripMenuItem_Click;
            this.StatisticBookSalesToolStripMenuItem.Click += StatisticBookSalesToolStripMenuItem_Click;
            this.RevenueToolStripMenuItem.Click += RevenueToolStripMenuItem_Click;
            this.ExpenditurreToolStripMenuItem.Click += ExpenditurreToolStripMenuItem_Click;
        }

        private void ExpenditurreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ExpenditureForm == null || Program.ExpenditureForm.IsDisposed)
            {
                Program.ExpenditureForm = new frmExpenditure();
            }
            Program.ExpenditureForm.Show();
        }

        private void RevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Program.RevenueForm == null || Program.RevenueForm.IsDisposed)
            {
                Program.RevenueForm = new frmRevenue();
            }
            Program.RevenueForm.Show();
        }

        private void PhanQuyenAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.GCForm == null || Program.GCForm.IsDisposed)
            {
                Program.GCForm = new frmGroup_Screen();
            }
            Program.GCForm.Show();
        }

        private void GroupUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.GUForm == null || Program.GUForm.IsDisposed)
            {
                Program.GUForm = new frmGroup_User();
            }
            Program.GUForm.Show();
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }
        private void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {

            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem &&
                ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems,
                    pScreenName, pEnable);
                    menu.Enabled =
                    CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        private void FrmSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng form không?", "Xác nhận đóng form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                this.Close();
            }
        }

        private void StatisticBookSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.StatiscticBookSales == null || Program.StatiscticBookSales.IsDisposed)
            {
                Program.StatiscticBookSales = new frmStatisticBook_Sales();
            }
            Program.StatiscticBookSales.Show();
        }



        private void FrmSystem_Load(object sender, EventArgs e)
        {
            List<int> nhomND = bllGroup.GetGroupIdByUserId(loggedInUserId);
            foreach (int item in nhomND)
            {
                DataTable dsManHinh = bllGroup.GetScreen(item);
                foreach (DataRow mh in dsManHinh.Rows)
                {
                    FindMenuPhanQuyen(this.menuStrip2.Items, mh[0].ToString(), Convert.ToBoolean(mh[2].ToString()));
                }
            }

            LoadStaff();
        }
        public void LoadStaff()
        {
            var loggedInUser = bllUser.GetUserById(loggedInUserId);
            if (loggedInUser != null)
            {
                lbFullname.Text = $"{loggedInUser.firstName} {loggedInUser.lastName}";
            }

        }

        private void Top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.StaticticalTop10Form == null || Program.StaticticalTop10Form.IsDisposed)
            {
                Program.StaticticalTop10Form = new frmStatisticTop10();
            }
            Program.StaticticalTop10Form.Show();
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.UserForm == null || Program.UserForm.IsDisposed)
            {
                Program.UserForm = new frmUser();
            }
            Program.UserForm.Show();
        }

        private void InvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.InvoiceForm == null || Program.InvoiceForm.IsDisposed)
            {
                Program.InvoiceForm = new frmInvoice();
            }
            Program.InvoiceForm.Show();
        }

        private void ImportInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Import_InvoicecForm == null || Program.Import_InvoicecForm.IsDisposed)
            {
                Program.Import_InvoicecForm = new frmImport_Invoicecs(loggedInUserId);
            }
            Program.Import_InvoicecForm.Show();
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.CategorieForm == null || Program.CategorieForm.IsDisposed)
            {
                Program.CategorieForm = new frmCategorie();
            }
            Program.CategorieForm.Show();
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formBooks.Show();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

    }
}
