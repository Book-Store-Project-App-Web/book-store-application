using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace Main
{
    public partial class frmRevenue : Form
    {
        BLLInvoice GUIInvoice = new BLLInvoice();
        public frmRevenue()
        {
            InitializeComponent();
            this.Load += FrmRevenue_Load;
            this.btnStatistic.Click += BtnStatistic_Click;
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            int selectedMonth = cbo_Month.SelectedIndex + 1;
            int selectedYear = int.Parse(cbo_Year.SelectedItem.ToString());

            Drawchart(selectedYear, selectedMonth);
        }

        private void FrmRevenue_Load(object sender, EventArgs e)
        {
            LoadInvoice();
            LoadCboBox();
        }

        public void LoadInvoice()
        {
            dataGridView1.DataSource = GUIInvoice.LoadInvoice();
            var unwantedColumns = new[] { "User", "createdAt", "updatedAt" };
            foreach (var column in unwantedColumns)
            {
                if (dataGridView1.Columns.Contains(column))
                {
                    dataGridView1.Columns.Remove(column);
                }
            }
            dataGridView1.Columns["id"].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns["userId"].HeaderText = "Mã khách hàng";
            dataGridView1.Columns["fullname"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["phone"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["totalOrderPrice"].HeaderText = "Tổng tiền";
            
        }
        private void LoadCboBox()
        {
            cbo_Year.Items.AddRange(new string[]
            {
                "2022", "2023", "2024","2025","2026","2027"
            });
            cbo_Year.SelectedIndex = cbo_Year.Items.IndexOf(DateTime.Now.Year.ToString());

            // Populate cboboxMonth with month names
            cbo_Month.Items.AddRange(new string[]
            {
                "1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12"
            });
            cbo_Month.SelectedIndex = DateTime.Now.Month - 1;
        }
        public void Drawchart(int year, int month)
        {
            var summary = GUIInvoice.GetOrdersByMonthAndYear(year, month);

            charRevenue.Series.Clear();
            charRevenue.ChartAreas.Clear();

            var chartArea = new ChartArea();
            charRevenue.ChartAreas.Add(chartArea);

            chartArea.AxisX.Interval = 1;

            var series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Pie
            };

            double totalRevenue = 0;

            foreach (var data in summary)
            {
                int yearValue = data.updatedAt.DateTime.Year;
                int monthValue = data.updatedAt.DateTime.Month;

                series.Points.AddXY(monthValue, (double)data.totalOrderPrice);

                totalRevenue += (double)data.totalOrderPrice;
            }

            charRevenue.Series.Add(series);

            txtTotalStockBook.Text = totalRevenue.ToString();
        }

    }
}
