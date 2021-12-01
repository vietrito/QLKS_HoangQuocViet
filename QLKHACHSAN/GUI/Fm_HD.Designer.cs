
namespace QLKHACHSAN.GUI
{
    partial class Fm_HD
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
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colimn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHD
            // 
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.MANV,
            this.MAKH,
            this.MAP,
            this.Colimn1,
            this.NGAYHD});
            this.dgvHD.Location = new System.Drawing.Point(12, 56);
            this.dgvHD.MultiSelect = false;
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.Size = new System.Drawing.Size(776, 344);
            this.dgvHD.TabIndex = 0;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã hóa đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Width = 140;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Width = 110;
            // 
            // MAP
            // 
            this.MAP.DataPropertyName = "MAP";
            this.MAP.HeaderText = "Mã phòng";
            this.MAP.Name = "MAP";
            this.MAP.ReadOnly = true;
            this.MAP.Width = 120;
            // 
            // Colimn1
            // 
            this.Colimn1.DataPropertyName = "DONGIAP";
            this.Colimn1.HeaderText = "Tiền Phòng";
            this.Colimn1.Name = "Colimn1";
            this.Colimn1.ReadOnly = true;
            this.Colimn1.Width = 150;
            // 
            // NGAYHD
            // 
            this.NGAYHD.DataPropertyName = "NGAYHD";
            this.NGAYHD.HeaderText = "Ngày lập hóa đơn";
            this.NGAYHD.Name = "NGAYHD";
            this.NGAYHD.ReadOnly = true;
            this.NGAYHD.Width = 120;
            // 
            // Fm_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHD);
            this.Name = "Fm_HD";
            this.Text = "Fm_HD";
            this.Load += new System.EventHandler(this.Fm_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colimn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHD;
    }
}