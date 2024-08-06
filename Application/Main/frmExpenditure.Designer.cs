namespace Main
{
    partial class frmExpenditure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtTotalStockBook = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Year = new System.Windows.Forms.ComboBox();
            this.cbo_Month = new System.Windows.Forms.ComboBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.charRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.charRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalStockBook
            // 
            this.txtTotalStockBook.Location = new System.Drawing.Point(654, 235);
            this.txtTotalStockBook.Name = "txtTotalStockBook";
            this.txtTotalStockBook.Size = new System.Drawing.Size(164, 22);
            this.txtTotalStockBook.TabIndex = 32;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(525, 238);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 17);
            this.lbl.TabIndex = 31;
            this.lbl.Text = "Tổng tiền nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tháng";
            // 
            // cbo_Year
            // 
            this.cbo_Year.FormattingEnabled = true;
            this.cbo_Year.Location = new System.Drawing.Point(613, 131);
            this.cbo_Year.Name = "cbo_Year";
            this.cbo_Year.Size = new System.Drawing.Size(169, 24);
            this.cbo_Year.TabIndex = 29;
            // 
            // cbo_Month
            // 
            this.cbo_Month.FormattingEnabled = true;
            this.cbo_Month.Location = new System.Drawing.Point(613, 87);
            this.cbo_Month.Name = "cbo_Month";
            this.cbo_Month.Size = new System.Drawing.Size(169, 24);
            this.cbo_Month.TabIndex = 28;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(646, 170);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(99, 35);
            this.btnStatistic.TabIndex = 27;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Năm";
            // 
            // charRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.charRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.charRevenue.Legends.Add(legend1);
            this.charRevenue.Location = new System.Drawing.Point(12, 12);
            this.charRevenue.Name = "charRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.charRevenue.Series.Add(series1);
            this.charRevenue.Size = new System.Drawing.Size(504, 268);
            this.charRevenue.TabIndex = 25;
            this.charRevenue.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 291);
            this.dataGridView1.TabIndex = 33;
            // 
            // frmExpenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 589);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalStockBook);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_Year);
            this.Controls.Add(this.cbo_Month);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.charRevenue);
            this.Name = "frmExpenditure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi phí";
            ((System.ComponentModel.ISupportInitialize)(this.charRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalStockBook;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Year;
        private System.Windows.Forms.ComboBox cbo_Month;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart charRevenue;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}