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
    public partial class frm_TaoTK : Form
    {
        BUS_LOGIC.BU_QLTK bqltk;
        public frm_TaoTK()
        {
            InitializeComponent();
            bqltk = new BUS_LOGIC.BU_QLTK(this);
        }

        public string quyen = "";

        private void rb_LT_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_LT.Checked == true)
                quyen = "LT";
        }

        private void rb_NQL_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_NQL.Checked == true)
                quyen = "admin";
        }

        private void btn_taoTK_Click(object sender, EventArgs e)
        {
            this.bqltk.CreateAcc();
        }

        private void checkb_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkb_hienthimk.Checked == true)
                txt_mk.UseSystemPasswordChar = false;
            else
                txt_mk.UseSystemPasswordChar = true;
        }

        private void frm_TaoTK_Load(object sender, EventArgs e)
        {
            this.bqltk.HienthiNV();
        }
    }
}
