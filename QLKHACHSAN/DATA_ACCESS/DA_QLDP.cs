using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_QLDP
    {
        XULYDULIEU xl;
        public DA_QLDP()
        {
            xl = new XULYDULIEU();
        }
        public string madp { get; set; }
        public DateTime ngaynp { get; set; }
        public DateTime ngaytp { get; set; }
        public string tenk { get; set; }
        public string sdt { get; set; }
        public string ttdp { get; set; }
        public int slp { get; set; }
        public string lp { get; set; }
        public string map { get; set; }
        string sql;
        public int ThemDP()
        {
            sql = "insert into DATPHONG(MADP,NGAYNHAN,NGAYTRA,TENKHACH,SLP,SDT,THONGTINDP)values('" + this.madp + "','" + this.ngaynp + "','" + this.ngaytp + "',N'" + this.tenk + "','" + this.slp + "','" + this.sdt + "',N'" + this.ttdp + "') ";
            return xl.ThucThiSql(sql);
        }
        public int XoaDP()
        {
            sql = "delete from DATPHONG where MADP='" + this.madp + "'";
            return xl.ThucThiSql(sql);
        }
        public int SuaDP()
        {
            sql = "update DATPHONG set NGAYNHAN='" + this.ngaynp + "',NGAYTRA='" + this.ngaytp + "',TENKHACH=N'" + this.tenk + "',SLP='" + this.slp + "',SDT='" + this.sdt + "',THONGTINDP=N'" + this.ttdp + "'where MADP='" + this.madp + "'";
            return xl.ThucThiSql(sql);
        }
        public DataTable get_LP()
        {
            sql = "select * from LOAIPHONG";
            DataTable dtlp = new DataTable();
            dtlp = xl.table(sql);
            return dtlp;
        }
        public DataTable get_P()
        {
            sql = "select MAP,TENP from PHONG where MALP='" + this.lp + "'and TINHTRANGP=N'Phòng trống'";
            DataTable dtp = new DataTable();
            dtp = xl.table(sql);
            return dtp;
        }
        public int ThemCTDP()
        {
            sql = "insert into CTDP(MADP,MAP) values('" + this.madp + "','" + this.map + "') ";
            return xl.ThucThiSql(sql);
        }
        public int XoaCTDP()
        {
            sql = "delete from CTDP where MADP='" + this.madp + "' and MAP='" + this.map + "' ";
            return xl.ThucThiSql(sql);
        }
        public int CapNhatPD()
        {
            sql = "update PHONG set TINHTRANGP=N'Phòng đặt' where MAP='" + this.map + "'";
            return xl.ThucThiSql(sql);
        }
        public int CapNhatPT()
        {
            sql = "update PHONG set TINHTRANGP=N'Phòng trống' where MAP='" + this.map + "'";
            return xl.ThucThiSql(sql);
        }
        public DataTable get_PD()
        {
            sql = "select MAP from CTDP where MADP='" + this.madp + "'";
            DataTable dtpd = new DataTable();
            dtpd = xl.table(sql);
            return dtpd;
        }
        public DataTable timkiem()
        {
            sql = "select MADP,LEFT(CONVERT(Datetime, NGAYNHAN, 103),11)as NGAYNHAN,LEFT(CONVERT(Datetime, NGAYTRA, 103),11)as NGAYTRA,TENKHACH,SLP,SDT,THONGTINDP from DATPHONG where TENKHACH like N'%" + this.tenk + "%' order by MADP desc ";
            DataTable dttk = new DataTable();
            dttk.Columns.Add("Mã phiếu đặt phòng");
            dttk.Columns.Add("Ngày nhận phòng");
            dttk.Columns.Add("Ngày trả phòng");
            dttk.Columns.Add("Tên khách");
            dttk.Columns.Add("Số lượng phòng");
            dttk.Columns.Add("Số điện thoại");
            dttk.Columns.Add("Thông tin đặt phòng");
            DataTable temp = xl.table(sql);

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dttk.NewRow();
                dr["Mã phiếu đặt phòng"] = temp.Rows[i]["MADP"];
                dr["Ngày nhận phòng"] = temp.Rows[i]["NGAYNHAN"];
                dr["Ngày trả phòng"] = temp.Rows[i]["NGAYTRA"];
                dr["Tên khách"] = temp.Rows[i]["TENKHACH"];
                dr["Số lượng phòng"] = temp.Rows[i]["SLP"];
                dr["Số điện thoại"] = temp.Rows[i]["SDT"];
                dr["Thông tin đặt phòng"] = temp.Rows[i]["THONGTINDP"];
                dttk.Rows.Add(dr);
            }
            ////////////////////////////////////////////////////////////////
            DataTable dtct = new DataTable();
            dtct.Columns.Add("Mã phiếu đặt phòng");
            dtct.Columns.Add("Mã phòng");
            dtct.Columns.Add("Tình trạng");

            string sql2 = "select *from CTDP";
            //DataTable temp2 = xl.table(sql2);
            temp = xl.table(sql2);
            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dtct.NewRow();
                dr["Mã phiếu đặt phòng"] = temp.Rows[i]["MADP"];
                dr["Mã phòng"] = temp.Rows[i]["MAP"];
                dr["Tình trạng"] = temp.Rows[i]["TINHTRANG"];
                dtct.Rows.Add(dr);
            }
            //////////////////////////////////////////////////////////////////////////////
            DataSet ds = new DataSet();
            ds.Tables.Add(dttk);
            ds.Tables.Add(dtct);

            DataRelation Datatablerelation = new DataRelation("Chi tiết đặt phòng", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0], false);
            ds.Relations.Add(Datatablerelation);

            return ds.Tables[0];
        }
    }
}
