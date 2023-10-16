namespace GUI
{
    partial class GUI_DanhGia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiDanhGia = new System.Windows.Forms.ComboBox();
            this.dgvDanhGia = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBNoresponse = new System.Windows.Forms.RadioButton();
            this.rBResponded = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rsbTot = new System.Windows.Forms.RadioButton();
            this.rdbKhongTot = new System.Windows.Forms.RadioButton();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(21, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 10);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ ĐÁNH GIÁ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lọc đánh giá :";
            // 
            // cbLoaiDanhGia
            // 
            this.cbLoaiDanhGia.FormattingEnabled = true;
            this.cbLoaiDanhGia.Location = new System.Drawing.Point(103, 85);
            this.cbLoaiDanhGia.Name = "cbLoaiDanhGia";
            this.cbLoaiDanhGia.Size = new System.Drawing.Size(121, 21);
            this.cbLoaiDanhGia.TabIndex = 6;
            this.cbLoaiDanhGia.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDanhGia_SelectedIndexChanged);
            // 
            // dgvDanhGia
            // 
            this.dgvDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhGia.Location = new System.Drawing.Point(18, 125);
            this.dgvDanhGia.Name = "dgvDanhGia";
            this.dgvDanhGia.Size = new System.Drawing.Size(484, 449);
            this.dgvDanhGia.TabIndex = 7;
            this.dgvDanhGia.SelectionChanged += new System.EventHandler(this.dgvDanhGia_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNoiDung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rsbTot);
            this.groupBox1.Controls.Add(this.rdbKhongTot);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(522, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 449);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đánh giá";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBNoresponse);
            this.panel2.Controls.Add(this.rBResponded);
            this.panel2.Location = new System.Drawing.Point(114, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 86);
            this.panel2.TabIndex = 8;
            // 
            // rBNoresponse
            // 
            this.rBNoresponse.AutoSize = true;
            this.rBNoresponse.Location = new System.Drawing.Point(28, 55);
            this.rBNoresponse.Name = "rBNoresponse";
            this.rBNoresponse.Size = new System.Drawing.Size(94, 17);
            this.rBNoresponse.TabIndex = 0;
            this.rBNoresponse.TabStop = true;
            this.rBNoresponse.Text = "Chưa phản hồi";
            this.rBNoresponse.UseVisualStyleBackColor = true;
            // 
            // rBResponded
            // 
            this.rBResponded.AutoSize = true;
            this.rBResponded.Location = new System.Drawing.Point(28, 15);
            this.rBResponded.Name = "rBResponded";
            this.rBResponded.Size = new System.Drawing.Size(83, 17);
            this.rBResponded.TabIndex = 0;
            this.rBResponded.TabStop = true;
            this.rBResponded.Text = "Đã phản hồi";
            this.rBResponded.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(336, 420);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 23);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "TT khách hàng";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(191, 420);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(110, 420);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tiến trình :";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(110, 153);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(245, 155);
            this.txtNoiDung.TabIndex = 4;
            this.txtNoiDung.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nội dung :";
            // 
            // rsbTot
            // 
            this.rsbTot.AutoSize = true;
            this.rsbTot.Location = new System.Drawing.Point(110, 108);
            this.rsbTot.Name = "rsbTot";
            this.rsbTot.Size = new System.Drawing.Size(41, 17);
            this.rsbTot.TabIndex = 2;
            this.rsbTot.TabStop = true;
            this.rsbTot.Text = "Tốt";
            this.rsbTot.UseVisualStyleBackColor = true;
            // 
            // rdbKhongTot
            // 
            this.rdbKhongTot.AutoSize = true;
            this.rdbKhongTot.Location = new System.Drawing.Point(230, 108);
            this.rdbKhongTot.Name = "rdbKhongTot";
            this.rdbKhongTot.Size = new System.Drawing.Size(71, 17);
            this.rdbKhongTot.TabIndex = 2;
            this.rdbKhongTot.TabStop = true;
            this.rdbKhongTot.Text = "Không tốt";
            this.rdbKhongTot.UseVisualStyleBackColor = true;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(110, 64);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(245, 20);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMSP
            // 
            this.txtMSP.Location = new System.Drawing.Point(110, 25);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(245, 20);
            this.txtMSP.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên sản phẩm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại đánh giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sản phẩm :";
            // 
            // GUI_DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDanhGia);
            this.Controls.Add(this.cbLoaiDanhGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DanhGia";
            this.Text = "GUI_DanhGia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLoaiDanhGia;
        private System.Windows.Forms.DataGridView dgvDanhGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rsbTot;
        private System.Windows.Forms.RadioButton rdbKhongTot;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBNoresponse;
        private System.Windows.Forms.RadioButton rBResponded;
    }
}