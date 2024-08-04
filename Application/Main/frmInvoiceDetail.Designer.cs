namespace Main
{
    partial class frmInvoiceDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdInvoice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateCreate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new InheritControl.PhoneText();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPurchaseQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdBook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdInvoice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDateCreate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 226);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtIdInvoice
            // 
            this.txtIdInvoice.Location = new System.Drawing.Point(455, 33);
            this.txtIdInvoice.Name = "txtIdInvoice";
            this.txtIdInvoice.ReadOnly = true;
            this.txtIdInvoice.Size = new System.Drawing.Size(177, 22);
            this.txtIdInvoice.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mã hóa đơn";
            // 
            // txtDateCreate
            // 
            this.txtDateCreate.Location = new System.Drawing.Point(455, 121);
            this.txtDateCreate.Name = "txtDateCreate";
            this.txtDateCreate.ReadOnly = true;
            this.txtDateCreate.Size = new System.Drawing.Size(177, 22);
            this.txtDateCreate.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ngày lập";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(161, 76);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(177, 22);
            this.txtFullName.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(161, 165);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(177, 22);
            this.txtPhone.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(455, 75);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(177, 22);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng tiền";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(161, 121);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(177, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(161, 33);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.ReadOnly = true;
            this.txtIdUser.Size = new System.Drawing.Size(177, 22);
            this.txtIdUser.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 342);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPurchaseQuantity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBookPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNameBook);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtIdBook);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(694, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // txtPurchaseQuantity
            // 
            this.txtPurchaseQuantity.Location = new System.Drawing.Point(160, 165);
            this.txtPurchaseQuantity.Name = "txtPurchaseQuantity";
            this.txtPurchaseQuantity.ReadOnly = true;
            this.txtPurchaseQuantity.Size = new System.Drawing.Size(93, 22);
            this.txtPurchaseQuantity.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Số lượng mua";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(160, 121);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.ReadOnly = true;
            this.txtBookPrice.Size = new System.Drawing.Size(150, 22);
            this.txtBookPrice.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Đơn giá";
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(160, 74);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.ReadOnly = true;
            this.txtNameBook.Size = new System.Drawing.Size(238, 22);
            this.txtNameBook.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tên sách";
            // 
            // txtIdBook
            // 
            this.txtIdBook.Location = new System.Drawing.Point(160, 31);
            this.txtIdBook.Name = "txtIdBook";
            this.txtIdBook.ReadOnly = true;
            this.txtIdBook.Size = new System.Drawing.Size(150, 22);
            this.txtIdBook.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã sách";
            // 
            // frmInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 643);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 643);
            this.Name = "frmInvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFullName;
        private InheritControl.PhoneText txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPurchaseQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdBook;
        private System.Windows.Forms.Label label6;
    }
}