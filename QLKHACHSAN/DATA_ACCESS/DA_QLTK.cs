using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_QLTK
    {
        XULYDULIEU xl;
        public DA_QLTK()
        {
            xl = new XULYDULIEU();
        }
        public string tentk { get; set; }
        public string mk { get; set; }
        public string QUYEN { get; set; }
        public string manv { get; set; }

        string sql;
        public int TaoTK()// Tạo tài khoản mới
        {
            sql = "insert into TKNGUOIDUNG(TENTK,MATKHAU,QUYEN,MANV) values('" + this.tentk + "','" + GetMD5(this.mk) + "','" + this.QUYEN + "','" + this.manv + "') ";
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
        public DataTable get_NV()
        {
            sql = "select MANV from NHANVIEN where MANV not in(select MANV from TKNGUOIDUNG ) ";
            DataTable dtnv = new DataTable();
            dtnv = xl.table(sql);
            return dtnv;
        }
    }
}
