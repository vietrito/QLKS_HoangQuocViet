using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.GUI
{
    public partial class Fm_HD : Form
    {
        BUS_LOGIC.BU_HD buhd;
        
        public Fm_HD()
        {
            InitializeComponent();
            this.buhd = new BUS_LOGIC.BU_HD(this);
        }

        private void Fm_HD_Load(object sender, EventArgs e)
        {

            buhd.HienThiHD();
        }
    }
}
