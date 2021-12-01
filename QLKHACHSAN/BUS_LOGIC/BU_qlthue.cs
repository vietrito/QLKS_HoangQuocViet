using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_qlthue
    {
        DATA_ACCESS.DA_qlthue daqlt;
        GUI.frm_PhieuThue frmqlt;
        public BU_qlthue(GUI.frm_PhieuThue f)
        {
            this.frmqlt = f;
            this.daqlt = new DATA_ACCESS.DA_qlthue();
        }

        public void hienthiDSPT()
        {
        
            this.frmqlt.dataGridView1.DataSource = this.daqlt.hienthiPT();

            this.frmqlt.txt_sp.DataBindings.Clear();
            this.frmqlt.txt_sp.DataBindings.Add("Text", this.frmqlt.dataGridView1.DataSource, "SOPHIEUTP");

            this.frmqlt.cb_NV.DataBindings.Clear();
            this.frmqlt.cb_NV.DataBindings.Add("SelectedValue", this.frmqlt.dataGridView1.DataSource, "MANV");

            

            this.frmqlt.cb_K.DataBindings.Clear();
            this.frmqlt.cb_K.DataBindings.Add("SelectedValue", this.frmqlt.dataGridView1.DataSource, "MAKH");

           

            this.frmqlt.dp_nthue.DataBindings.Clear();
            this.frmqlt.dp_nthue.DataBindings.Add("Value", this.frmqlt.dataGridView1.DataSource, "NGAYTHUE");

            this.frmqlt.dp_ntra.DataBindings.Clear();
            this.frmqlt.dp_ntra.DataBindings.Add("Value", this.frmqlt.dataGridView1.DataSource, "NGAYTRA");
        }// hien thi phieu thue

        public void searchP()// tim kiem phieu thue theo phong
        {
            this.daqlt.map = this.frmqlt.lbl_sop.Text;
            //this.daqlt.mak = this.frmqlt.txt_mk.Text;
            this.daqlt.hienthiPT();
        }
        /// <summary>
        /// 
        /// </summary>
        public void hienthiNVLT()// hien thi nhan vien le tan
        {
            this.frmqlt.cb_NV.DataSource = daqlt.get_NV();
            this.frmqlt.cb_NV.DisplayMember = "TENNV";
            this.frmqlt.cb_NV.ValueMember = "MANV";
        }

        public void hienthiKH()// hien thi ten khach
        {
            this.frmqlt.cb_K.DataSource = daqlt.get_Tenkhach();
            this.frmqlt.cb_K.DisplayMember = "TENKH";
            this.frmqlt.cb_K.ValueMember = "MAKH";
        }

        public void SavePT()// Luu phieu thue
        {
            frm_text frm_text = new frm_text();
            this.daqlt.manv = this.frmqlt.cb_NV.SelectedValue.ToString();
            this.daqlt.mak = this.frmqlt.txt_mk.Text;
            this.daqlt.map = this.frmqlt.lbl_sop.Text;
            this.daqlt.ngaythue = DateTime.Parse(this.frmqlt.dp_nthue.Value.ToString().Trim());
            this.daqlt.ngaytra = DateTime.Parse(this.frmqlt.dp_ntra.Value.ToString().Trim());
            this.daqlt.ThemPT();
        }

        public void DeletePT()// Xoa phieu thue
        {
            this.daqlt.sophieu =Int32.Parse( this.frmqlt.txt_sp.Text);
            this.daqlt.XoaPT();
        }

        public void Hienthi_TTK()// hien thi thong tin khach theo ten khach
        {
            this.frmqlt.dataGridView2.DataSource = this.daqlt.get_TTK();

            this.frmqlt.txt_mk.DataBindings.Clear();
            this.frmqlt.txt_mk.DataBindings.Add("Text", this.frmqlt.dataGridView2.DataSource, "MAKH");
        }

        public void Search_TTK()// tim kiem thong tin khach theo ten khach
        {
            this.daqlt.tenk = this.frmqlt.cb_K.Text;
            this.daqlt.get_TTK();
        }

        public void Hienthi_TTK2()// hien thi thong tin khach ma khach
        {
            this.frmqlt.dataGridView2.DataSource = this.daqlt.get_TTK2();
        }

        public void Search_TTK2()// tim kiem thong tin khach theo ma khach
        {
            this.daqlt.mak = this.frmqlt.txt_mk.Text;
            this.daqlt.get_TTK2();
        }
    }
}
