using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_CTDV
    {
        XULYDULIEU xl;
        public DA_CTDV()
        {
            xl = new XULYDULIEU();
        }

        private int id;
        private string map;
        private string mak;
        private string manv;
        private string madv;
        private DateTime ngay;
        private int sl;
        private string maldv;

        public string Map
        {
            get
            {
                return map;
            }

            set
            {
                map = value;
            }
        }

        public string Mak
        {
            get
            {
                return mak;
            }

            set
            {
                mak = value;
            }
        }

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

        public string Madv
        {
            get
            {
                return madv;
            }

            set
            {
                madv = value;
            }
        }

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public int Sl
        {
            get
            {
                return sl;
            }

            set
            {
                sl = value;
            }
        }

        public string Maldv
        {
            get
            {
                return maldv;
            }

            set
            {
                maldv = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DataTable get_NVLT() // lay ten nhan vien le tan
        {
            string sql = "select MANV,TENNV from NHANVIEN where MABP='LT'";
            DataTable dtnv = new DataTable();
            dtnv = xl.table(sql);
            return dtnv;
        }

        public DataTable get_LDV() // lay loai dich vu
        {
            string sql = "select MALOAIDV,TENLOAIDV from LOAIDV";
            DataTable dtldv = new DataTable();
            dtldv = xl.table(sql);
            return dtldv;
        }

        public DataTable get_DV() // lay ten dich vu
        {
            string sql = "select MADV,TENDV from DICHVU where MALOAIDV='" + this.maldv + "'";
            DataTable dtdv = new DataTable();
            dtdv = xl.table(sql);
            return dtdv;
        }

        public DataTable get_PT()// lay phieu thue theo phong
        {
            string sql = "select top 1 * from PHIEUTHUEPHONG where MAP='" + this.map + "' order by SOPHIEUTP desc";
            DataTable dtpt = new DataTable();
            dtpt = xl.table(sql);
            return dtpt;
        }

        public DataTable get_CTDV()// lay chi tiet dich vu
        {
            string sql = "select id,CTDV.MADV,MAP,MAKH,MANV,LEFT(CONVERT(datetime, NGAY, 103),11) as NGAY,SOLUONG,DICHVU.MALOAIDV from CTDV,DICHVU where CTDV.MADV=DICHVU.MADV and CTDV.MAP='" + this.map + "' and CTDV.MAKH='" + this.mak + "'";
            DataTable dtctdv = new DataTable();
            dtctdv = xl.table(sql);
            return dtctdv;
        }

        public int ThemCTDV()// them CTDV
        {
            string sql = "insert into CTDV(MADV,MAP,MAKH,MANV,NGAY,SOLUONG) values('" + this.madv + "','" + this.map + "','" + this.mak + "','" + this.manv + "','" + this.ngay + "','" + this.sl + "')";
            return xl.ThucThiSql(sql);
        }

        public int XoaCTDV()// xoa CTDV
        {
            string sql = "delete from CTDV where id='" + this.id + "' ";
            return xl.ThucThiSql(sql);
        }

        public int SuaCTDV()// sua CTDV
        {
            string sql = "update CTDV set MANV='" + this.manv + "',SOLUONG='" + this.sl + "',MADV='" + this.madv + "' where id='" + this.id + "' ";
            return xl.ThucThiSql(sql);
        }
    }
}
