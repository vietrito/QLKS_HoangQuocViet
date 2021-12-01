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
    public partial class frm_DoiPas : Form
    {
        BUS_LOGIC.BU_DoiPas b_doipas;
        public frm_DoiPas()
        {
            InitializeComponent();
            this.b_doipas = new BUS_LOGIC.BU_DoiPas(this);
        }

        //private string _message;

        public frm_DoiPas(string str) : this()// nhận tên user từ form_text
        {
            //_message = str;
            txt_ttk.Text = str;
        }

        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            this.b_doipas.Update_MK();
        }

        private void frm_DoiPas_Load(object sender, EventArgs e)
        {
            //label1.Hide();
            //txt_ttk.Hide();
        }
    }
}
