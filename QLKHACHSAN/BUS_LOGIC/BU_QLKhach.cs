using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_QLKhach
    {
        DATA_ACCESS.DA_QLK dak;
        GUI.frm_qlkhach gtp;

        public BU_QLKhach(GUI.frm_qlkhach f)
        {
            this.gtp = f;
            this.dak = new DATA_ACCESS.DA_QLK();
        }

        public void load_khach()
        {
            dbDataContext data = new dbDataContext();
            var kh = from p in data.KHACHHANGs select p;
            this.gtp.dataGridView1.DataSource = kh;
            this.gtp.txt_GenderTG.DataBindings.Clear();
            this.gtp.txt_GenderTG.DataBindings.Add("Text", this.gtp.dataGridView1.DataSource, "GIOITINH");

        }

        public void Save()
        {
            dbDataContext data = new dbDataContext();
            KHACHHANG them = new KHACHHANG();
            them.MAKH = this.gtp.txt_mak.Text;
            them.TENKH = this.gtp.txt_hoten.Text;
            them.QUOCTICH = this.gtp.txt_quoctich.Text;
            them.CMND = this.gtp.txt_cmnd.Text;
            them.PASSPORT = this.gtp.txt_pas.Text;
            them.SDT = this.gtp.txt_sdt.Text;
            them.GIOITINH = this.gtp.txt_GenderTG.Text;
            this.gtp.txt_GenderTG.DataBindings.Clear();
            this.gtp.txt_GenderTG.DataBindings.Add("Text", this.gtp.dataGridView1.DataSource, "GIOITINH");
            data.KHACHHANGs.InsertOnSubmit(them);
            data.SubmitChanges();
            load_khach();
        }

        public void Update()
        {
            dbDataContext data = new dbDataContext();
            var capnhat = data.KHACHHANGs.Single(kh => kh.MAKH == this.gtp.txt_mak.Text);
            capnhat.TENKH = this.gtp.txt_hoten.Text;
            capnhat.QUOCTICH = this.gtp.txt_quoctich.Text;
            capnhat.CMND = this.gtp.txt_cmnd.Text;
            capnhat.PASSPORT = this.gtp.txt_pas.Text;
            capnhat.SDT = this.gtp.txt_sdt.Text;
            capnhat.GIOITINH = this.gtp.txt_GenderTG.Text;
            this.gtp.txt_GenderTG.DataBindings.Clear();
            this.gtp.txt_GenderTG.DataBindings.Add("Text", this.gtp.dataGridView1.DataSource, "GIOITINH");
            data.SubmitChanges();
            load_khach();
        }

        public void Delete()
        {
            dbDataContext data = new dbDataContext();
            var xoa = from kh in data.KHACHHANGs where kh.MAKH == this.gtp.txt_mak.Text select kh;
            foreach (var i in xoa)
            {
                data.KHACHHANGs.DeleteOnSubmit(i);
                data.SubmitChanges();
            }
            load_khach();
        }
    }
}
