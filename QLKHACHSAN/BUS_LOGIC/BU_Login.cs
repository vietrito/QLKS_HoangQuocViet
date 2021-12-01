using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_Login
    {
        GUI.frm_dangnhap frmdn;
        DATA_ACCESS.DA_Login dalg;
        public BU_Login(GUI.frm_dangnhap fdn)
        {
            frmdn = fdn;
            dalg = new DATA_ACCESS.DA_Login();
        }
        public void kiemtra()
        {
            this.dalg.Mk = this.frmdn.txt_mk.Text;
            this.dalg.Tdn = this.frmdn.txt_ttk.Text;
            if (this.dalg.kiemtra() == true)
            {
                this.frmdn.Flag = true;
                MessageBox.Show("Dang nhap thanh cong");
                this.frmdn.Close();
            }
            else
                MessageBox.Show("Ten dang nhap hoac mat khau khong ton tai");
        }
    }
}
