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
    public partial class QLDichVu : Form
    {
        BUS_LOGIC.BU_DV dvd;
        public QLDichVu()
        {
            InitializeComponent();
            dvd = new BUS_LOGIC.BU_DV(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvd.ThemDV();
            dvd.HienTiDV();
        }

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            dvd.HienThiCBBOX();
            dvd.HienTiDV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dvd.SuaDV();
            dvd.HienTiDV();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dvd.XoaDV();
            dvd.HienTiDV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMDV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtTDV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            comboBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtDGDV.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
        }
    }
}
