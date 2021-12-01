using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_LDV
    {
        DATA_ACCESS.DA_QLLDV qlldv;
        GUI.LoaiDichVu loaidichvu;
        public BU_LDV(GUI.LoaiDichVu l)
        {
            this.loaidichvu = l;
            this.qlldv = new DATA_ACCESS.DA_QLLDV();
        }
        public void ThemLDV()
        {
            this.qlldv.maloaidv = this.loaidichvu.txtMLV.Text;
            this.qlldv.tenloaidv = this.loaidichvu.txtTLV.Text;
            
            if(this.qlldv.insertLDV() !=0)
            {
                System.Windows.Forms.MessageBox.Show("Thêm thành công");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Fail");
            }    
        }
        public void XoaLDV()
        {
            this.qlldv.maloaidv = this.loaidichvu.txtMLV.Text;
            this.qlldv.tenloaidv = this.loaidichvu.txtTLV.Text;

            if (this.qlldv.deleteLDV() != 0)
            {
                System.Windows.Forms.MessageBox.Show("Xoá thành công");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Fail");
            }

        }
        public void SuaLDV()
        {

            this.qlldv.maloaidv = this.loaidichvu.txtMLV.Text;
            this.qlldv.tenloaidv = this.loaidichvu.txtTLV.Text;
            DataTable checkDV = new DataTable();
            checkDV = this.qlldv.checkDV();
            if (checkDV.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("Không thể xóa dịch vụ này");

            }
            else
            {

                if (this.qlldv.updateLDV() != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Sửa  thành công");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Fail");
                }
            }

        }
        public void HienThiCBBOX()
        {
            this.loaidichvu.comboBox1.DataSource=this.qlldv.cbLDV();
            this.loaidichvu.comboBox1.DisplayMember = "MALOAIDV";
            this.loaidichvu.comboBox1.ValueMember = "MALOAIDV";
        }
        public void HienThiGRLDV()
        {
            this.loaidichvu.dataGridView1.DataSource = this.qlldv.cbLDV();
        }
        
    }
}
