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
    public partial class frm_dangnhap : Form
    {
        BUS_LOGIC.BU_Login blg;
        public frm_dangnhap()
        {
            InitializeComponent();
            blg = new BUS_LOGIC.BU_Login(this);
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
        private Boolean flag = false;

        public bool Flag
        {
            get
            {
                return flag;
            }

            set
            {
                flag = value;
            }
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            blg.kiemtra();
        }
    }
}
