using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.GUI
{
    public partial class frm_TKBC : Form
    {
        public object PHONGTableAdapter { get; private set; }

        public frm_TKBC()
        {
            InitializeComponent();
        }

        private void frm_TKBC_Load(object sender, EventArgs e)
        {
           
            
            ChonTK();
            chart1.Hide();
            
        }

        

        private void ChonTK()
        {
            cb_chonTK.DisplayMember = "Text";
            cb_chonTK.ValueMember = "Value";
            cb_chonTK.SelectedIndex = -1;

            cb_chonTK.Items.Add(new { Text = "Thống kê doanh thu phòng", Value = "Thống kê doanh thu phòng" });
            cb_chonTK.Items.Add(new { Text = "Thống kê doanh thu dịch vụ", Value = "Thống kê doanh thu dịch vụ" });
        }

        private void cb_chonTK_TextChanged(object sender, EventArgs e)
        {
            if (cb_chonTK.Text.Trim() == "Thống kê doanh thu phòng")
            {
                this.reportViewer2.Hide();
                this.reportViewer1.Show();
                this.tKDT_PhongTableAdapter.Fill(this.dataSet1.TKDT_Phong);
                this.reportViewer1.RefreshReport();
            }
            else if (cb_chonTK.Text.Trim() == "Thống kê doanh thu dịch vụ")
            {
                this.reportViewer1.Hide();
                this.reportViewer2.Show();
                this.tKDVTableAdapter.Fill2(this.dataSet_TKDV.TKDV);
                this.reportViewer2.RefreshReport();
            }
        }
    }
}
