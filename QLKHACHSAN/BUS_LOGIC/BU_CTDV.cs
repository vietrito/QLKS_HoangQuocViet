using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKHACHSAN.BUS_LOGIC
{  
    class BU_CTDV
    {
        DATA_ACCESS.DA_CTDV da_ctdv;
        GUI.frm_CTDV frm_ctdv;
        public BU_CTDV(GUI.frm_CTDV f)
        {
            this.frm_ctdv = f;
            this.da_ctdv = new DATA_ACCESS.DA_CTDV();
        }

        public void HienthiPT()// hien thi phieu thue
        {
            this.frm_ctdv.dataGridView1.DataSource = this.da_ctdv.get_PT();

            this.frm_ctdv.txt_khach.DataBindings.Clear();
            this.frm_ctdv.txt_khach.DataBindings.Add("Text", this.frm_ctdv.dataGridView1.DataSource, "MAKH");
        }

        public void HienthiCTDV()// hien thi CTDV
        {
            this.frm_ctdv.dataGridView2.DataSource = this.da_ctdv.get_CTDV();

            this.frm_ctdv.txt_id.DataBindings.Clear();
            this.frm_ctdv.txt_id.DataBindings.Add("Text",this.frm_ctdv.dataGridView2.DataSource,"id");

            this.frm_ctdv.cb_loaidv.DataBindings.Clear();
            this.frm_ctdv.cb_loaidv.DataBindings.Add("SelectedValue", this.frm_ctdv.dataGridView2.DataSource, "MALOAIDV");

            this.frm_ctdv.cb_dv.DataBindings.Clear();
            this.frm_ctdv.cb_dv.DataBindings.Add("SelectedValue", this.frm_ctdv.dataGridView2.DataSource, "MADV");

            this.frm_ctdv.cb_nv.DataBindings.Clear();
            this.frm_ctdv.cb_nv.DataBindings.Add("SelectedValue", this.frm_ctdv.dataGridView2.DataSource, "MANV");

            this.frm_ctdv.dp_ngay.DataBindings.Clear();
            this.frm_ctdv.dp_ngay.DataBindings.Add("Value", this.frm_ctdv.dataGridView2.DataSource, "NGAY");

            this.frm_ctdv.numUD_sl.DataBindings.Clear();
            this.frm_ctdv.numUD_sl.DataBindings.Add("Text", this.frm_ctdv.dataGridView2.DataSource, "SOLUONG");
        }

        public void Seatch_CTDV()
        {
            this.da_ctdv.Map = this.frm_ctdv.txt_phong.Text;
            this.da_ctdv.Mak = this.frm_ctdv.txt_khach.Text;
            this.da_ctdv.get_CTDV();
        }

        public void HienthiLDV()// hien thi loai dv
        {
            this.frm_ctdv.cb_loaidv.DataSource = da_ctdv.get_LDV();
            this.frm_ctdv.cb_loaidv.DisplayMember = "TENLOAIDV";
            this.frm_ctdv.cb_loaidv.ValueMember = "MALOAIDV";
        }

        public void HienthiDV()// hien thi dv
        {
            this.da_ctdv.Maldv = this.frm_ctdv.cb_loaidv.SelectedValue.ToString();
            this.frm_ctdv.cb_dv.DataSource = da_ctdv.get_DV();
            this.frm_ctdv.cb_dv.DisplayMember = "TENDV";
            this.frm_ctdv.cb_dv.ValueMember = "MADV";
        }

        public void hienthiNVLT()
        {
            this.frm_ctdv.cb_nv.DataSource = da_ctdv.get_NVLT();
            this.frm_ctdv.cb_nv.DisplayMember = "TENNV";
            this.frm_ctdv.cb_nv.ValueMember = "MANV";
        }

        public void SaveCTDV()// them ctdv
        {
            this.da_ctdv.Madv = this.frm_ctdv.cb_dv.SelectedValue.ToString();
            this.da_ctdv.Map = this.frm_ctdv.txt_phong.Text;
            this.da_ctdv.Mak = this.frm_ctdv.txt_khach.Text;
            this.da_ctdv.Manv = this.frm_ctdv.cb_nv.SelectedValue.ToString();
            this.da_ctdv.Ngay = DateTime.Parse(this.frm_ctdv.dp_ngay.Value.ToString().Trim());
            this.da_ctdv.Sl = Int32.Parse(this.frm_ctdv.numUD_sl.Value.ToString().Trim());
            //this.frm_ctdv.dp_ngay.Text = DateTime.Now.ToString("MM/dd/yyyy");
            this.da_ctdv.ThemCTDV();
        }

        public void DeleteCTDV()// xoa ctdv
        {
            this.da_ctdv.Id = Int32.Parse(this.frm_ctdv.txt_id.Text);
            this.da_ctdv.XoaCTDV();
        }

        public void UpdateCTDV()// chinh sua ctdv
        {
            this.da_ctdv.Madv = this.frm_ctdv.cb_dv.SelectedValue.ToString();
            //this.da_ctdv.Map = this.frm_ctdv.txt_phong.Text;
            //this.da_ctdv.Mak = this.frm_ctdv.txt_khach.Text;
            this.da_ctdv.Manv = this.frm_ctdv.cb_nv.SelectedValue.ToString();
            this.da_ctdv.Ngay = DateTime.Parse(this.frm_ctdv.dp_ngay.Value.ToString().Trim());
            this.da_ctdv.Sl = Int32.Parse(this.frm_ctdv.numUD_sl.Value.ToString().Trim());
            this.da_ctdv.Id = Int32.Parse(this.frm_ctdv.txt_id.Text);
            this.da_ctdv.SuaCTDV();
        }

        public void SearchPT()
        {
            this.da_ctdv.Map = this.frm_ctdv.txt_phong.Text;
            this.da_ctdv.get_PT();
        }
    }
}
