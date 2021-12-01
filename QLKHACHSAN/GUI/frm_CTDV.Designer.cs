namespace QLKHACHSAN.GUI
{
    partial class frm_CTDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTDV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUD_sl = new System.Windows.Forms.NumericUpDown();
            this.dp_ngay = new System.Windows.Forms.DateTimePicker();
            this.cb_dv = new System.Windows.Forms.ComboBox();
            this.cb_loaidv = new System.Windows.Forms.ComboBox();
            this.cb_nv = new System.Windows.Forms.ComboBox();
            this.txt_khach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themdv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSLDV = new System.Windows.Forms.Button();
            this.btn_xoadv = new System.Windows.Forms.Button();
            this.btn_suadv = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.numUD_sl);
            this.groupBox1.Controls.Add(this.dp_ngay);
            this.groupBox1.Controls.Add(this.cb_dv);
            this.groupBox1.Controls.Add(this.cb_loaidv);
            this.groupBox1.Controls.Add(this.cb_nv);
            this.groupBox1.Controls.Add(this.txt_khach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_phong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // numUD_sl
            // 
            this.numUD_sl.Location = new System.Drawing.Point(80, 277);
            this.numUD_sl.Name = "numUD_sl";
            this.numUD_sl.Size = new System.Drawing.Size(120, 20);
            this.numUD_sl.TabIndex = 8;
            this.numUD_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numUD_sl_KeyPress);
            // 
            // dp_ngay
            // 
            this.dp_ngay.CustomFormat = "dd/MM/yyyy";
            this.dp_ngay.Enabled = false;
            this.dp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_ngay.Location = new System.Drawing.Point(80, 239);
            this.dp_ngay.Name = "dp_ngay";
            this.dp_ngay.Size = new System.Drawing.Size(121, 20);
            this.dp_ngay.TabIndex = 3;
            // 
            // cb_dv
            // 
            this.cb_dv.FormattingEnabled = true;
            this.cb_dv.Location = new System.Drawing.Point(79, 196);
            this.cb_dv.Name = "cb_dv";
            this.cb_dv.Size = new System.Drawing.Size(121, 21);
            this.cb_dv.TabIndex = 3;
            // 
            // cb_loaidv
            // 
            this.cb_loaidv.FormattingEnabled = true;
            this.cb_loaidv.Location = new System.Drawing.Point(79, 155);
            this.cb_loaidv.Name = "cb_loaidv";
            this.cb_loaidv.Size = new System.Drawing.Size(121, 21);
            this.cb_loaidv.TabIndex = 2;
            this.cb_loaidv.TextChanged += new System.EventHandler(this.cb_loaidv_TextChanged_1);
            // 
            // cb_nv
            // 
            this.cb_nv.FormattingEnabled = true;
            this.cb_nv.Location = new System.Drawing.Point(80, 113);
            this.cb_nv.Name = "cb_nv";
            this.cb_nv.Size = new System.Drawing.Size(121, 21);
            this.cb_nv.TabIndex = 1;
            // 
            // txt_khach
            // 
            this.txt_khach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_khach.Enabled = false;
            this.txt_khach.Location = new System.Drawing.Point(80, 72);
            this.txt_khach.Name = "txt_khach";
            this.txt_khach.Size = new System.Drawing.Size(120, 20);
            this.txt_khach.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số lượng:";
            // 
            // txt_phong
            // 
            this.txt_phong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phong.Enabled = false;
            this.txt_phong.Location = new System.Drawing.Point(80, 32);
            this.txt_phong.Name = "txt_phong";
            this.txt_phong.Size = new System.Drawing.Size(120, 20);
            this.txt_phong.TabIndex = 5;
            this.txt_phong.TextChanged += new System.EventHandler(this.txt_phong_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại dịch vụ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng:";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(109, 413);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 20);
            this.txt_id.TabIndex = 101;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(316, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(544, 44);
            this.dataGridView1.TabIndex = 100;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SOPHIEUTP";
            this.Column1.HeaderText = "Số phiếu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MAP";
            this.Column2.HeaderText = "Phòng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MAKH";
            this.Column4.HeaderText = "Tên khách";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MANV";
            this.Column3.HeaderText = "Nhân viên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NGAYTHUE";
            this.Column5.HeaderText = "Ngày thuê";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NGAYTRA";
            this.Column6.HeaderText = "Ngày trả";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column10,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column12});
            this.dataGridView2.Location = new System.Drawing.Point(316, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(544, 260);
            this.dataGridView2.TabIndex = 99;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "id";
            this.Column13.HeaderText = "ID";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "MALOAIDV";
            this.Column14.HeaderText = "Loại DV";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "MADV";
            this.Column10.HeaderText = "Dịch vụ";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MAP";
            this.Column7.HeaderText = "Phòng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MAKH";
            this.Column8.HeaderText = "Tên khách";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MANV";
            this.Column9.HeaderText = "Nhân viên";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NGAY";
            this.Column11.HeaderText = "Ngày";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "SOLUONG";
            this.Column12.HeaderText = "Số lượng";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // btn_themdv
            // 
            this.btn_themdv.Location = new System.Drawing.Point(6, 28);
            this.btn_themdv.Name = "btn_themdv";
            this.btn_themdv.Size = new System.Drawing.Size(75, 23);
            this.btn_themdv.TabIndex = 3;
            this.btn_themdv.Text = "Thêm";
            this.btn_themdv.UseVisualStyleBackColor = true;
            this.btn_themdv.Click += new System.EventHandler(this.btn_themdv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnSuaDV);
            this.groupBox2.Controls.Add(this.btnSLDV);
            this.groupBox2.Controls.Add(this.btn_xoadv);
            this.groupBox2.Controls.Add(this.btn_suadv);
            this.groupBox2.Controls.Add(this.btn_themdv);
            this.groupBox2.Location = new System.Drawing.Point(316, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 77);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnSLDV
            // 
            this.btnSLDV.Location = new System.Drawing.Point(119, 31);
            this.btnSLDV.Name = "btnSLDV";
            this.btnSLDV.Size = new System.Drawing.Size(75, 23);
            this.btnSLDV.TabIndex = 6;
            this.btnSLDV.Text = "Sửa Loại DV";
            this.btnSLDV.UseVisualStyleBackColor = true;
            this.btnSLDV.Click += new System.EventHandler(this.btnSLDV_Click);
            // 
            // btn_xoadv
            // 
            this.btn_xoadv.Location = new System.Drawing.Point(463, 28);
            this.btn_xoadv.Name = "btn_xoadv";
            this.btn_xoadv.Size = new System.Drawing.Size(75, 23);
            this.btn_xoadv.TabIndex = 5;
            this.btn_xoadv.Text = "Xóa";
            this.btn_xoadv.UseVisualStyleBackColor = true;
            this.btn_xoadv.Click += new System.EventHandler(this.btn_xoadv_Click);
            // 
            // btn_suadv
            // 
            this.btn_suadv.Location = new System.Drawing.Point(239, 28);
            this.btn_suadv.Name = "btn_suadv";
            this.btn_suadv.Size = new System.Drawing.Size(75, 23);
            this.btn_suadv.TabIndex = 4;
            this.btn_suadv.Text = "Sửa";
            this.btn_suadv.UseVisualStyleBackColor = true;
            this.btn_suadv.Click += new System.EventHandler(this.btn_suadv_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Location = new System.Drawing.Point(354, 31);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDV.TabIndex = 7;
            this.btnSuaDV.Text = "Sửa DV";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // frm_CTDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 471);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_CTDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết dịch vụ";
            this.Load += new System.EventHandler(this.frm_CTDV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_themdv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_xoadv;
        private System.Windows.Forms.Button btn_suadv;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DateTimePicker dp_ngay;
        public System.Windows.Forms.ComboBox cb_dv;
        public System.Windows.Forms.ComboBox cb_loaidv;
        public System.Windows.Forms.ComboBox cb_nv;
        public System.Windows.Forms.TextBox txt_khach;
        public System.Windows.Forms.TextBox txt_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        public System.Windows.Forms.NumericUpDown numUD_sl;
        private System.Windows.Forms.Button btnSLDV;
        private System.Windows.Forms.Button btnSuaDV;
    }
}