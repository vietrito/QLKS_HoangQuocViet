using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_DV
    {
        DATA_ACCESS.DA_QLLDV qLLDV;
        GUI.QLDichVu dichvu;
        public BU_DV(GUI.QLDichVu d)
        {
            this.dichvu = d;
            this.qLLDV = new DATA_ACCESS.DA_QLLDV();

        }
        public void HienThiCBBOX()
        {
            this.dichvu.comboBox1.DataSource = this.qLLDV.cbLDV();
            this.dichvu.comboBox1.DisplayMember = "MALOAIDV";
            this.dichvu.comboBox1.ValueMember = "MALOAIDV";
        }
        public void SuaDV()
        {
            this.qLLDV.dongiadv = int.Parse(this.dichvu.txtDGDV.Text);
            this.qLLDV.madv = this.dichvu.txtMDV.Text;
            this.qLLDV.tendv = this.dichvu.txtTDV.Text;
            this.qLLDV.maloaidv = this.dichvu.comboBox1.SelectedValue.ToString();
            if(this.qLLDV.updateDV() !=0)
            {
                System.Windows.Forms.MessageBox.Show("Sửa dịch vụ thành công");
                 
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Fail");
            }

        }
        public void XoaDV()
        {
            this.qLLDV.dongiadv = int.Parse(this.dichvu.txtDGDV.Text);
            this.qLLDV.madv = this.dichvu.txtMDV.Text;
            this.qLLDV.tendv = this.dichvu.txtTDV.Text;
            this.qLLDV.maloaidv = this.dichvu.comboBox1.SelectedValue.ToString();
            DataTable checkDV = new DataTable();
            checkDV = this.qLLDV.checkDV();
            if (checkDV.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("Không thể xóa dịch vụ này");

            }
            else
            {
                if (this.qLLDV.deleteDV() != 0)
                {
                    System.Windows.Forms.MessageBox.Show("XÓa dịch vụ thành công");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Fail");
                }
            }
        }
        public void ThemDV()
        {
            this.qLLDV.dongiadv = int.Parse(this.dichvu.txtDGDV.Text);
            this.qLLDV.madv = this.dichvu.txtMDV.Text;
            this.qLLDV.tendv = this.dichvu.txtTDV.Text;
            this.qLLDV.maloaidv = this.dichvu.comboBox1.SelectedValue.ToString();
            DataTable checkTDV = new DataTable();
            checkTDV = this.qLLDV.checkTDV();
            if (checkTDV.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("Đã có loại dịch vụ này");

            }
            else
            {
                if (this.qLLDV.insertDV() != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Thêm dịch vụ thành công");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Fail");
                }
            }
        }
        public void HienTiDV()
        {
            this.dichvu.dataGridView1.DataSource = this.qLLDV.viewDV();
        }
    }
}
