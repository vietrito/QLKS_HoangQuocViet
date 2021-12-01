using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_CTDP
    {
        DATA_ACCESS.DA_CTDP da_ctdp;
        GUI.frm_CTDP frm_ctdp;
        public BU_CTDP(GUI.frm_CTDP f)
        {
            this.frm_ctdp = f;
            this.da_ctdp = new DATA_ACCESS.DA_CTDP();
        }
        public void Hienthi_CTDP()// hien thi chi tiet dat phong
        {
            this.da_ctdp.map = this.frm_ctdp.txt_pd.Text.Trim();
            this.da_ctdp.get_CTDP();
            DataTable dt = new DataTable();
            dt = this.da_ctdp.get_CTDP();

            this.frm_ctdp.txt_mdp.DataBindings.Clear();
            this.frm_ctdp.txt_mdp.DataBindings.Add("Text", dt, "MADP");

            this.frm_ctdp.txt_tk.DataBindings.Clear();
            this.frm_ctdp.txt_tk.DataBindings.Add("Text", dt, "TENKHACH");

            this.frm_ctdp.txt_sdt.DataBindings.Clear();
            this.frm_ctdp.txt_sdt.DataBindings.Add("Text", dt, "SDT");

            this.frm_ctdp.txt_ngaynhan.DataBindings.Clear();
            this.frm_ctdp.txt_ngaynhan.DataBindings.Add("Text", dt, "NGAYNHAN");

            this.frm_ctdp.txt_ngaytra.DataBindings.Clear();
            this.frm_ctdp.txt_ngaytra.DataBindings.Add("Text", dt, "NGAYTRA");
        }

        public void SavePT()// nhan phong dat
        {
            this.da_ctdp.manv = this.frm_ctdp.cb_nvlt.SelectedValue.ToString().Trim();
            this.da_ctdp.makh = this.frm_ctdp.txt_makh.Text.Trim();
            this.da_ctdp.map = this.frm_ctdp.txt_pd.Text.Trim();
            this.da_ctdp.ngaynhan = DateTime.Parse(this.frm_ctdp.txt_ngaynhan.Text.Trim());
            this.da_ctdp.ngaytra = DateTime.Parse(this.frm_ctdp.txt_ngaytra.Text.Trim());
            if (this.da_ctdp.NhanPhong() == 1)
            {
                MessageBox.Show("Nhận phòng thành công!");
            }
            else
            {
                MessageBox.Show("Nhận phòng thất bại.Thử lại!");
            }
        }

        public void hienthiNVLT()// hien thi nhan vien le tan
        {
            this.frm_ctdp.cb_nvlt.DataSource = da_ctdp.get_NV();
            this.frm_ctdp.cb_nvlt.DisplayMember = "TENNV";
            this.frm_ctdp.cb_nvlt.ValueMember = "MANV";
        }

        public void SearchKH()
        {
            this.da_ctdp.tenk = this.frm_ctdp.txt_timkiem.Text.Trim();
            this.da_ctdp.TimKiemKH();

            this.frm_ctdp.dataGridView1.DataSource = this.da_ctdp.TimKiemKH();

            this.frm_ctdp.txt_makh.DataBindings.Clear();
            this.frm_ctdp.txt_makh.DataBindings.Add("Text", frm_ctdp.dataGridView1.DataSource, "MAKH");
        }

        public void CancelP()
        {
            this.da_ctdp.map = this.frm_ctdp.txt_pd.Text.Trim();
            this.da_ctdp.HuyPhong();
        }

        public void UpdateNP()
        {
            this.da_ctdp.madp = this.frm_ctdp.txt_mdp.Text.Trim();
            this.da_ctdp.map = this.frm_ctdp.txt_pd.Text.Trim();
            this.da_ctdp.CapNhatNP();
        }

        public void UpdateHP()
        {
            this.da_ctdp.madp = this.frm_ctdp.txt_mdp.Text.Trim();
            this.da_ctdp.map = this.frm_ctdp.txt_pd.Text.Trim();
            this.da_ctdp.CapNhatHP();
        }
    }
}
