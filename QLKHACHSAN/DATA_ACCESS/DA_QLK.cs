using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKHACHSAN.DATA_ACCESS
{
    class DA_QLK
    {
        XULYDULIEU xl;
        private string makh;
        private string tenkh;
        private string qt;
        private string cmnd;
        private string pas;
        private string sdt;
        private string gt;

        public string Makh
        {
            get
            {
                return makh;
            }

            set
            {
                makh = value;
            }
        }

        public string Tenkh
        {
            get
            {
                return tenkh;
            }

            set
            {
                tenkh = value;
            }
        }

        public string Qt
        {
            get
            {
                return qt;
            }

            set
            {
                qt = value;
            }
        }

        public string Cmnd
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public string Pas
        {
            get
            {
                return pas;
            }

            set
            {
                pas = value;
            }
        }

        public string Sdt
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

        public string Gt
        {
            get
            {
                return gt;
            }

            set
            {
                gt = value;
            }
        }

        public DA_QLK()
        {
            xl = new XULYDULIEU();
        }

       
    }
}
