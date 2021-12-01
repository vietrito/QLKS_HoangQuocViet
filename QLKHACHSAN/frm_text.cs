using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QLKHACHSAN
{
    public partial class frm_text : Form
    {
        public frm_text()
        {
            InitializeComponent();
        }

        public static string quyen;
        public static string user;

        public DataTable get_phong()
        {
            XULYDULIEU xl=new XULYDULIEU();
            string sql = "select MAP,TENP,TINHTRANGP from PHONG where MAP like '1%'";
            DataTable dtb = new DataTable();
            dtb = xl.table(sql);
            return dtb;
        }

        public void ShowTang1()// Hien thi tang 1
        {
            DataTable dt1 = new DataTable();
            dt1 = get_phong();
            Font font = new Font("Times New Roman", 13);
            ListViewGroup tang1 = new ListViewGroup("Tầng 1(Loại phòng Family)", HorizontalAlignment.Left);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt1.Rows[i][1].ToString(), tang1);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt1.Rows[i][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt1.Rows[i][2].ToString());
                ListViewItem status = new ListViewItem(dt1.Rows[i][2].ToString());
                listView1.Groups.Add(tang1);
                if (status.Text == "Phòng trống")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Phòng có khách")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
            }
        }

        public DataTable get_phong2()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "select MAP,TENP,TINHTRANGP from PHONG where MAP like '2%'";
            DataTable dtb = new DataTable();
            dtb = xl.table(sql);
            return dtb;
        }

        public void ShowTang2()// Hien thi tang 2
        {
            DataTable dt2 = new DataTable();
            dt2 = get_phong2();
            ListViewGroup tang2 = new ListViewGroup("Tầng 2(Loại phòng Standard)", HorizontalAlignment.Left);
            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                ListViewItem item = new ListViewItem(dt2.Rows[j][1].ToString(), tang2);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt2.Rows[j][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt2.Rows[j][2].ToString());
                ListViewItem status = new ListViewItem(dt2.Rows[j][2].ToString());
                listView1.Groups.Add(tang2);
                if (status.Text == "Phòng trống")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Phòng có khách")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
            }
        }

        public DataTable get_phong3()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "select MAP,TENP,TINHTRANGP from PHONG where MAP like '3%'";
            DataTable dtb = new DataTable();
            dtb = xl.table(sql);
            return dtb;
        }

        public void ShowTang3()// Hien thi tang 3
        {
            DataTable dt3 = new DataTable();
            dt3 = get_phong3();
            ListViewGroup tang3 = new ListViewGroup("Tầng 3(Loại phòng Superior)", HorizontalAlignment.Left);
            for (int j = 0; j < dt3.Rows.Count; j++)
            {
                ListViewItem item = new ListViewItem(dt3.Rows[j][1].ToString(), tang3);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt3.Rows[j][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt3.Rows[j][2].ToString());
                ListViewItem status = new ListViewItem(dt3.Rows[j][2].ToString());
                listView1.Groups.Add(tang3);
                if (status.Text == "Phòng trống")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Phòng có khách")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
            }
        }

        public DataTable get_phong4()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "select MAP,TENP,TINHTRANGP from PHONG where MAP like '4%'";
            DataTable dtb = new DataTable();
            dtb = xl.table(sql);
            return dtb;
        }

        public void ShowTang4()// Hien thi tang 4
        {
            DataTable dt4 = new DataTable();
            dt4 = get_phong4();
            ListViewGroup tang4 = new ListViewGroup("Tầng 4(Loại phòng Deluxe)", HorizontalAlignment.Left);
            for (int j = 0; j < dt4.Rows.Count; j++)
            {
                ListViewItem item = new ListViewItem(dt4.Rows[j][1].ToString(), tang4);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt4.Rows[j][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt4.Rows[j][2].ToString());
                ListViewItem status = new ListViewItem(dt4.Rows[j][2].ToString());
                listView1.Groups.Add(tang4);
                if (status.Text == "Phòng trống")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Phòng có khách")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
            }
        }

        public DataTable get_phong5()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "select MAP,TENP,TINHTRANGP from PHONG where MAP like '5%'";
            DataTable dtb = new DataTable();
            dtb = xl.table(sql);
            return dtb;
        }

        public void ShowTang5()// Hien thi tang 5
        {
            DataTable dt5 = new DataTable();
            dt5 = get_phong5();
            ListViewGroup tang5 = new ListViewGroup("Tầng 5(Loại phòng Suite)", HorizontalAlignment.Left);
            for (int j = 0; j < dt5.Rows.Count; j++)
            {
                ListViewItem item = new ListViewItem(dt5.Rows[j][1].ToString(), tang5);
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt5.Rows[j][0].ToString());
                ListViewItem.ListViewSubItem tt = new ListViewItem.ListViewSubItem(item, dt5.Rows[j][2].ToString());
                ListViewItem status = new ListViewItem(dt5.Rows[j][2].ToString());
                listView1.Groups.Add(tang5);
                if (status.Text == "Phòng trống")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 1;
                    item.SubItems.Add(tt);
                }
                else if (status.Text == "Phòng có khách")
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 0;
                    item.SubItems.Add(tt);
                }
                else
                {
                    item.SubItems.Add(subitem);
                    listView1.Items.Add(item);
                    item.ImageIndex = 2;
                    item.SubItems.Add(tt);
                }
            }
        }

        public void ShowListView()// Hien thi toan bo phong
        {
            ShowTang1();
            ShowTang2();
            ShowTang3();
            ShowTang4();
            ShowTang5();
        }

        public void frm_text_Load(object sender, EventArgs e) 
        {
            GUI.frm_PhieuThue frm = new GUI.frm_PhieuThue();
            textBox1.Hide();
            lbl_user.Hide();
            lbl_user2.Hide();
            
            try
            {
                ShowListView();
                Timer timer = new Timer();
                timer.Interval = (7500); //1 secs = 2500
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();

                hToolStripMenuItem.Image = imageList2.Images[0];
                men_qlp.Image = imageList2.Images[1];men_qlhd.Image = imageList2.Images[2];men_qlk.Image = imageList2.Images[3];
                men_qldp.Image = imageList2.Images[4];men_qlnv.Image = imageList2.Images[5];
                men_tkbc.Image = imageList2.Images[6];men_qltk.Image = imageList2.Images[7];
            }
            catch(InvalidEnumArgumentException a)
            {
                Console.WriteLine("it's ok", a);
            }
        }

        private void timer_Tick(object sender, EventArgs e) //load lai listview
        {
            try
            {              
                    listView1.Items.Clear();
                    ShowListView();                
            }
            catch(InvalidEnumArgumentException b)
            {
                Console.WriteLine("it's ok", b);
            }
        }

        private Boolean Kiemtra(String forName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(forName))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void men_qlnv_Click(object sender, EventArgs e)
        {
            //if (!Kiemtra("frm_qlnv"))
            //{
                GUI.frm_qlnv frm_qlnv = new GUI.frm_qlnv();
                frm_qlnv.Show();
                //qlnv.MdiParent = this;
                //qlnv.Show();
            //}
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frm_dangnhap frm_Login = new GUI.frm_dangnhap();
            frm_Login.ShowDialog();
            if (frm_Login.Flag)
            {
                lbl_user.Enabled = true;
                lbl_user.Visible = true;
                lbl_user.Text = user + " đang sử dụng hệ thống";
                lbl_user2.Text = user;
                đăngXuấtToolStripMenuItem.Visible = true;
                đổiMậtKhẩuToolStripMenuItem1.Visible = true;
                if (quyen == "admin")
                {
                    men_qldp.Visible = true;men_qlhd.Visible = true;men_qlk.Visible = true;men_qlnv.Visible = true;
                    men_qlp.Visible = true;men_tkbc.Visible = true;men_qltk.Visible = true;panel1.Visible = true;
                    listView1.Enabled = false;listView1.Show();
                }
                if (quyen == "LT")
                {
                    men_qldp.Visible = true;men_qlhd.Visible = true;men_qlk.Visible = true; men_qlnv.Visible = false;
                    men_qlp.Visible = true;men_tkbc.Visible = false;men_qltk.Visible = false;panel1.Visible = true;
                    listView1.Enabled = true;listView1.Show();
                }
            }
        }

        private void men_qlk_Click(object sender, EventArgs e)
        {
            GUI.frm_qlkhach frm_qlk = new GUI.frm_qlkhach();
            frm_qlk.Show();
        }

        private void men_qlp_Click(object sender, EventArgs e)
        {
            GUI.frm_qlP frm_qlp = new GUI.frm_qlP();
            frm_qlp.Show();
        }

        

        private void listView1_MouseClick(object sender, MouseEventArgs e)// click listview
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string d = listView1.SelectedItems[0].SubItems[2].Text;
                textBox1.Text = d.ToString();
            }

            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Show(this, new Point(e.X + 250, e.Y + 40));
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        string a = listView1.SelectedItems[0].SubItems[0].Text;
                        string b = listView1.SelectedItems[0].SubItems[1].Text;
                        string c = listView1.SelectedItems[0].SubItems[2].Text;

                        GUI.frm_PhieuThue frm = new GUI.frm_PhieuThue();

                        if (c.Trim() == "Phòng đặt")
                        {
                            GUI.frm_CTDP frm_ctdp = new GUI.frm_CTDP();
                            frm_ctdp.Show();
                            frm_ctdp.txt_pd.Text = b.ToString();
                        }
                        else
                        {
                            frm.Show();
                        }

                        frm.lbl_sop.Text = b.ToString();
                        frm.label10.Text = b.ToString();
                        //frm.label10.Hide();
                        frm.textBox1.Text = c.ToString();

                        if (c == "Phòng trống")
                        {
                            try
                            {
                                //frm.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(dataGridView1_DataError);
                                //frm.dataGridView1.Rows.RemoveAt(0);
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(string.Format(@"Failed to bind ComboBox. "
                                //+ "Please contact support with this message:"
                                //+ "\n\n" + ex.Message));
                                Console.WriteLine("it's ok", ex);
                            }
                        }

                        //string d = listView1.SelectedItems[0].SubItems[2].Text;
                        //textBox1.Text = d.ToString();

                        //listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                }
            }
            catch (InvalidEnumArgumentException a)
            {
                Console.WriteLine("it's ok", a);
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Phòng có khách")
            {
                dịchVụToolStripMenuItem.Enabled = true;
                tínhTiềnToolStripMenuItem.Enabled = true;
            }
            else
            {
                dịchVụToolStripMenuItem.Enabled = false;
                tínhTiềnToolStripMenuItem.Enabled = false;
            }
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                GUI.frm_CTDV frm_ctdv = new GUI.frm_CTDV();
                frm_ctdv.Show();
                string b = listView1.SelectedItems[0].SubItems[1].Text;
                frm_ctdv.txt_phong.Text = b.ToString();
            }
        }

        public void tinhtien()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string b = listView1.SelectedItems[0].SubItems[1].Text;
                XULYDULIEU xl = new XULYDULIEU();
                string sql = "update PHONG set TINHTRANGP=0 where MAP='" + b.ToString() + "' ";
                xl.ThucThiSql(sql);
            }
        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tinhtien();
            if (listView1.SelectedItems.Count > 0)
            {
                GUI.frm_CTHD frm_cthd = new GUI.frm_CTHD();
                frm_cthd.Show();
                string b = listView1.SelectedItems[0].SubItems[1].Text;
                frm_cthd.txt_P.Text = b.ToString();
            }
        }

        private void men_qltk_Click(object sender, EventArgs e)
        {
            //GUI.frm_QLTK frm_qltk = new GUI.frm_QLTK();
            //frm_qltk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUI.frm_DoiPas frm_doipas = new GUI.frm_DoiPas(lbl_user2.Text);
            frm_doipas.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void men_qldp_Click(object sender, EventArgs e)
        {
            GUI.frm_QLDatphong frm_qldp = new GUI.frm_QLDatphong();
            frm_qldp.ShowDialog();
        }

        private void men_tkbc_Click(object sender, EventArgs e)
        {
            GUI.frm_TKBC frm_tkbc= new GUI.frm_TKBC();
            frm_tkbc.ShowDialog();
        }

        private void hToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            hToolStripMenuItem.DropDown.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frm_TaoTK frm_qltk = new GUI.frm_TaoTK();
            frm_qltk.Show();
        }

        private void men_qltk_MouseEnter(object sender, EventArgs e)
        {
            men_qltk.DropDown.Show(new Point(1, 1));
        }

        private void men_qlhd_Click(object sender, EventArgs e)
        {
            GUI.Fm_HD hd = new GUI.Fm_HD();
            hd.Show();
        }
    }
}
