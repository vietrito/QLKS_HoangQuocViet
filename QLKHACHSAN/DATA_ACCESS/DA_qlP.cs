using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_qlP
    {
        XULYDULIEU xl;
        public DA_qlP()
        {
            xl = new XULYDULIEU();
        }
        private string map;
        private string tenp;
        private string kieup;
        private string loaip;
        private Double dongia;
        private string ttp;

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

        public string Tenp
        {
            get
            {
                return tenp;
            }

            set
            {
                tenp = value;
            }
        }

        public string Kieup
        {
            get
            {
                return kieup;
            }

            set
            {
                kieup = value;
            }
        }

        public string Loaip
        {
            get
            {
                return loaip;
            }

            set
            {
                loaip = value;
            }
        }

        public double Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public string Ttp
        {
            get
            {
                return ttp;
            }

            set
            {
                ttp = value;
            }
        }
        string sql;
        public DataTable HienthiDSPhong()// hien thi danh sach phong
        {
            sql = "select MAP,TENP,MALP,DONGIAP,TINHTRANGP from PHONG";
            DataTable dtp = new DataTable();
            dtp = xl.table(sql);
            return dtp;
        }

        public DataTable HienthiKP()// hien thi kieu phong
        {
            sql = "select * from KIEUPHONG";
            DataTable dtkp = new DataTable();
            dtkp = xl.table(sql);
            return dtkp;
        }

        public DataTable HienthiLP()// hien thi loai phong
        {
            sql = "select * from LOAIPHONG";
            DataTable dtlp = new DataTable();
            dtlp = xl.table(sql);
            return dtlp;
        }

        public int ThemP()// them moi phong
        {
            sql = "insert into PHONG(MAP,TENP,MALP,DONGIAP,TINHTRANGP)values('" + this.map + "',N'" + this.tenp + "',N'" + this.loaip + "','" + this.dongia + "',N'" + this.ttp + "')";
            return xl.ThucThiSql(sql);
        }

        public int XoaP()// xoa phong
        {
            sql = "delete from PHONG where MAP='" + this.map + "'";
            return xl.ThucThiSql(sql);
        }

        public int SuaP()// sua phong
        {
            sql = "update PHONG set TENP=N'" + this.tenp + "',MALP=N'" + this.loaip + "',DONGIAP='" + this.dongia + "',TINHTRANGP=N'" + this.ttp + "' where MAP='" + this.map + "'";
            return xl.ThucThiSql(sql);
        }

        public DataTable TimkiemP()// tim kiem phong
        {
            sql = "select * from PHONG where MAP like N'%" + this.map + "%'";
            DataTable dttkp = new DataTable();
            dttkp = xl.table(sql);
            return dttkp;
        }
    }
}
