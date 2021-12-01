using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_ChuyenP
    {
        XULYDULIEU xl;
        public DA_ChuyenP()
        {
            xl = new XULYDULIEU();
        }
        public string map { get; set; }
        public string mak { get; set; }
        public string map2 { get; set; }
        string sql;
        public int CapNhat_TTP()// Cap nhat trang thai phong
        {
            sql = "UPDATE PHONG"+
                    " SET TINHTRANGP = Case MAP"+
                    " WHEN '" + this.map + "' THEN N'Phòng trống'"+
                    " WHEN '" + this.map2 + "' THEN N'Phòng có khách'"+
                    " END"+
                    " WHERE MAP IN ('" + this.map + "', '" + this.map2 + "')";
            return xl.ThucThiSql(sql);
        }

        public int CapNhat_PT()// Cap nhat ma phong phieu thue
        {
            sql = "update PHIEUTHUEPHONG set MAP='" + this.map2 + "' where MAP='" + this.map + "' and MAKH='" + this.mak + "'";
            return xl.ThucThiSql(sql);
        }

        public int CapNhat_CTDV()// Cap nhat ma phong CTDV
        {
            sql = "update CTDV set MAP='" + this.map2 + "' where MAP='" + this.map + "' and MAKH='" + this.mak + "' ";
            return xl.ThucThiSql(sql);
        }

        public DataTable get_PhongT()
        {
            sql = "select MAP,TENP from PHONG where TINHTRANGP=N'Phòng trống'"; 
            DataTable dtpt = new DataTable();
            dtpt = xl.table(sql);
            return dtpt;
        }
    }
}
