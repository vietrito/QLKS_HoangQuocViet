using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.GUI
{
    public partial class frm_qlP : Form
    {
        BUS_LOGIC.BU_qlP buqlp;
        public frm_qlP()
        {
            InitializeComponent();
            this.buqlp = new BUS_LOGIC.BU_qlP(this);
        }

        private void btn_suaP_Click(object sender, EventArgs e)
        {
            this.buqlp.UpdateP();
            this.buqlp.ViewDSPhong();
            this.buqlp.ViewPhongTK();
        }

        private void btn_themP_Click(object sender, EventArgs e)
        {
            this.buqlp.SaveP();
            this.buqlp.ViewDSPhong();
        }

        private void btn_xoaP_Click(object sender, EventArgs e)
        {
            this.buqlp.DeleteP();
            this.buqlp.ViewDSPhong();
        }

        private void frm_qlP_Load(object sender, EventArgs e)
        {
            this.buqlp.ViewDSPhong();
            this.buqlp.HienthiKP();
            this.buqlp.HienthiLP();
            this.cb_kp.SelectedIndex = -1;
            this.cb_lp.SelectedIndex = -1;
            addttp();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvItem in listView1.SelectedItems)
            {
                txt_mp.Text = lvItem.SubItems[0].Text;
                txt_tp.Text = lvItem.SubItems[1].Text;
                //cb_kp.SelectedValue = lvItem.SubItems[2].Text;
                cb_lp.SelectedValue = lvItem.SubItems[2].Text;
                txt_dg.Text = lvItem.SubItems[3].Text;
                cb_ttp.ResetText();
                cb_ttp.SelectedText = lvItem.SubItems[4].Text.Trim();
            }
        }

        private void txt_tkp_TextChanged(object sender, EventArgs e)
        {
            this.buqlp.SearchP();
            this.buqlp.ViewPhongTK();
        }

        public void addttp()
        {
            cb_ttp.DisplayMember = "Text";
            cb_ttp.ValueMember = "Value";
            cb_ttp.SelectedIndex = -1;

            cb_ttp.Items.Add(new { Text = "Phòng trống", Value = "Phòng trống" });
            cb_ttp.Items.Add(new { Text = "Phòng có khách", Value = "Phòng có khách" });
            cb_ttp.Items.Add(new { Text = "Phòng đặt", Value = "Phòng đặt" });
            cb_ttp.Items.Add(new { Text = "Phòng đang dọn dẹp", Value = "Phòng đang dọn dẹp" });
            cb_ttp.Items.Add(new { Text = "Phòng đang sửa", Value = "Phòng đang sửa" });

            //cb_ttp.DisplayMember = "Text";
            //cb_ttp.ValueMember = "Value";
        }

        private void cb_ttp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
