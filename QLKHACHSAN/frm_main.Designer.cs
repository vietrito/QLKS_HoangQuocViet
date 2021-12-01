namespace QLKHACHSAN
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.men_tk = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qldp = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlp = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlhd = new System.Windows.Forms.ToolStripMenuItem();
            this.men_qlkh = new System.Windows.Forms.ToolStripMenuItem();
            this.men_tkbc = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.men_tk,
            this.men_qldp,
            this.men_qlp,
            this.men_qlnv,
            this.men_qlhd,
            this.men_qlkh,
            this.men_tkbc});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // men_tk
            // 
            this.men_tk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.men_tk.Name = "men_tk";
            this.men_tk.Size = new System.Drawing.Size(69, 20);
            this.men_tk.Text = "Tài khoản";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // men_qldp
            // 
            this.men_qldp.Enabled = false;
            this.men_qldp.Name = "men_qldp";
            this.men_qldp.Size = new System.Drawing.Size(118, 20);
            this.men_qldp.Text = "Quản lý đặt phòng";
            // 
            // men_qlp
            // 
            this.men_qlp.Enabled = false;
            this.men_qlp.Name = "men_qlp";
            this.men_qlp.Size = new System.Drawing.Size(98, 20);
            this.men_qlp.Text = "Quản lý phòng";
            this.men_qlp.Click += new System.EventHandler(this.men_qlp_Click);
            // 
            // men_qlnv
            // 
            this.men_qlnv.Enabled = false;
            this.men_qlnv.Name = "men_qlnv";
            this.men_qlnv.Size = new System.Drawing.Size(115, 20);
            this.men_qlnv.Text = "Quản lý nhân viên";
            // 
            // men_qlhd
            // 
            this.men_qlhd.Enabled = false;
            this.men_qlhd.Name = "men_qlhd";
            this.men_qlhd.Size = new System.Drawing.Size(110, 20);
            this.men_qlhd.Text = "Quản lý  hóa đơn";
            this.men_qlhd.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
            // 
            // men_qlkh
            // 
            this.men_qlkh.Enabled = false;
            this.men_qlkh.Name = "men_qlkh";
            this.men_qlkh.Size = new System.Drawing.Size(125, 20);
            this.men_qlkh.Text = "Quản lý khách hàng";
            // 
            // men_tkbc
            // 
            this.men_tkbc.Enabled = false;
            this.men_tkbc.Name = "men_tkbc";
            this.men_tkbc.Size = new System.Drawing.Size(113, 20);
            this.men_tkbc.Text = "Thống kê báo cáo";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon.jpg");
            this.imageList1.Images.SetKeyName(1, "download.jpg");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(238, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(463, 301);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.copyToolStripMenuItem.Text = "Tính tiền";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 419);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "QUAN LY KHACH SAN";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem men_tk;
        private System.Windows.Forms.ToolStripMenuItem men_qldp;
        private System.Windows.Forms.ToolStripMenuItem men_qlp;
        private System.Windows.Forms.ToolStripMenuItem men_qlnv;
        private System.Windows.Forms.ToolStripMenuItem men_qlkh;
        private System.Windows.Forms.ToolStripMenuItem men_tkbc;
        private System.Windows.Forms.ToolStripMenuItem men_qlhd;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}