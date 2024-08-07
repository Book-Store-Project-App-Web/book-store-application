namespace Main
{
    partial class frmImport_Invoicecs
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
            this.cbBoxSupplier = new System.Windows.Forms.ComboBox();
            this.txtPhoneSupplier = new InheritControl.PhoneText();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddressSupplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new InheritControl.PhoneText();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotalAll = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new InheritControl.QuantityText();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGvBook_Import = new System.Windows.Forms.DataGridView();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBoxIdBook = new System.Windows.Forms.ComboBox();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUnitPriceBook = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvBook_Import)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBoxSupplier);
            this.groupBox1.Controls.Add(this.txtPhoneSupplier);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAddressSupplier);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNameSupplier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIdUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập hàng";
            // 
            // cbBoxSupplier
            // 
            this.cbBoxSupplier.FormattingEnabled = true;
            this.cbBoxSupplier.Location = new System.Drawing.Point(526, 30);
            this.cbBoxSupplier.Name = "cbBoxSupplier";
            this.cbBoxSupplier.Size = new System.Drawing.Size(210, 24);
            this.cbBoxSupplier.TabIndex = 32;
            // 
            // txtPhoneSupplier
            // 
            this.txtPhoneSupplier.Location = new System.Drawing.Point(526, 165);
            this.txtPhoneSupplier.Name = "txtPhoneSupplier";
            this.txtPhoneSupplier.ReadOnly = true;
            this.txtPhoneSupplier.Size = new System.Drawing.Size(210, 22);
            this.txtPhoneSupplier.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mã nhà cung cấp";
            // 
            // txtAddressSupplier
            // 
            this.txtAddressSupplier.Location = new System.Drawing.Point(459, 121);
            this.txtAddressSupplier.Name = "txtAddressSupplier";
            this.txtAddressSupplier.ReadOnly = true;
            this.txtAddressSupplier.Size = new System.Drawing.Size(277, 22);
            this.txtAddressSupplier.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Địa chỉ";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(184, 76);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(177, 22);
            this.txtFullName.TabIndex = 25;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(184, 120);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(177, 22);
            this.txtPhone.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // txtNameSupplier
            // 
            this.txtNameSupplier.Location = new System.Drawing.Point(526, 75);
            this.txtNameSupplier.Name = "txtNameSupplier";
            this.txtNameSupplier.ReadOnly = true;
            this.txtNameSupplier.Size = new System.Drawing.Size(210, 22);
            this.txtNameSupplier.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(184, 33);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.ReadOnly = true;
            this.txtIdUser.Size = new System.Drawing.Size(177, 22);
            this.txtIdUser.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotalAll);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.dataGvBook_Import);
            this.groupBox2.Controls.Add(this.cbBoxIdBook);
            this.groupBox2.Controls.Add(this.txtNameBook);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTotalPrice);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtUnitPriceBook);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 463);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách nhập";
            // 
            // lbTotalAll
            // 
            this.lbTotalAll.AutoSize = true;
            this.lbTotalAll.Location = new System.Drawing.Point(564, 424);
            this.lbTotalAll.Name = "lbTotalAll";
            this.lbTotalAll.Size = new System.Drawing.Size(24, 17);
            this.lbTotalAll.TabIndex = 40;
            this.lbTotalAll.Text = "0đ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tổng tiền:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(507, 52);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(228, 22);
            this.txtQuantity.TabIndex = 38;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(293, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 38);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(225, 413);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 38);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(153, 413);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 38);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 38);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(9, 413);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(59, 38);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // dataGvBook_Import
            // 
            this.dataGvBook_Import.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGvBook_Import.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvBook_Import.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBook,
            this.nameBook,
            this.quantity,
            this.unitPrice,
            this.totalPrice});
            this.dataGvBook_Import.Location = new System.Drawing.Point(9, 187);
            this.dataGvBook_Import.Name = "dataGvBook_Import";
            this.dataGvBook_Import.RowTemplate.Height = 24;
            this.dataGvBook_Import.Size = new System.Drawing.Size(727, 203);
            this.dataGvBook_Import.TabIndex = 31;
            // 
            // idBook
            // 
            this.idBook.HeaderText = "Mã sách";
            this.idBook.Name = "idBook";
            // 
            // nameBook
            // 
            this.nameBook.HeaderText = "Tên sách";
            this.nameBook.Name = "nameBook";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Đơn giá";
            this.unitPrice.Name = "unitPrice";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Tổng tiền";
            this.totalPrice.Name = "totalPrice";
            // 
            // cbBoxIdBook
            // 
            this.cbBoxIdBook.FormattingEnabled = true;
            this.cbBoxIdBook.Location = new System.Drawing.Point(142, 51);
            this.cbBoxIdBook.Name = "cbBoxIdBook";
            this.cbBoxIdBook.Size = new System.Drawing.Size(250, 24);
            this.cbBoxIdBook.TabIndex = 30;
            // 
            // txtNameBook
            // 
            this.txtNameBook.Location = new System.Drawing.Point(142, 96);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.ReadOnly = true;
            this.txtNameBook.Size = new System.Drawing.Size(250, 22);
            this.txtNameBook.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Số lượng";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(507, 96);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(228, 22);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tổng tiền";
            // 
            // txtUnitPriceBook
            // 
            this.txtUnitPriceBook.Location = new System.Drawing.Point(142, 141);
            this.txtUnitPriceBook.Name = "txtUnitPriceBook";
            this.txtUnitPriceBook.Size = new System.Drawing.Size(250, 22);
            this.txtUnitPriceBook.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Đơn giá";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tên sách";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "Mã sách";
            // 
            // frmImport_Invoicecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 717);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmImport_Invoicecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvBook_Import)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBoxSupplier;
        private InheritControl.PhoneText txtPhoneSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddressSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFullName;
        private InheritControl.PhoneText txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTotalAll;
        private System.Windows.Forms.Label label9;
        private InheritControl.QuantityText txtQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGvBook_Import;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.ComboBox cbBoxIdBook;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUnitPriceBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}