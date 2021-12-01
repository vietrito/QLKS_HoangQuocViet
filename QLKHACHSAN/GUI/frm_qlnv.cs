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
    public partial class frm_qlnv : Form
    {
        BUS_LOGIC.BU_qlnv bqlnv;
        public frm_qlnv()
        {
            InitializeComponent();
            bqlnv = new BUS_LOGIC.BU_qlnv(this);
        }

        private void frm_qlnv_Load(object sender, EventArgs e)
        {
            cb_bp.SelectedIndex = -1;
            cb_nql.SelectedIndex = -1;
            bqlnv.LoadBP();
            bqlnv.LoadNQL();
            bqlnv.hienthidsnv();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bqlnv.Savenv();
            bqlnv.hienthidsnv();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bqlnv.Updatenv();
            bqlnv.hienthidsnv();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bqlnv.Deletenv();
            bqlnv.hienthidsnv();
        }

        private void pb_ha_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pb_ha.Image = new Bitmap(file.FileName);
            }
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            bqlnv.Searchnv();
            bqlnv.hienthitk();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
