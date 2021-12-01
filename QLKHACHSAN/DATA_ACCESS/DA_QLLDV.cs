using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    

    class DA_QLLDV
    {
        XULYDULIEU xuli;
        public DA_QLLDV()
        {
            xuli = new XULYDULIEU();
        }
        public string  maloaidv { get; set; }
        public string tenloaidv { get; set; }
        public string tendv { get; set; }
        public string madv { get; set; }
        public int dongiadv { get; set; }

        public int updateLDV()
        {
            string sql = "update LOAIDV set TENLOAIDV=N'"+this.tenloaidv+"' where MALOAIDV='"+this.maloaidv+"'";
           return xuli.ThucThiSql(sql);
        }
        public int insertLDV()
        {
            string sql = "insert into LOAIDV values('" + this.maloaidv + "',N'" + this.tenloaidv + "')";
            return xuli.ThucThiSql(sql);
        }
        public int deleteLDV()
        {
            string sql = "delete LOAIDV where MALOAIDV='" + this.maloaidv + "'";
            return xuli.ThucThiSql(sql);
        }
        public DataTable cbLDV()
        {
            string sql = "Select * from LoaiDV";
            DataTable cbboxdv = new DataTable();
            cbboxdv = xuli.table(sql);
            return cbboxdv;

        }
        public int deleteDV()
        {
            string sql = "delete DICHVU where MADV='" + this.madv + "'";
            return xuli.ThucThiSql(sql);
        }
        public int insertDV()
        {
            string sql = "insert into DICHVU values('" + this.madv + "','" + this.tendv + "','"+this.maloaidv+"',"+this.dongiadv+")";
            return xuli.ThucThiSql(sql);
        }
        public int updateDV()
        {
            string sql = "update DICHVU set TENDV='" + this.tendv + "',MALOAIDV='"+this.maloaidv+"',DGDV="+this.dongiadv+" where MADV='" + this.madv + "'";
            return xuli.ThucThiSql(sql);
        }
        public DataTable checkDV()
        {
            string sql = "select MADV from CTDV where MADV='"+this.madv+"'";
            DataTable checDV = new DataTable();
            checDV = xuli.table(sql);
            return checDV;
        }
        public DataTable checkTDV()
        {
            string sql = "select MADV from DICHVU where MADV='" + this.madv + "'";
            DataTable checTDV = new DataTable();
            checTDV = xuli.table(sql);
            return checTDV;
        }
        public DataTable viewDV()
        {
            string sql = "select * from DICHVU";
            DataTable viewtb = new DataTable();
            viewtb = xuli.table(sql);
            return viewtb;
        }
    }
}
