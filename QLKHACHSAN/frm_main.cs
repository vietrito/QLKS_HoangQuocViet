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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frm_dangnhap frm_dn= new GUI.frm_dangnhap();
            frm_dn.ShowDialog();
            if (frm_dn.Flag == true )
            {
                men_qldp.Enabled = true;
                men_qlhd.Enabled = true;
                men_qlkh.Enabled = true;
                men_qlnv.Enabled = true;
                men_qlp.Enabled  = true;
                men_tkbc.Enabled = true;
            }
            else
            {
                men_qldp.Enabled = false;
                men_qlhd.Enabled = false;
                men_qlkh.Enabled = false;
                men_qlnv.Enabled = false;
                men_qlp.Enabled =  false;
                men_tkbc.Enabled = false;
                MessageBox.Show("Please login before using The System");
            }
        }

        public void frm_main_Load(object sender, EventArgs e)
        {
            GUI.frm_qlkhach ftp = new GUI.frm_qlkhach();
            for (int i=0;i<10;i++)
            {
                Button btn = new Button();
                btn.Size = new System.Drawing.Size(60, 60);
                btn.BackColor = Color.White;
                btn.Name = "button1";
                btn.Text = "101";
                btn.Click += new EventHandler(b_Click);
                btn.MouseDown += new MouseEventHandler(btn_click);
                //btn.MouseUp += new MouseEventHandler(copyToolStripMenuItem_Click);
                listView1.Controls.Add(btn);

                Button btn1 = new Button();
                btn1.Size = new System.Drawing.Size(60,60);
                btn1.BackColor = Color.White;
                btn1.Location = new Point(61,0);
                btn1.Text = "102";
                listView1.Controls.Add(btn1);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_doimk frm_dmk = new frm_doimk();
            frm_dmk.ShowDialog();
        }

        public void b_Click(object sender, EventArgs e)
        {           
            Button btn1 = (Button)sender;
            GUI.frm_qlkhach frm = new GUI.frm_qlkhach();
            frm.Owner = this;
            frm.ShowDialog();      
        }

        private void btn_click(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                //contextMenuStrip1.Show(e.X+100,e.Y+70);
                contextMenuStrip1.Show(this, new Point(e.X+250, e.Y+40));
            }
        }

        private void men_qlp_Click(object sender, EventArgs e)
        {
        
        }
    }
}
