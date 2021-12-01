namespace QLKHACHSAN.GUI
{
    partial class frm_ChuyenP
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
            this.txt_P = new System.Windows.Forms.TextBox();
            this.cb_PChuyen = new System.Windows.Forms.ComboBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.btn_CP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_P
            // 
            this.txt_P.Enabled = false;
            this.txt_P.Location = new System.Drawing.Point(55, 72);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(100, 20);
            this.txt_P.TabIndex = 0;
            // 
            // cb_PChuyen
            // 
            this.cb_PChuyen.FormattingEnabled = true;
            this.cb_PChuyen.Items.AddRange(new object[] {
            "402",
            "101",
            "102"});
            this.cb_PChuyen.Location = new System.Drawing.Point(290, 71);
            this.cb_PChuyen.Name = "cb_PChuyen";
            this.cb_PChuyen.Size = new System.Drawing.Size(121, 21);
            this.cb_PChuyen.TabIndex = 1;
            // 
            // txt_MK
            // 
            this.txt_MK.Enabled = false;
            this.txt_MK.Location = new System.Drawing.Point(55, 133);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(100, 20);
            this.txt_MK.TabIndex = 0;
            // 
            // btn_CP
            // 
            this.btn_CP.BackColor = System.Drawing.Color.Red;
            this.btn_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CP.ForeColor = System.Drawing.Color.White;
            this.btn_CP.Location = new System.Drawing.Point(55, 202);
            this.btn_CP.Name = "btn_CP";
            this.btn_CP.Size = new System.Drawing.Size(86, 65);
            this.btn_CP.TabIndex = 2;
            this.btn_CP.Text = "Chuyển phòng";
            this.btn_CP.UseVisualStyleBackColor = false;
            this.btn_CP.Click += new System.EventHandler(this.btn_CP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(287, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn phòng muốn chuyển";
            // 
            // frm_ChuyenP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CP);
            this.Controls.Add(this.cb_PChuyen);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_P);
            this.Name = "frm_ChuyenP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển phòng";
            this.Load += new System.EventHandler(this.frm_ChuyenP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_CP;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_P;
        public System.Windows.Forms.ComboBox cb_PChuyen;
        public System.Windows.Forms.TextBox txt_MK;
    }
}