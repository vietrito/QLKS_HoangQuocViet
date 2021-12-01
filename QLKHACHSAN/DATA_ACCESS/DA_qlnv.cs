using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_qlnv
    {
        XULYDULIEU xl;
        private string manv;
        private string tennv;
        private string bp;
        private string nql;
        private string diachi;
        private long sdt;
        private byte[] anh;
        private DateTime ngaysinh;
        private string tk;

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Tennv
        {
            get
            {
                return tennv;
            }

            set
            {
                tennv = value;
            }
        }

        public string Bp
        {
            get
            {
                return bp;
            }

            set
            {
                bp = value;
            }
        }

        public string Nql
        {
            get
            {
                return nql;
            }

            set
            {
                nql = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public long Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public byte[] Anh
        {
            get
            {
                return anh;
            }

            set
            {
                anh = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Tk
        {
            get
            {
                return tk;
            }

            set
            {
                tk = value;
            }
        }

        public DA_qlnv()
        {
            xl = new XULYDULIEU();
        }

        public DataTable hienthibp()
        {
            string sql = "select * from BOPHAN ";
            DataTable db = new DataTable();
            db = xl.table(sql);
            return db;
        }

        public DataTable hienthinql()
        {
            string sql = "select MANQL,TENNQL from NGUOIQL";
            DataTable dt = new DataTable();
            dt = xl.table(sql);
            return dt;

        }
        public DataTable hienthinv()
        {
            string sql = "select * from NHANVIEN ";
            DataTable tb = new DataTable();
            tb = xl.table(sql);
            return tb;
        }

        public int Themnv()
        {
            string sql = "insert into NHANVIEN(MANV,TENNV,MABP,MANQL,DIACHI,SDT,NGAYSINH,HINHANH) values('" + this.manv + "','" + this.tennv + "','" + this.bp + "','" + this.nql + "','" + this.diachi + "','" + this.sdt + "','"+ this.ngaysinh +"',"+ "@anh" +")";
            return xl.ThucThiinsertImage(sql,anh);
        }

        public DataTable timkiemnv()
        {
            string sql = "select * from NHANVIEN where TENNV like N'%" + this.tk + "%'";
            DataTable dtb = new DataTable();
            dtb = xl.table(sql);
            return dtb;
        }

        public int Xoanv()
        {
            string sql = "delete from NHANVIEN where MANV='" + this.manv + "'";
            return xl.ThucThiSql(sql);
        }

        public int Suanv()
        {
            string sql = "update NHANVIEN set TENNV='" + this.tennv + "',MABP='" + this.bp + "',MANQL='" + this.nql + "',DIACHI='" + this.diachi + "',SDT='" + this.sdt + "',HINHANH="+"@anh"+",NGAYSINH='"+this.ngaysinh+"' where MANV='" + this.manv + "'";
            return xl.ThucThiinsertImage(sql,anh);
        }
    }
}
