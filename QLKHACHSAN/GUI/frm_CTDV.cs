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
    public partial class frm_CTDV : Form
    {
        BUS_LOGIC.BU_CTDV bctdv;
        public frm_CTDV()
        {
            InitializeComponent();
            this.bctdv = new BUS_LOGIC.BU_CTDV(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frm_CTDV_Load(object sender, EventArgs e)
        {
            dp_ngay.Value = DateTime.Today;
            //bctdv.HienthiPT();
            bctdv.HienthiCTDV();
            bctdv.HienthiLDV();
            bctdv.HienthiDV();
            bctdv.hienthiNVLT();
            txt_id.Hide();
            //dataGridView1.Hide();
        }

        private void btn_themdv_Click(object sender, EventArgs e)
        {
            if (numUD_sl.Value == 0)
            {
                MessageBox.Show("Số lượng phải khác 0");
            }
            else
            {
                bctdv.SaveCTDV();
                bctdv.HienthiCTDV();
            }
        }

        private void btn_suadv_Click(object sender, EventArgs e)
        {
            if (numUD_sl.Value == 0)
            {
                MessageBox.Show("Số lượng phải khác 0");
            }
            else
            {
                bctdv.UpdateCTDV();
                bctdv.HienthiCTDV();
            }
        }

        private void btn_xoadv_Click(object sender, EventArgs e)
        {
            bctdv.DeleteCTDV();
            bctdv.HienthiCTDV();
        }

        private void txt_phong_TextChanged(object sender, EventArgs e)
        {
            bctdv.SearchPT();
            bctdv.HienthiPT();
            bctdv.Seatch_CTDV();
            bctdv.HienthiCTDV();

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void cb_loaidv_TextChanged_1(object sender, EventArgs e)
        {
            bctdv.HienthiDV();
        }

        private void numUD_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (Char)8)
                {
                    MessageBox.Show("Chỉ được nhập số");
                    e.KeyChar = (Char)0;
                }
            }
        }

        private void btnSLDV_Click(object sender, EventArgs e)
        {
            GUI.LoaiDichVu ldv = new GUI.LoaiDichVu();
            ldv.ShowDialog();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            GUI.QLDichVu qldv = new GUI.QLDichVu();
            qldv.ShowDialog();
        }
    }
}
