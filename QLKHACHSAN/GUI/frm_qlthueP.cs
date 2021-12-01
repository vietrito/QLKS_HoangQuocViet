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
    public partial class frm_PhieuThue : Form
    {
        BUS_LOGIC.BU_qlthue bqlt;
        public frm_PhieuThue()
        {
            InitializeComponent();
            this.bqlt = new BUS_LOGIC.BU_qlthue(this);
        }

        private void frm_qlthueP_Load(object sender, EventArgs e)
        {
            dp_nthue.Value = DateTime.Today;
            dp_ntra.Value = DateTime.Today;
            textBox1.Hide();
            this.bqlt.hienthiDSPT();
            this.bqlt.hienthiNVLT();
            this.bqlt.hienthiKH();
            this.cb_K.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_K.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_NV.SelectedIndex = -1;
            cb_K.SelectedIndex = -1;
        }

        private void btn_ThueP(object sender, EventArgs e)// Them phieu thue
        {
            int ntra = int.Parse(dp_ntra.Value.Day.ToString());
            int nthue = int.Parse(dp_nthue.Value.Day.ToString());
            int nht = int.Parse(DateTime.Now.Year.ToString());
            int namtra = int.Parse(dp_ntra.Value.Year.ToString());
            int namthue = int.Parse(dp_ntra.Value.Year.ToString());
            int thangthue = int.Parse(dp_nthue.Value.Month.ToString());
            int thangtra = int.Parse(dp_ntra.Value.Month.ToString());
            int thanghientai = int.Parse(DateTime.Now.Month.ToString());
            int ngayhientai = int.Parse(DateTime.Now.Day.ToString());
            if (nht > namtra || nht > namthue||(thanghientai>thangtra&&nht==namtra)||(thanghientai>thangthue&&nht==namthue)||(ngayhientai>ntra&&thanghientai==thangtra&&nht==namtra)||(ngayhientai>namthue&&thanghientai==thangthue&&nht==namthue))
            {
                MessageBox.Show("Không thể đặt trong quá khứ");
            }
            else
            {


                if ((ntra < nthue&&thangtra==thangthue&&namtra==namthue)||(namtra < namthue)||( thangtra < thangthue && namtra == namthue))
                {
                    MessageBox.Show("Không thể trả trước khi thuê phòng");
                }
                else
                {
                    this.bqlt.SavePT();
                    this.bqlt.hienthiDSPT();
                    dkthue();
                    btn_thueP.Enabled = false;
                }
            }
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            this.bqlt.DeletePT();
            this.bqlt.hienthiDSPT();
        }

        public void dkthue()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "update PHONG set TINHTRANGP=N'Phòng có khách' where MAP='" + label10.Text + "' ";
            xl.ThucThiSql(sql);
        }

        public void tinhtien()
        {
            XULYDULIEU xl = new XULYDULIEU();
            string sql = "update PHONG set TINHTRANGP=0 where MAP=" + label10.Text + " ";
            xl.ThucThiSql(sql);
        }

        private void btn_tinhtien_Click(object sender, EventArgs e)// Tinh tien
        {
            tinhtien();
        }

        private void lbl_sop_TextChanged(object sender, EventArgs e)
        {
            bqlt.searchP();
            bqlt.hienthiDSPT();
        }

        private void cb_K_TextChanged(object sender, EventArgs e)
        {
                this.bqlt.Search_TTK();
                this.bqlt.Hienthi_TTK();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Phòng có khách")
            {
                btn_tinhtien.Enabled = true;
                btn_thueP.Enabled = false;

                txt_mk.DataBindings.Clear();
                txt_mk.DataBindings.Add("Text", dataGridView1.DataSource, "MAKH");

                this.bqlt.Search_TTK2();
                this.bqlt.Hienthi_TTK2();
            }
            else
                cb_K.SelectedIndex = -1;
        }

        private void btn_cp_Click(object sender, EventArgs e)
        {
            GUI.frm_ChuyenP frm_cp = new GUI.frm_ChuyenP(txt_mk.Text,lbl_sop.Text);
            lbl_sop.Text = frm_cp.txt_P.Text;
            this.Close();
            frm_cp.ShowDialog();
        }
    }
}
