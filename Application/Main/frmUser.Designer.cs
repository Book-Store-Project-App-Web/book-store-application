﻿namespace Main
{
    partial class frmUser
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grBoxCategory = new System.Windows.Forms.GroupBox();
            this.txtFistName = new System.Windows.Forms.TextBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboBoxSex = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPhone = new InheritControl.PhoneText();
            this.txtEmail = new InheritControl.EmailText();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grBoxCategory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // grBoxCategory
            // 
            this.grBoxCategory.Controls.Add(this.txtEmail);
            this.grBoxCategory.Controls.Add(this.txtPhone);
            this.grBoxCategory.Controls.Add(this.cboBoxSex);
            this.grBoxCategory.Controls.Add(this.txtPassword);
            this.grBoxCategory.Controls.Add(this.label5);
            this.grBoxCategory.Controls.Add(this.label6);
            this.grBoxCategory.Controls.Add(this.label7);
            this.grBoxCategory.Controls.Add(this.label4);
            this.grBoxCategory.Controls.Add(this.txtLastName);
            this.grBoxCategory.Controls.Add(this.txtFistName);
            this.grBoxCategory.Controls.Add(this.txtIdUser);
            this.grBoxCategory.Controls.Add(this.label3);
            this.grBoxCategory.Controls.Add(this.label2);
            this.grBoxCategory.Controls.Add(this.label1);
            this.grBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxCategory.ForeColor = System.Drawing.Color.Red;
            this.grBoxCategory.Location = new System.Drawing.Point(12, 4);
            this.grBoxCategory.Name = "grBoxCategory";
            this.grBoxCategory.Size = new System.Drawing.Size(732, 231);
            this.grBoxCategory.TabIndex = 2;
            this.grBoxCategory.TabStop = false;
            this.grBoxCategory.Text = "Thông tin";
            // 
            // txtFistName
            // 
            this.txtFistName.Location = new System.Drawing.Point(164, 85);
            this.txtFistName.Name = "txtFistName";
            this.txtFistName.Size = new System.Drawing.Size(195, 24);
            this.txtFistName.TabIndex = 4;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Enabled = false;
            this.txtIdUser.Location = new System.Drawing.Point(164, 46);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.ReadOnly = true;
            this.txtIdUser.Size = new System.Drawing.Size(195, 24);
            this.txtIdUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên riêng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(164, 127);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 24);
            this.txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(495, 85);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 24);
            this.txtPassword.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // cboBoxSex
            // 
            this.cboBoxSex.FormattingEnabled = true;
            this.cboBoxSex.Location = new System.Drawing.Point(495, 124);
            this.cboBoxSex.Name = "cboBoxSex";
            this.cboBoxSex.Size = new System.Drawing.Size(195, 26);
            this.cboBoxSex.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(776, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục chức năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(275, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 53);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(177, 95);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 53);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(275, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(177, 32);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 53);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(137, 174);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 24);
            this.txtSearch.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(164, 171);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(195, 24);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(495, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 24);
            this.txtEmail.TabIndex = 14;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grBoxCategory);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grBoxCategory.ResumeLayout(false);
            this.grBoxCategory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grBoxCategory;
        private System.Windows.Forms.TextBox txtFistName;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboBoxSex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private InheritControl.PhoneText txtPhone;
        private InheritControl.EmailText txtEmail;
    }
}