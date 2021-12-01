namespace QLKHACHSAN.GUI
{
    partial class frm_PhieuThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PhieuThue));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_K = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_NV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dp_nthue = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dp_ntra = new System.Windows.Forms.DateTimePicker();
            this.btn_thueP = new System.Windows.Forms.Button();
            this.btn_cp = new System.Windows.Forms.Button();
            this.txt_sp = new System.Windows.Forms.TextBox();
            this.lbl_sop = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_tinhtien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            // 
            // cb_K
            // 
            this.cb_K.FormattingEnabled = true;
            this.cb_K.Location = new System.Drawing.Point(77, 325);
            this.cb_K.Name = "cb_K";
            this.cb_K.Size = new System.Drawing.Size(121, 21);
            this.cb_K.TabIndex = 2;
            this.cb_K.TextChanged += new System.EventHandler(this.cb_K_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách:";
            // 
            // cb_NV
            // 
            this.cb_NV.FormattingEnabled = true;
            this.cb_NV.Location = new System.Drawing.Point(77, 139);
            this.cb_NV.Name = "cb_NV";
            this.cb_NV.Size = new System.Drawing.Size(121, 21);
            this.cb_NV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số phiếu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày thuê:";
            // 
            // dp_nthue
            // 
            this.dp_nthue.CustomFormat = "dd/MM/yyyy";
            this.dp_nthue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_nthue.Location = new System.Drawing.Point(77, 234);
            this.dp_nthue.Name = "dp_nthue";
            this.dp_nthue.Size = new System.Drawing.Size(121, 20);
            this.dp_nthue.TabIndex = 4;
            this.dp_nthue.Value = new System.DateTime(2017, 1, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày trả:";
            // 
            // dp_ntra
            // 
            this.dp_ntra.CustomFormat = "dd/MM/yyyy";
            this.dp_ntra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_ntra.Location = new System.Drawing.Point(77, 280);
            this.dp_ntra.Name = "dp_ntra";
            this.dp_ntra.Size = new System.Drawing.Size(121, 20);
            this.dp_ntra.TabIndex = 5;
            this.dp_ntra.Value = new System.DateTime(2017, 1, 22, 0, 0, 0, 0);
            // 
            // btn_thueP
            // 
            this.btn_thueP.Location = new System.Drawing.Point(264, 420);
            this.btn_thueP.Name = "btn_thueP";
            this.btn_thueP.Size = new System.Drawing.Size(75, 23);
            this.btn_thueP.TabIndex = 28;
            this.btn_thueP.Text = "Thuê phòng";
            this.btn_thueP.UseVisualStyleBackColor = true;
            this.btn_thueP.Click += new System.EventHandler(this.btn_ThueP);
            // 
            // btn_cp
            // 
            this.btn_cp.Location = new System.Drawing.Point(460, 420);
            this.btn_cp.Name = "btn_cp";
            this.btn_cp.Size = new System.Drawing.Size(85, 23);
            this.btn_cp.TabIndex = 31;
            this.btn_cp.Text = "Chuyển phòng";
            this.btn_cp.UseVisualStyleBackColor = true;
            this.btn_cp.Click += new System.EventHandler(this.btn_cp_Click);
            // 
            // txt_sp
            // 
            this.txt_sp.Location = new System.Drawing.Point(77, 49);
            this.txt_sp.Name = "txt_sp";
            this.txt_sp.Size = new System.Drawing.Size(121, 20);
            this.txt_sp.TabIndex = 32;
            this.txt_sp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_sop
            // 
            this.lbl_sop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_sop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sop.ForeColor = System.Drawing.Color.Black;
            this.lbl_sop.Location = new System.Drawing.Point(77, 93);
            this.lbl_sop.Name = "lbl_sop";
            this.lbl_sop.Size = new System.Drawing.Size(121, 20);
            this.lbl_sop.TabIndex = 34;
            this.lbl_sop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_sop.TextChanged += new System.EventHandler(this.lbl_sop_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 35;
            // 
            // btn_tinhtien
            // 
            this.btn_tinhtien.Enabled = false;
            this.btn_tinhtien.Location = new System.Drawing.Point(674, 420);
            this.btn_tinhtien.Name = "btn_tinhtien";
            this.btn_tinhtien.Size = new System.Drawing.Size(85, 23);
            this.btn_tinhtien.TabIndex = 36;
            this.btn_tinhtien.Text = "Tính tiền";
            this.btn_tinhtien.UseVisualStyleBackColor = true;
            this.btn_tinhtien.Click += new System.EventHandler(this.btn_tinhtien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_sp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.cb_K);
            this.groupBox1.Controls.Add(this.lbl_sop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_NV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dp_nthue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dp_ntra);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 374);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu thuê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tìm khách:";
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(77, 188);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(121, 20);
            this.txt_mk.TabIndex = 35;
            this.txt_mk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(264, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(683, 160);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SOPHIEUTP";
            this.Column1.HeaderText = "Số phiếu";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MAP";
            this.Column6.HeaderText = "Phòng";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MANV";
            this.Column2.HeaderText = "Nhân viên";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MAKH";
            this.Column3.HeaderText = "Tên khách";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYTHUE";
            this.Column4.HeaderText = "Ngày thuê";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYTRA";
            this.Column5.HeaderText = "Ngày trả";
            this.Column5.Name = "Column5";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(89, 423);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column10,
            this.Column9,
            this.Column12,
            this.Column13,
            this.Column11});
            this.dataGridView2.Location = new System.Drawing.Point(264, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(683, 160);
            this.dataGridView2.TabIndex = 41;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MAKH";
            this.Column7.HeaderText = "Mã khách";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TENKH";
            this.Column8.HeaderText = "Họ tên";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "CMND";
            this.Column10.HeaderText = "Số CMND";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "QUOCTICH";
            this.Column9.HeaderText = "Quốc tịch";
            this.Column9.Name = "Column9";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SDT";
            this.Column12.HeaderText = "Số điện thoại";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "GIOITINH";
            this.Column13.HeaderText = "Giới tính";
            this.Column13.Name = "Column13";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PASSPORT";
            this.Column11.HeaderText = "Passport";
            this.Column11.Name = "Column11";
            this.Column11.Visible = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(862, 420);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(85, 23);
            this.btn_Xoa.TabIndex = 42;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_PhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(971, 500);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_tinhtien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_cp);
            this.Controls.Add(this.btn_thueP);
            this.Name = "frm_PhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thuê phòng";
            this.Load += new System.EventHandler(this.frm_qlthueP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_thueP;
        private System.Windows.Forms.Button btn_cp;
        public System.Windows.Forms.ComboBox cb_K;
        public System.Windows.Forms.ComboBox cb_NV;
        public System.Windows.Forms.DateTimePicker dp_nthue;
        public System.Windows.Forms.DateTimePicker dp_ntra;
        public System.Windows.Forms.TextBox txt_sp;
        public System.Windows.Forms.Label lbl_sop;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btn_tinhtien;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}