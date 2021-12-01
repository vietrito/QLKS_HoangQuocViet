namespace QLKHACHSAN.GUI
{
    partial class frm_TaoTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaoTK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ttk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkb_hienthimk = new System.Windows.Forms.CheckBox();
            this.rb_NQL = new System.Windows.Forms.RadioButton();
            this.rb_LT = new System.Windows.Forms.RadioButton();
            this.btn_taoTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_ttk
            // 
            this.txt_ttk.Location = new System.Drawing.Point(115, 32);
            this.txt_ttk.Name = "txt_ttk";
            this.txt_ttk.Size = new System.Drawing.Size(186, 24);
            this.txt_ttk.TabIndex = 1;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(115, 83);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(186, 24);
            this.txt_mk.TabIndex = 2;
            this.txt_mk.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quyền:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkb_hienthimk);
            this.groupBox1.Controls.Add(this.rb_NQL);
            this.groupBox1.Controls.Add(this.txt_mk);
            this.groupBox1.Controls.Add(this.rb_LT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ttk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(24, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 225);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // checkb_hienthimk
            // 
            this.checkb_hienthimk.AutoSize = true;
            this.checkb_hienthimk.Location = new System.Drawing.Point(322, 88);
            this.checkb_hienthimk.Name = "checkb_hienthimk";
            this.checkb_hienthimk.Size = new System.Drawing.Size(141, 22);
            this.checkb_hienthimk.TabIndex = 5;
            this.checkb_hienthimk.Text = "Hiển thị mật khẩu";
            this.checkb_hienthimk.UseVisualStyleBackColor = true;
            this.checkb_hienthimk.CheckedChanged += new System.EventHandler(this.checkb_hienthimk_CheckedChanged);
            // 
            // rb_NQL
            // 
            this.rb_NQL.AutoSize = true;
            this.rb_NQL.Location = new System.Drawing.Point(231, 139);
            this.rb_NQL.Name = "rb_NQL";
            this.rb_NQL.Size = new System.Drawing.Size(115, 22);
            this.rb_NQL.TabIndex = 4;
            this.rb_NQL.TabStop = true;
            this.rb_NQL.Text = "Người quản lý";
            this.rb_NQL.UseVisualStyleBackColor = true;
            this.rb_NQL.CheckedChanged += new System.EventHandler(this.rb_NQL_CheckedChanged);
            // 
            // rb_LT
            // 
            this.rb_LT.AutoSize = true;
            this.rb_LT.Location = new System.Drawing.Point(115, 139);
            this.rb_LT.Name = "rb_LT";
            this.rb_LT.Size = new System.Drawing.Size(66, 22);
            this.rb_LT.TabIndex = 3;
            this.rb_LT.TabStop = true;
            this.rb_LT.Text = "Lễ tân";
            this.rb_LT.UseVisualStyleBackColor = true;
            this.rb_LT.CheckedChanged += new System.EventHandler(this.rb_LT_CheckedChanged);
            // 
            // btn_taoTK
            // 
            this.btn_taoTK.BackColor = System.Drawing.Color.Red;
            this.btn_taoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taoTK.ForeColor = System.Drawing.Color.White;
            this.btn_taoTK.Location = new System.Drawing.Point(24, 293);
            this.btn_taoTK.Name = "btn_taoTK";
            this.btn_taoTK.Size = new System.Drawing.Size(111, 57);
            this.btn_taoTK.TabIndex = 5;
            this.btn_taoTK.Text = "Tạo tài khoản";
            this.btn_taoTK.UseVisualStyleBackColor = false;
            this.btn_taoTK.Click += new System.EventHandler(this.btn_taoTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhân viên:";
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(115, 183);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(186, 26);
            this.cb_manv.TabIndex = 7;
            // 
            // frm_TaoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 372);
            this.Controls.Add(this.btn_taoTK);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TaoTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frm_TaoTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_ttk;
        public System.Windows.Forms.TextBox txt_mk;
        public System.Windows.Forms.RadioButton rb_LT;
        public System.Windows.Forms.RadioButton rb_NQL;
        private System.Windows.Forms.Button btn_taoTK;
        private System.Windows.Forms.CheckBox checkb_hienthimk;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cb_manv;
    }
}