using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_QLTK
    {
        DATA_ACCESS.DA_QLTK da_qltk;
        GUI.frm_TaoTK frm_qltk;
        public BU_QLTK(GUI.frm_TaoTK f)
        {
            this.frm_qltk = f;
            this.da_qltk = new DATA_ACCESS.DA_QLTK();
        }

        public void HienthiNV()
        {
            this.frm_qltk.cb_manv.DataSource = this.da_qltk.get_NV();
            this.frm_qltk.cb_manv.ValueMember = "MANV";
            this.frm_qltk.cb_manv.DisplayMember = "MANV";
        }

        public void CreateAcc()
        {
            this.da_qltk.tentk = this.frm_qltk.txt_ttk.Text;
            this.da_qltk.mk = this.frm_qltk.txt_mk.Text;
            this.da_qltk.QUYEN = this.frm_qltk.quyen;
            this.da_qltk.manv = this.frm_qltk.cb_manv.SelectedValue.ToString().Trim();

            if (frm_qltk.txt_ttk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (frm_qltk.txt_mk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (frm_qltk.rb_LT.Checked == false && frm_qltk.rb_NQL.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn quyền !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(MessageBox.Show("Bạn muốn tạo tài khoản?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                if (this.da_qltk.TaoTK() != 0)
                    MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("Tạo tài khoản thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}
