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
    public partial class frm_ChuyenP : Form
    {
        BUS_LOGIC.BU_ChuyenP bcp;
        public frm_ChuyenP()
        {
            InitializeComponent();
            bcp = new BUS_LOGIC.BU_ChuyenP(this);
        }

        public frm_ChuyenP(string str,string st):this()
        {
            txt_MK.Text = str.Trim();
            txt_P.Text = st.Trim();
        }

        private void frm_ChuyenP_Load(object sender, EventArgs e)
        {
            bcp.HienthiPT();
            cb_PChuyen.SelectedIndex = -1;
        }

        private void btn_CP_Click(object sender, EventArgs e)
        {
            bcp.Update_TTP();
            bcp.Update_CTDV();
            bcp.Update_PT();
        }
    }
}
