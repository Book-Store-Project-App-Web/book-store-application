using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL;
using DTO;

namespace Main
{
    public partial class frmStatisticBook_Sales : Form
    {
        BLLBookOrders GUIBookOrders = new BLLBookOrders();
        public frmStatisticBook_Sales()
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
            LoadCboBox();
            LoadBookOrders();
        }

        public void Drawchart(int year, int month)
        {
            var summary = GUIBookOrders.GetBookOrdersByMonthAndYear(year, month);

            chartSellNumber.Series.Clear();
            chartSellNumber.ChartAreas.Clear();

            var chartArea = new ChartArea();
            chartSellNumber.ChartAreas.Add(chartArea);

            chartArea.AxisX.Interval = 1;

            var series = new Series("Số lượng sách")
            {
                ChartType = SeriesChartType.Column
            };

            int totalQuantity = 0;

            foreach (var data in summary)
            {
                int yearValue = data.updatedAt.DateTime.Year;

                series.Points.AddXY(yearValue, (int)data.quantity);

                totalQuantity += (int)data.quantity;
            }

            chartSellNumber.Series.Add(series);

            txtTotalStockBook.Text = totalQuantity.ToString();
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
        public void LoadBookOrders()
        {
            dataGridView1.DataSource = GUIBookOrders.LoadBookOrders();
            var unwantedColumns = new[] { "Book", "Order", "updatedAt" };
            foreach (var column in unwantedColumns)
            {
                if (dataGridView1.Columns.Contains(column))
                {
                    dataGridView1.Columns.Remove(column);
                }
            }
            dataGridView1.Columns["id"].HeaderText = "Mã CT Hóa đơn";
            dataGridView1.Columns["bookId"].HeaderText = "Mã sách";
            dataGridView1.Columns["orderId"].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns["quantity"].HeaderText = "Số lượng";
            dataGridView1.Columns["unitPrice"].HeaderText = "Đơn giá";
            dataGridView1.Columns["createdAt"].HeaderText = "Ngày lập";

            dataGridView1.Columns["createdAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
        }
    }
}
