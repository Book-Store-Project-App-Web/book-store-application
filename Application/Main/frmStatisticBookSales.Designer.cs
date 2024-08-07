namespace Main
{
    partial class frmStatisticBook_Sales
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
            this.cbo_Year = new System.Windows.Forms.ComboBox();
            this.cbo_Month = new System.Windows.Forms.ComboBox();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSellNumber = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStockBook = new System.Windows.Forms.Label();
            this.txtTotalStockBook = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartSellNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Year
            // 
            this.cbo_Year.FormattingEnabled = true;
            this.cbo_Year.Location = new System.Drawing.Point(574, 135);
            this.cbo_Year.Name = "cbo_Year";
            this.cbo_Year.Size = new System.Drawing.Size(169, 24);
            this.cbo_Year.TabIndex = 16;
            // 
            // cbo_Month
            // 
            this.cbo_Month.FormattingEnabled = true;
            this.cbo_Month.Location = new System.Drawing.Point(574, 91);
            this.cbo_Month.Name = "cbo_Month";
            this.cbo_Month.Size = new System.Drawing.Size(169, 24);
            this.cbo_Month.TabIndex = 15;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(607, 174);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(99, 35);
            this.btnStatistic.TabIndex = 14;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Năm";
            // 
            // chartSellNumber
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSellNumber.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSellNumber.Legends.Add(legend1);
            this.chartSellNumber.Location = new System.Drawing.Point(12, 12);
            this.chartSellNumber.Name = "chartSellNumber";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSellNumber.Series.Add(series1);
            this.chartSellNumber.Size = new System.Drawing.Size(441, 263);
            this.chartSellNumber.TabIndex = 12;
            this.chartSellNumber.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tháng";
            // 
            // lblStockBook
            // 
            this.lblStockBook.AutoSize = true;
            this.lblStockBook.Location = new System.Drawing.Point(474, 246);
            this.lblStockBook.Name = "lblStockBook";
            this.lblStockBook.Size = new System.Drawing.Size(123, 17);
            this.lblStockBook.TabIndex = 18;
            this.lblStockBook.Text = "Tổng sách đã bán";
            // 
            // txtTotalStockBook
            // 
            this.txtTotalStockBook.Location = new System.Drawing.Point(603, 243);
            this.txtTotalStockBook.Name = "txtTotalStockBook";
            this.txtTotalStockBook.Size = new System.Drawing.Size(164, 22);
            this.txtTotalStockBook.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 300);
            this.dataGridView1.TabIndex = 20;
            // 
            // frmStatisticBook_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 588);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalStockBook);
            this.Controls.Add(this.lblStockBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_Year);
            this.Controls.Add(this.cbo_Month);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartSellNumber);
            this.Name = "frmStatisticBook_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Thống Kê Sách Bán";
            ((System.ComponentModel.ISupportInitialize)(this.chartSellNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Year;
        private System.Windows.Forms.ComboBox cbo_Month;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSellNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStockBook;
        private System.Windows.Forms.TextBox txtTotalStockBook;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}