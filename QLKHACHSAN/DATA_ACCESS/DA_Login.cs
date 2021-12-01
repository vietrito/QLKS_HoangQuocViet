using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_Login
    {
        XULYDULIEU xl;
        private string tdn;
        private string mk;

        public string Tdn
        {
            get
            {
                return tdn;
            }

            set
            {
                tdn = value;
            }
        }

        public string Mk
        {
            get
            {
                return mk;
            }

            set
            {
                mk = value;
            }
        }

        public DA_Login()
        {
            xl = new XULYDULIEU();
        }

       public Boolean kiemtra()
        {
            string SQL = "select * from TKNGUOIDUNG "
                        + "WHERE TENTK='" + this.tdn + "'"
                        + "and MATKHAU='" + GetMD5(this.mk) + "'";
            if (xl.table(SQL).Rows.Count != 0)
            {
                frm_text.quyen = xl.table("select QUYEN from TKNGUOIDUNG where TENTK='" + this.tdn + "' and MATKHAU='" + GetMD5(this.mk) + "'").Rows[0][0].ToString().Trim();
                frm_text.user = xl.table("select TENTK from TKNGUOIDUNG where TENTK='" + this.tdn + "' and MATKHAU='" + GetMD5(this.mk) + "'").Rows[0][0].ToString().Trim();
                return true;
            }                    
            else
                return false;
        }

        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
    }
}
