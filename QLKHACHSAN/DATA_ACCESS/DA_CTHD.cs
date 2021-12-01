using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_CTHD
    {
        XULYDULIEU xl;
        public DA_CTHD()
        {
            xl = new XULYDULIEU();
        }
        public string map { get; set; }
        public string mak { get; set; }
        public string sp { get; set; }
        public string mahd { get; set; }
        public string manv { get; set; }
        public DateTime ngayhd { get; set; }

        public DataTable get_PT()// lay phieu thue theo phong
        {
            string sql = "select top 1 * from PHIEUTHUEPHONG where MAP='" + this.map + "' order by SOPHIEUTP desc";
            DataTable dtpt = new DataTable();
            dtpt = xl.table(sql);
            return dtpt;
        }

        public DataTable get_TK()// lay ten khach theo ma khach
        {
            string sql = "select TENKH from KHACHHANG where MAKH='" + this.mak + "'";
            DataTable dttk = new DataTable();
            dttk = xl.table(sql);
            return dttk;
        }

        public DataTable get_CTDV()// lay CTDV
        {
            string sql = "select TENDV,MAP,MAKH,MANV,NGAY,SOLUONG,DGDV from CTDV,DICHVU where CTDV.MADV=DICHVU.MADV and MAP='" + this.map + "' and MAKH='" + this.mak + "' ";
            DataTable dtctdv = new DataTable();
            dtctdv = xl.table(sql);
            return dtctdv;
        }

        public DataTable TinhTienP()// tinh tien phong
        {
            string sql = "select DAY(NGAYTRA-NGAYTHUE)*DONGIAP as TP from PHIEUTHUEPHONG,PHONG where SOPHIEUTP='" + this.sp + "' and PHONG.MAP=PHIEUTHUEPHONG.MAP ";
            DataTable dttp = new DataTable();
            dttp = xl.table(sql);
            return dttp;
        }

        public DataTable TinhTienDV()// tinh tien DV
        {
            string sql = "select SUM(DGDV * SOLUONG) as TDV from CTDV,DICHVU where CTDV.MADV=DICHVU.MADV and MAP='" + this.map + "' and MAKH='" + this.mak + "' ";
            DataTable dttdv = new DataTable();
            dttdv = xl.table(sql);
            return dttdv;
        }

        public int LuuHD()// Luu hoa don
        {
            string sql = "insert into HOADON(MAHD,MANV,MAKH,MAP,NGAYHD) values('" + this.mahd + "','" + this.manv + "','" + this.mak + "','" + this.map + "','" + this.ngayhd + "')";
            return xl.ThucThiSql(sql);
        }

        public DataTable get_NV()// lay ten nv le tan
        {
            string sql = "select MANV,TENNV from NHANVIEN where MABP='LT'";
            DataTable dtnv = new DataTable();
            dtnv = xl.table(sql);
            return dtnv;
        }
        public DataTable get_HD()
        {
            string sql = "select MAHD,MANV,MAKH,HOADON.MAP,NGAYHD,TENP,DONGIAP from HOADON join PHONG on HOADON.MAP = PHONG.MAP";
            DataTable dthd = new DataTable();
            dthd = xl.table(sql);
            return dthd;
        }
    }
}
