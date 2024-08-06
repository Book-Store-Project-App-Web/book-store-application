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
    public partial class frmExpenditure : Form
    {
        BLLImport_Invoice GUIImport_Invoice = new BLLImport_Invoice();
        public frmExpenditure()
        {
            InitializeComponent();
            this.Load += FrmExpenditure_Load; ;
            this.btnStatistic.Click += BtnStatistic_Click;
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            int selectedMonth = cbo_Month.SelectedIndex + 1;
            int selectedYear = int.Parse(cbo_Year.SelectedItem.ToString());

            Drawchart(selectedYear, selectedMonth);
        }

        private void FrmExpenditure_Load(object sender, EventArgs e)
        {
            LoadCboBox();
            LoadImportInvoice();

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
        public void LoadImportInvoice()
        {
            dataGridView1.DataSource = GUIImport_Invoice.LoadImport_Invoice();
            var unwantedColumns = new[] { "User", "createdAt", "updatedAt" };
            foreach (var column in unwantedColumns)
            {
                if (dataGridView1.Columns.Contains(column))
                {
                    dataGridView1.Columns.Remove(column);
                }
            }
            dataGridView1.Columns["id"].HeaderText = "Mã phiếu nhập";
            dataGridView1.Columns["userId"].HeaderText = "Mã nhân viên";
            dataGridView1.Columns["supplier"].HeaderText = "Nhà cung cấp";
            dataGridView1.Columns["totalInvoice"].HeaderText = "Tổng tiền nhập";

        }
        public void Drawchart(int year, int month)
        {
            var summary = GUIImport_Invoice.GetImportInvoiceByMonthAndYear(year, month);

            charRevenue.Series.Clear();
            charRevenue.ChartAreas.Clear();

            var chartArea = new ChartArea();
            charRevenue.ChartAreas.Add(chartArea);

            chartArea.AxisX.Interval = 1;

            var series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column
            };

            double totalRevenue = 0;

            foreach (var data in summary)
            {
                int yearValue = data.createdAt.DateTime.Year;

                series.Points.AddXY(yearValue, (double)data.totalInvoice);

                totalRevenue += (double)data.totalInvoice;
            }

            charRevenue.Series.Add(series);

            txtTotalStockBook.Text = totalRevenue.ToString();
        }
    }
}
