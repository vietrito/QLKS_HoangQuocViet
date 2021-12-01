using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_ChuyenP
    {
        DATA_ACCESS.DA_ChuyenP dacp;
        GUI.frm_ChuyenP frm_cp;
        public BU_ChuyenP(GUI.frm_ChuyenP f)
        {
            this.frm_cp = f;
            this.dacp = new DATA_ACCESS.DA_ChuyenP();
        }
        public void HienthiPT()
        {
            this.frm_cp.cb_PChuyen.DataSource = this.dacp.get_PhongT();
            this.frm_cp.cb_PChuyen.DisplayMember = "TENP";
            this.frm_cp.cb_PChuyen.ValueMember = "MAP";
        }
        public void Update_TTP()
        {
            this.dacp.map = this.frm_cp.txt_P.Text;
            this.dacp.map2 = this.frm_cp.cb_PChuyen.Text;
            this.dacp.CapNhat_TTP();
        }
        public void Update_PT()
        {
            this.dacp.mak = this.frm_cp.txt_MK.Text;
            this.dacp.map = this.frm_cp.txt_P.Text;
            this.dacp.map2 = this.frm_cp.cb_PChuyen.Text;
            this.dacp.CapNhat_PT();
        }
        public void Update_CTDV()
        {
            this.dacp.mak = this.frm_cp.txt_MK.Text;
            this.dacp.map = this.frm_cp.txt_P.Text;
            this.dacp.map2 = this.frm_cp.cb_PChuyen.Text;
            this.dacp.CapNhat_CTDV();
        }
    }
}
