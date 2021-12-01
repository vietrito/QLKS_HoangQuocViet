using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_DoiPas
    {
        XULYDULIEU xl;
        public DA_DoiPas()
        {
            xl = new XULYDULIEU();
        }
        public string tentk { get; set; }
        public string mk { get; set; }

        public int DoiMK()
        {
            string sql = "update TKNGUOIDUNG set MATKHAU='" + GetMD5(this.mk) + "'where TENTK='" + this.tentk + "'";
            return xl.ThucThiSql(sql);
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
