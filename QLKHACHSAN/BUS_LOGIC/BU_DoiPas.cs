using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_DoiPas
    {
        DATA_ACCESS.DA_DoiPas da_doipas;
        GUI.frm_DoiPas frm_doipas;
        public BU_DoiPas(GUI.frm_DoiPas f)
        {
            this.frm_doipas = f;
            this.da_doipas = new DATA_ACCESS.DA_DoiPas();
        }

        public void Update_MK()
        {
            this.da_doipas.tentk = this.frm_doipas.txt_ttk.Text;
            this.da_doipas.mk = this.frm_doipas.txt_mk.Text;
            if (frm_doipas.txt_mk.Text == "")
                MessageBox.Show("Bạn phải nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (frm_doipas.txt_mk.Text != frm_doipas.txt_nhaplaimk.Text)
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Bạn muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.da_doipas.DoiMK() != 0)
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    else
                        MessageBox.Show("Đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }  
        }
    }
}
