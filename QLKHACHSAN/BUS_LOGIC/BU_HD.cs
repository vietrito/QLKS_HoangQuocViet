using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_HD
    {

        DATA_ACCESS.DA_CTHD da_cthd;

        GUI.Fm_HD Fm_HD;
        public BU_HD(GUI.Fm_HD f)
        {
            this.Fm_HD = f;
            this.da_cthd = new DATA_ACCESS.DA_CTHD();
        }
        public void HienThiHD()
        {
            this.Fm_HD.dgvHD.DataSource = da_cthd.get_HD();
        }
        
    }
}
