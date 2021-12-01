using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_QLDP
    {
        DATA_ACCESS.DA_QLDP da_qldp;
        GUI.frm_QLDatphong frm_qldp;
        public BU_QLDP(GUI.frm_QLDatphong f)
        {
            this.frm_qldp = f;
            this.da_qldp = new DATA_ACCESS.DA_QLDP();
        }
        public void SaveDP()
        {
            this.da_qldp.madp = this.frm_qldp.txt_mdp.Text.Trim();
            this.da_qldp.ngaynp = DateTime.Parse(this.frm_qldp.dp_datenp.Value.ToString().Trim());
            this.da_qldp.ngaytp = DateTime.Parse(this.frm_qldp.dp_datetp.Value.ToString().Trim());
            this.da_qldp.tenk = this.frm_qldp.txt_tk.Text.Trim();
            this.da_qldp.sdt = this.frm_qldp.txt_sdt.Text.Trim();
            this.da_qldp.ttdp = this.frm_qldp.txt_ttdp.Text.Trim();
            this.da_qldp.slp = Int32.Parse(this.frm_qldp.NumUD_slp.Value.ToString().Trim());
            this.da_qldp.ThemDP();
        }
        public void DeleteDP()
        {
            this.da_qldp.madp = this.frm_qldp.txt_mdp.Text.Trim();
            this.da_qldp.XoaDP();
        }
        public void UpdateDP()
        {
            this.da_qldp.madp = this.frm_qldp.txt_mdp.Text.Trim();
            this.da_qldp.ngaynp = DateTime.Parse(this.frm_qldp.dp_datenp.Value.ToString().Trim());
            this.da_qldp.ngaytp = DateTime.Parse(this.frm_qldp.dp_datetp.Value.ToString().Trim());
            this.da_qldp.tenk = this.frm_qldp.txt_tk.Text.Trim();
            this.da_qldp.sdt = this.frm_qldp.txt_sdt.Text.Trim();
            this.da_qldp.ttdp = this.frm_qldp.txt_ttdp.Text.Trim();
            this.da_qldp.slp = Int32.Parse(this.frm_qldp.NumUD_slp.Value.ToString().Trim());
            this.da_qldp.SuaDP();
        }
        public void Hienthi_LP()
        {
            this.frm_qldp.cb_lp.DataSource = this.da_qldp.get_LP();
            this.frm_qldp.cb_lp.DisplayMember = "TENLP";
            this.frm_qldp.cb_lp.ValueMember = "MALP";
        }
        public void Hienthi_P()
        {
            this.frm_qldp.cb_P.DataSource = this.da_qldp.get_P();
            this.frm_qldp.cb_P.DisplayMember = "TENP";
            this.frm_qldp.cb_P.ValueMember = "MAP";
        }
        public void Search_P()
        {
            this.da_qldp.lp = this.frm_qldp.cb_lp.SelectedValue.ToString().Trim();
            this.da_qldp.get_P();
        }
        public void SaveCTDP()
        {
            this.da_qldp.madp = this.frm_qldp.txt_mdp.Text.Trim();
            this.da_qldp.map = this.frm_qldp.cb_P.SelectedValue.ToString().Trim();
            this.da_qldp.ThemCTDP();
        }
        public void DeleteCTDP()
        {
            this.da_qldp.madp = this.frm_qldp.txt_mdp.Text.Trim();
            this.da_qldp.map = this.frm_qldp.cb_PD.SelectedValue.ToString().Trim();
            this.da_qldp.XoaCTDP();
        }
        public void UpdatePD()
        {
            this.da_qldp.map = this.frm_qldp.cb_P.SelectedValue.ToString().Trim();
            this.da_qldp.CapNhatPD();
        }
        public void UpdatePT()
        {
            this.da_qldp.map = this.frm_qldp.cb_PD.SelectedValue.ToString().Trim();
            this.da_qldp.CapNhatPT();
        }
        public void HienthiPD()
        {
            this.frm_qldp.cb_PD.DataSource = this.da_qldp.get_PD();
            this.frm_qldp.cb_PD.DisplayMember = "MAP";
            this.frm_qldp.cb_PD.ValueMember = "MAP";
        }
        public void SearchPD()
        {
            this.da_qldp.madp = this.frm_qldp.txt_mdp.Text.Trim();
            this.da_qldp.get_PD();
        }

        public void Timkiem()
        {
            this.da_qldp.tenk = this.frm_qldp.txt_timkiem.Text.Trim();
            this.da_qldp.timkiem();
            this.frm_qldp.dataGrid1.DataSource = this.da_qldp.timkiem();

            this.frm_qldp.txt_mdp.DataBindings.Clear();
            this.frm_qldp.txt_mdp.DataBindings.Add("Text", this.frm_qldp.dataGrid1.DataSource, "Mã phiếu đặt phòng");

            this.frm_qldp.dp_datenp.DataBindings.Clear();
            this.frm_qldp.dp_datenp.DataBindings.Add("Value", this.frm_qldp.dataGrid1.DataSource, "Ngày nhận phòng");

            this.frm_qldp.dp_datetp.DataBindings.Clear();
            this.frm_qldp.dp_datetp.DataBindings.Add("Value", this.frm_qldp.dataGrid1.DataSource, "Ngày trả phòng");

            this.frm_qldp.txt_tk.DataBindings.Clear();
            this.frm_qldp.txt_tk.DataBindings.Add("Text", this.frm_qldp.dataGrid1.DataSource, "Tên khách");

            this.frm_qldp.txt_ttdp.DataBindings.Clear();
            this.frm_qldp.txt_ttdp.DataBindings.Add("Text", this.frm_qldp.dataGrid1.DataSource, "Thông tin đặt phòng");

            this.frm_qldp.NumUD_slp.DataBindings.Clear();
            this.frm_qldp.NumUD_slp.DataBindings.Add("Text", this.frm_qldp.dataGrid1.DataSource, "Số lượng phòng");
        }
    }
}
