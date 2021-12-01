using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_CTHD
    {
        DATA_ACCESS.DA_CTHD da_cthd;
        GUI.frm_CTHD frm_cthd;
        
        public BU_CTHD(GUI.frm_CTHD f)
        {
            this.frm_cthd = f;
            this.da_cthd = new DATA_ACCESS.DA_CTHD();
        }
       
        public void HienthiPT()// hien thi phieu thue
        {
            this.frm_cthd.dataGridView1.DataSource = this.da_cthd.get_PT();

            this.frm_cthd.txt_MK.DataBindings.Clear();
            this.frm_cthd.txt_MK.DataBindings.Add("Text", this.frm_cthd.dataGridView1.DataSource, "MAKH");

            this.frm_cthd.txt_sp.DataBindings.Clear();
            this.frm_cthd.txt_sp.DataBindings.Add("Text", this.frm_cthd.dataGridView1.DataSource, "SOPHIEUTP");
        }

        public void SearchPT()// tim phieu thue
        {
            this.da_cthd.map = this.frm_cthd.txt_P.Text;
            this.da_cthd.get_PT();
        }

        public void HienthiTK()// hien thi ten khach
        {
            this.frm_cthd.cb_TK.DataSource = this.da_cthd.get_TK();
            this.frm_cthd.cb_TK.DisplayMember = "TENKH";
            this.frm_cthd.cb_TK.ValueMember = "TENKH";
        }

        public void SearchTK()// tim ten khach
        {
            this.da_cthd.mak = this.frm_cthd.txt_MK.Text;
            this.da_cthd.get_TK();
        }

        public void HienthiCTDV()// hien thi CTDV
        {
            this.frm_cthd.dataGridView2.DataSource = this.da_cthd.get_CTDV();
        }

        public void SearchCTDV()// tim CTDV
        {
            this.da_cthd.mak = this.frm_cthd.txt_MK.Text;
            this.da_cthd.map = this.frm_cthd.txt_P.Text;
            this.da_cthd.get_CTDV();
        }

        public void HienthiTP()// hien thi tien phong
        {
            DataTable dttp = new DataTable();
            dttp = this.da_cthd.TinhTienP();
            this.frm_cthd.txt_TP.DataBindings.Clear();
            this.frm_cthd.txt_TP.DataBindings.Add("Text",dttp, "TP");
        }

        public void TP()// tinh tien phong
        {
            this.da_cthd.sp = this.frm_cthd.txt_sp.Text;
            this.da_cthd.TinhTienP();
        }

        public void HienthiTDV()
        {
            DataTable dttdv = new DataTable();
            dttdv = this.da_cthd.TinhTienDV();
            this.frm_cthd.txt_TDV.DataBindings.Clear();
            this.frm_cthd.txt_TDV.DataBindings.Add("Text",dttdv,"TDV");
        }

        public void TDV()
        {
            this.da_cthd.map = this.frm_cthd.txt_P.Text;
            this.da_cthd.mak = this.frm_cthd.txt_MK.Text;
            this.da_cthd.TinhTienDV();
        }

        public void SaveHD()
        {
            this.da_cthd.mahd = this.frm_cthd.txt_MHD.Text.Trim();
            this.da_cthd.mak = this.frm_cthd.txt_MK.Text.Trim();
            this.da_cthd.manv = this.frm_cthd.cb_nv.SelectedValue.ToString();
            this.da_cthd.map = this.frm_cthd.txt_P.Text.Trim();
            this.da_cthd.ngayhd = DateTime.Parse(this.frm_cthd.dp_NGAYLHD.Value.ToString());

            if (MessageBox.Show("Bạn muốn lưu hóa đơn?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (this.da_cthd.LuuHD() != 0)
                    MessageBox.Show("Lưu hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("Lưu hóa đơn thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void hienthiNVLT()// hien thi nhan vien le tan
        {
            this.frm_cthd.cb_nv.DataSource = da_cthd.get_NV();
            this.frm_cthd.cb_nv.DisplayMember = "TENNV";
            this.frm_cthd.cb_nv.ValueMember = "MANV";
        }
        public void hienthiHD()
        {
            
        }
    }
}
