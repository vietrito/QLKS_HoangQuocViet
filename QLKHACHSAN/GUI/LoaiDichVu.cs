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
    public partial class LoaiDichVu : Form
    {
        BUS_LOGIC.BU_LDV ldv;
        public LoaiDichVu()
        {
            InitializeComponent();
            ldv = new BUS_LOGIC.BU_LDV(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ldv.ThemLDV();
            ldv.HienThiGRLDV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ldv.XoaLDV();
            ldv.HienThiGRLDV();
        }

        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            ldv.HienThiCBBOX();
            ldv.HienThiGRLDV();
            comboBox1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ldv.SuaLDV();
            ldv.HienThiGRLDV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMLV.Text = comboBox1.SelectedValue.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMLV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtTLV.Text= Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
        }
    }
}
