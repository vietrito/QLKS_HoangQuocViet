using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_CTDP
    {
        XULYDULIEU xl;
        public DA_CTDP()
        {
            xl = new XULYDULIEU();
        }

        public string madp { get; set; }
        public string tenk { get; set; }
        public string map { get; set; }
        public string sdt { get; set; }
        public DateTime ngaynhan { get; set; }
        public DateTime ngaytra { get; set; }
        public string manv { get; set; }
        public string makh { get; set; }

        string sql;

        public DataTable get_CTDP()// lay chi tiet dat phong
        {
            sql = "select CTDP.MADP,TENKHACH,SDT,LEFT(CONVERT(Datetime, NGAYNHAN, 103),11)as NGAYNHAN,LEFT(CONVERT(Datetime, NGAYTRA, 103),11)as NGAYTRA from DATPHONG,CTDP where MAP='" + this.map + "' and DATPHONG.MADP=CTDP.MADP order by MADP desc";
            DataTable dt_ctdp = new DataTable();
            dt_ctdp = xl.table(sql);
            return dt_ctdp;
        }

        public int NhanPhong()// nhan phong dat
        {
            sql = "insert into PHIEUTHUEPHONG(MANV,MAKH,MAP,NGAYTHUE,NGAYTRA) values('" + this.manv + "','" + this.makh + "','" + this.map + "','" + this.ngaynhan + "','" + this.ngaytra + "')";
            return xl.ThucThiSql(sql);
        }

        public DataTable TimKiemKH()// tim kiem khach hang
        {
            string sql = "select * from KHACHHANG where TENKH like N'%" + this.tenk + "%'";
            DataTable dtttk = new DataTable();
            dtttk = xl.table(sql);
            return dtttk;
        }

        public DataTable get_NV()// lay ten nv le tan
        {
            string sql = "select MANV,TENNV from NHANVIEN where MABP='LT'";
            DataTable dtnv = new DataTable();
            dtnv = xl.table(sql);
            return dtnv;
        }

        public int HuyPhong()// huy dat phong
        {
            sql = "update PHONG set TINHTRANGP=N'Phòng trống' where MAP='" + map + "' ";
            return xl.ThucThiSql(sql);
        }

        public int CapNhatNP()// cap nhat nhan phong
        {
            sql = "update CTDP set TINHTRANG=N'Đã nhận phòng' where MAP='" + map + "' and MADP='" + madp + "' ";
            return xl.ThucThiSql(sql);
        }

        public int CapNhatHP()// cap nhat huy phong
        {
            sql = "update CTDP set TINHTRANG=N'Hủy đặt phòng' where MAP='" + map + "' and MADP='" + madp + "' ";
            return xl.ThucThiSql(sql);
        }
    }
}
