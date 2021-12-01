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
    public partial class frm_CTDP : Form
    {
        BUS_LOGIC.BU_CTDP bctdp;
        public frm_CTDP()
        {
            InitializeComponent();
            bctdp = new BUS_LOGIC.BU_CTDP(this);
        }

        private void frm_CTDP_Load(object sender, EventArgs e)
        {
            bctdp.hienthiNVLT();
        }

        private void txt_pd_TextChanged(object sender, EventArgs e)
        {
            bctdp.Hienthi_CTDP();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            bctdp.SearchKH();
        }

        private void btn_NhanP_Click(object sender, EventArgs e)
        {
            bctdp.UpdateNP();
            bctdp.SavePT();
            dkthue();
        }

        public void dkthue()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "update PHONG set TINHTRANGP=N'Phòng có khách' where MAP='" + txt_pd.Text + "' ";
            xl.ThucThiSql(sql);
        }

        private void btn_HuyP_Click(object sender, EventArgs e)
        {
            bctdp.UpdateHP();
            bctdp.CancelP();
        }
    }
}
