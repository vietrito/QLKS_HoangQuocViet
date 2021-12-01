using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_qlP
    {
        DATA_ACCESS.DA_qlP daqlp;
        GUI.frm_qlP frm_qlp;
        public BU_qlP(GUI.frm_qlP f)
        {
            this.frm_qlp = f;
            this.daqlp = new DATA_ACCESS.DA_qlP();
        }

        public void ViewDSPhong()// hien thi danh sach phong
        {
            DataTable dtdsp = new DataTable();
            dtdsp = this.daqlp.HienthiDSPhong();
            this.frm_qlp.listView1.Items.Clear();
            int i = 0;
            foreach (DataRow row in dtdsp.Rows)
            {
                this.frm_qlp.listView1.Items.Add(row["MAP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["TENP"].ToString());
                //this.frm_qlp.listView1.Items[i].SubItems.Add(row["MAKP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["MALP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["DONGIAP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["TINHTRANGP"].ToString());
                i++;
            }
            //frm_qlp.txt_mp.DataBindings.Clear();
            //frm_qlp.txt_mp.DataBindings.Add(new Binding("Text", dtdsp, "MAP", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        public void ViewPhongTK()// hien thi danh sach phong tim kiem
        {
            DataTable dttk = new DataTable();
            dttk = this.daqlp.TimkiemP();
            this.frm_qlp.listView1.Items.Clear();
            int i = 0;
            foreach (DataRow row in dttk.Rows)
            {
                this.frm_qlp.listView1.Items.Add(row["MAP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["TENP"].ToString());
                //this.frm_qlp.listView1.Items[i].SubItems.Add(row["MAKP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["MALP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["DONGIAP"].ToString());
                this.frm_qlp.listView1.Items[i].SubItems.Add(row["TINHTRANGP"].ToString());
                i++;
            }
        }

       public void SearchP()
        {
            this.daqlp.Map = this.frm_qlp.txt_tkp.Text;
            this.daqlp.TimkiemP();
        }

        public void SaveP()
        {
            this.daqlp.Map = this.frm_qlp.txt_mp.Text;
            this.daqlp.Tenp = this.frm_qlp.txt_tp.Text;
            //this.daqlp.Kieup = this.frm_qlp.cb_kp.SelectedValue.ToString();
            this.daqlp.Loaip = this.frm_qlp.cb_lp.SelectedValue.ToString();
            this.daqlp.Dongia = Double.Parse(this.frm_qlp.txt_dg.Text);
            this.daqlp.Ttp = this.frm_qlp.cb_ttp.Text.Trim();
            this.daqlp.ThemP();
        }

        public void DeleteP()
        {
            this.daqlp.Map = this.frm_qlp.txt_mp.Text;
            this.daqlp.Tenp = this.frm_qlp.txt_tp.Text;
            //this.daqlp.Kieup = this.frm_qlp.cb_kp.SelectedValue.ToString();
            this.daqlp.Loaip = this.frm_qlp.cb_lp.SelectedValue.ToString();
            this.daqlp.Dongia = Double.Parse(this.frm_qlp.txt_dg.Text);
            this.daqlp.Ttp = this.frm_qlp.cb_ttp.Text;
            this.daqlp.XoaP();
        }

        public void UpdateP()
        {
            this.daqlp.Map = this.frm_qlp.txt_mp.Text;
            this.daqlp.Tenp = this.frm_qlp.txt_tp.Text;
            //this.daqlp.Kieup = this.frm_qlp.cb_kp.SelectedValue.ToString();
            this.daqlp.Loaip = this.frm_qlp.cb_lp.SelectedValue.ToString();
            this.daqlp.Dongia = Double.Parse(this.frm_qlp.txt_dg.Text);
            this.daqlp.Ttp = this.frm_qlp.cb_ttp.Text.Trim();
            this.daqlp.SuaP();
        }

        public void HienthiKP()
        {
            this.frm_qlp.cb_kp.DataSource = daqlp.HienthiKP();
            this.frm_qlp.cb_kp.DisplayMember = "TENKP";
            this.frm_qlp.cb_kp.ValueMember = "MAKP";
        }

        public void HienthiLP()
        {
            this.frm_qlp.cb_lp.DataSource = daqlp.HienthiLP();
            this.frm_qlp.cb_lp.DisplayMember = "TENLP";
            this.frm_qlp.cb_lp.ValueMember = "MALP";
        }
    }
}
