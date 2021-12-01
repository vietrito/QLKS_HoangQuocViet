using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.BUS_LOGIC
{
    class BU_qlnv
    {
        DATA_ACCESS.DA_qlnv daqlnv;
        GUI.frm_qlnv frmnv;
        ImageConverter converter = new ImageConverter();

        public BU_qlnv(GUI.frm_qlnv f)
        {
            this.frmnv = f;
            this.daqlnv = new DATA_ACCESS.DA_qlnv();
        }

        public void hienthidsnv()
        {
            this.frmnv.dataGridView1.DataSource = this.daqlnv.hienthinv();

            this.frmnv.txt_mnv.DataBindings.Clear();
            this.frmnv.txt_mnv.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "MANV");

            this.frmnv.txt_tnv.DataBindings.Clear();
            this.frmnv.txt_tnv.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "TENNV");

            this.frmnv.cb_bp.DataBindings.Clear();
            this.frmnv.cb_bp.DataBindings.Add("SelectedValue", this.frmnv.dataGridView1.DataSource, "MABP");

            this.frmnv.cb_nql.DataBindings.Clear();
            this.frmnv.cb_nql.DataBindings.Add("SelectedValue", this.frmnv.dataGridView1.DataSource, "MANQL");

            this.frmnv.txt_dc.DataBindings.Clear();
            this.frmnv.txt_dc.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "DIACHI");

            this.frmnv.txt_sdt.DataBindings.Clear();
            this.frmnv.txt_sdt.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "SDT");

            this.frmnv.dtp_ns.DataBindings.Clear();
            this.frmnv.dtp_ns.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource,"NGAYSINH");

            this.frmnv.pb_ha.DataBindings.Clear();
            this.frmnv.pb_ha.DataBindings.Add(new Binding("Image", this.frmnv.dataGridView1.DataSource, "HINHANH", true));
        }

        public void LoadBP()
        {
            this.frmnv.cb_bp.DataSource = daqlnv.hienthibp();
            this.frmnv.cb_bp.DisplayMember = "TENBP";
            this.frmnv.cb_bp.ValueMember = "MABP";
        }

        public void LoadNQL()
        {
            this.frmnv.cb_nql.DataSource = daqlnv.hienthinql();
            this.frmnv.cb_nql.DisplayMember = "TENNQL";
            this.frmnv.cb_nql.ValueMember = "MANQL";
        }

        public void Savenv()
        {
            this.daqlnv.Manv = this.frmnv.txt_mnv.Text;
            this.daqlnv.Tennv = this.frmnv.txt_tnv.Text;
            this.daqlnv.Bp = this.frmnv.cb_bp.SelectedValue.ToString();
            this.daqlnv.Nql = this.frmnv.cb_nql.SelectedValue.ToString();
            this.daqlnv.Diachi = this.frmnv.txt_dc.Text;
            this.daqlnv.Sdt = Int32.Parse(this.frmnv.txt_sdt.Text);
            this.daqlnv.Ngaysinh = DateTime.Parse(this.frmnv.dtp_ns.Text);
            this.daqlnv.Anh = (byte[])converter.ConvertTo(this.frmnv.pb_ha.Image, typeof(byte[]));
            this.daqlnv.Themnv();
        }

        public void Updatenv()
        {
            this.daqlnv.Manv = this.frmnv.txt_mnv.Text;
            this.daqlnv.Tennv = this.frmnv.txt_tnv.Text;
            this.daqlnv.Bp = this.frmnv.cb_bp.SelectedValue.ToString();
            this.daqlnv.Nql = this.frmnv.cb_nql.SelectedValue.ToString();
            this.daqlnv.Diachi = this.frmnv.txt_dc.Text;
            this.daqlnv.Sdt = Int32.Parse(this.frmnv.txt_sdt.Text);
            this.daqlnv.Ngaysinh = DateTime.Parse(this.frmnv.dtp_ns.Text);
            this.daqlnv.Anh = (byte[])converter.ConvertTo(this.frmnv.pb_ha.Image, typeof(byte[]));
            this.daqlnv.Suanv();
        }

        public void Deletenv()
        {
            this.daqlnv.Manv = this.frmnv.txt_mnv.Text;
            this.daqlnv.Xoanv();
        }

        public void Searchnv()
        {
            this.daqlnv.Tk = this.frmnv.txt_tk.Text;
            this.daqlnv.Manv = this.frmnv.txt_mnv.Text;
            this.daqlnv.Tennv = this.frmnv.txt_tnv.Text;
            this.daqlnv.Bp = this.frmnv.cb_bp.SelectedValue.ToString();
            this.daqlnv.Nql = this.frmnv.cb_nql.SelectedValue.ToString();
            this.daqlnv.Diachi = this.frmnv.txt_dc.Text;
            this.daqlnv.Sdt = Int32.Parse(this.frmnv.txt_sdt.Text);
            this.daqlnv.Ngaysinh = DateTime.Parse(this.frmnv.dtp_ns.Text);
            this.daqlnv.Anh = (byte[])converter.ConvertTo(this.frmnv.pb_ha.Image, typeof(byte[]));
            this.daqlnv.timkiemnv();
        }

        public void hienthitk()
        {
            this.frmnv.dataGridView1.DataSource = this.daqlnv.timkiemnv();

            this.frmnv.txt_mnv.DataBindings.Clear();
            this.frmnv.txt_mnv.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "MANV");

            this.frmnv.txt_tnv.DataBindings.Clear();
            this.frmnv.txt_tnv.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "TENNV");

            this.frmnv.cb_bp.DataBindings.Clear();
            this.frmnv.cb_bp.DataBindings.Add("SelectedValue", this.frmnv.dataGridView1.DataSource, "MABP");

            this.frmnv.cb_nql.DataBindings.Clear();
            this.frmnv.cb_nql.DataBindings.Add("SelectedValue", this.frmnv.dataGridView1.DataSource, "MANQL");

            this.frmnv.txt_dc.DataBindings.Clear();
            this.frmnv.txt_dc.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "DIACHI");

            this.frmnv.txt_sdt.DataBindings.Clear();
            this.frmnv.txt_sdt.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "SDT");

            this.frmnv.dtp_ns.DataBindings.Clear();
            this.frmnv.dtp_ns.DataBindings.Add("Text", this.frmnv.dataGridView1.DataSource, "NGAYSINH");

            this.frmnv.pb_ha.DataBindings.Clear();
            this.frmnv.pb_ha.DataBindings.Add(new Binding("Image", this.frmnv.dataGridView1.DataSource, "HINHANH", true));
        }
    }
}
