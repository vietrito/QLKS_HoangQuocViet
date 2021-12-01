using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_qlthue
    {
        XULYDULIEU xl;
        public DA_qlthue()
        {
            xl = new XULYDULIEU();
        }
 
        public long sophieu { get; set; }
        public string manv { get; set; }
        public string mak { get; set; }
        public string tenk { get; set; }
        public string map { get; set; }
        public DateTime ngaythue { get; set; }
        public DateTime ngaytra { get; set; }

        public DataTable get_NV()// lay ten nv le tan
        {
            string sql = "select MANV,TENNV from NHANVIEN where MABP='LT'";
            DataTable dtnv = new DataTable();
            dtnv = xl.table(sql);
            return dtnv;
        }

        public DataTable get_TTK()// lay thong tin khach hang theo ten khach
        {
            string sql = "select * from KHACHHANG where TENKH like N'%" + this.tenk + "%'";
            DataTable dtttk = new DataTable();
            dtttk = xl.table(sql);
            return dtttk;
        }

        public DataTable get_TTK2()// lay thong tin khach hang theo ma khach
        {
            string sql = "select * from KHACHHANG where MAKH = '" + this.mak + "'";
            DataTable dtttk = new DataTable();
            dtttk = xl.table(sql);
            return dtttk;
        }

        public DataTable hienthiPT()// hien thi phieu thue theo phong
        {
            string sql = "select top 1 SOPHIEUTP,MANV,MAKH,MAP,LEFT(CONVERT(datetime, NGAYTHUE, 103),11)as NGAYTHUE,LEFT(CONVERT(datetime, NGAYTRA, 103),11)as NGAYTRA from PHIEUTHUEPHONG where MAP='" + this.map + "' order by SOPHIEUTP desc";
            //string sql = "select * from PHIEUTHUEPHONG where MAP='" + this.map + "' and MAKH='" + this.mak + "'";
            DataTable dtpt = new DataTable();
            dtpt = xl.table(sql);
            return dtpt;
        }

        public int ThemPT()// them phieu thue
        {
            string sql = "insert into PHIEUTHUEPHONG(MANV,MAKH,MAP,NGAYTHUE,NGAYTRA) values('" + this.manv + "','" + this.mak + "','" + this.map + "','" + this.ngaythue + "','" + this.ngaytra + "')";
            return xl.ThucThiSql(sql);
        }

        public int XoaPT()
        {
            string sql = "delete from PHIEUTHUEPHONG where SOPHIEUTP='" + this.sophieu + "'";
            return xl.ThucThiSql(sql);
        }

        public DataTable get_Tenkhach()// loc lay ten khach
        {
            string sql = "select MAKH,TENKH from KHACHHANG";
            DataTable dt_tk = new DataTable();
            dt_tk = xl.table(sql);
            return dt_tk;
        }
    }
}
