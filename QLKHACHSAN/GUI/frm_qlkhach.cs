using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKHACHSAN.GUI
{
    public partial class frm_qlkhach : Form
    {
        BUS_LOGIC.BU_QLKhach bqlk;
        XULYDULIEU xl;

        public frm_qlkhach()
        {
            InitializeComponent();
            bqlk = new BUS_LOGIC.BU_QLKhach(this);
        }

        private void frm_thuephong_Load(object sender, EventArgs e)
        {
            bqlk.load_khach();
            txt_GenderTG.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ktmakhachhang("KH0001") == 0)//kiểm tra xem trong bảng khachhang đã có khách hàng nào chưa
            { txt_mak.Text = "KH0001"; }
            else
            { txt_mak.Text = MaTuDong("KH"); }
            bqlk.Save();
            bqlk.load_khach();
        }
        public string gender="".Trim();
        private void rb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nam.Checked==true)
            {
                gender = "Male";
            }
        }

        private void rb_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nu.Checked==true)
            {
                gender = "Female";
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bqlk.Delete();
            bqlk.load_khach();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bqlk.Update();

            DataGridViewRow row = dataGridView1.Rows[indexrow];
            //row.Cells[0].Value = txt_mak.Text;
            row.Cells[1].Value = txt_hoten.Text.Trim();
            row.Cells[2].Value = txt_quoctich.Text.Trim();
            row.Cells[3].Value = txt_cmnd.Text.Trim();
            row.Cells[4].Value = txt_pas.Text.Trim();
            row.Cells[5].Value = txt_sdt.Text.Trim();
            row.Cells[6].Value = gender.Trim();
        }

        private void txt_GenderTG_TextChanged(object sender, EventArgs e)
        {
            if (txt_GenderTG.Text.Trim() == "Male")
            {
                rb_nam.Checked = true;
            }
            else
                rb_nu.Checked = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string MaTuDong(string st)
        {
            xl = new XULYDULIEU();
            string s, snew;
            int i;
            string str = "select top 1 MAKH from KHACHHANG order by MAKH desc";
            s = xl.table(str).Rows[0][0].ToString();
            snew = s.Substring(2, 4).ToString(); 
            i = int.Parse(snew);
            i++;
            if (i < 10)
                return st.ToString() + "000" + i.ToString();
            else if (i >= 10 && i < 100)
                return st.ToString() + "00" + i.ToString();
            else if (i >= 100 && i < 1000)
                return st.ToString() + "0" + i.ToString();
            else
                return st.ToString() + i.ToString();
        }

        public static int ktmakhachhang(string makh)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-UNGM53F\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
            string sql = string.Format("select * from KHACHHANG where MAKH='" + makh + "'");
            SqlCommand cmd = new SqlCommand(sql,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            DataView dv3 = new DataView(ds.Tables[0]);
            if (dv3.Count != 0) return 1;
            else return 0;
        }

        int indexrow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexrow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexrow];
                txt_mak.Text = row.Cells[0].Value.ToString();
                txt_hoten.Text = row.Cells[1].Value.ToString();
                txt_quoctich.Text = row.Cells[2].Value.ToString();
                txt_cmnd.Text = row.Cells[3].Value.ToString();
                txt_pas.Text = row.Cells[4].Value.ToString();
                txt_sdt.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(""+ex.Message);
            }
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
