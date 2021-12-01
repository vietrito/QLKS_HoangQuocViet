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
    public partial class frm_QLDatphong : Form
    {
        XULYDULIEU xl;
        BUS_LOGIC.BU_QLDP b_qldp;
        public frm_QLDatphong()
        {
            InitializeComponent();
            this.b_qldp = new BUS_LOGIC.BU_QLDP(this);
        }

        public void DP_CTDP()
        {
            xl = new XULYDULIEU();

            string sqldp = "select * from DATPHONG";
            string sqlctdp = "select * from CTDP";

            DataTable dtdp = new DataTable();         
            DataTable dtct = new DataTable();

            dtdp = xl.table(sqldp);
            dtct = xl.table(sqlctdp);

            DataSet ds = new DataSet();
            ds.Tables.Add(dtdp);
            ds.Tables.Add(dtct);

            DataRelation Datatablerelation = new DataRelation("Chi tiết đặt phòng", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0], true);
            ds.Relations.Add(Datatablerelation);

            this.dataGrid1.PreferredColumnWidth = 85;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.DataSource = ds.Tables[0];

            txt_mdp.DataBindings.Clear();
            txt_mdp.DataBindings.Add("Text", dataGrid1.DataSource, "MADP");

            txt_tk.DataBindings.Clear();
            txt_tk.DataBindings.Add("Text", dataGrid1.DataSource, "TENKHACH");

            txt_ttdp.DataBindings.Clear();
            txt_ttdp.DataBindings.Add("Text", dataGrid1.DataSource, "THONGTINDP");

            NumUD_slp.DataBindings.Clear();
            NumUD_slp.DataBindings.Add("Text", dataGrid1.DataSource, "SLP");
        }

        private void frm_QLDatphong_Load(object sender, EventArgs e)   
        {
            dp_datenp.Value = DateTime.Today;
            dp_datetp.Value = DateTime.Today;
            qldp();
            this.b_qldp.Hienthi_LP();
            try
            {
                cb_lp.SelectedIndex = -1;
            }
            catch(Exception a)
            {
                Console.WriteLine("nothing", a.Message);
            }
            
        }

        public void qldp()
        {
            xl = new XULYDULIEU();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã phiếu đặt phòng");
            dt.Columns.Add("Ngày nhận phòng");
            dt.Columns.Add("Ngày trả phòng");
            dt.Columns.Add("Tên khách");
            dt.Columns.Add("Số lượng phòng");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Thông tin đặt phòng");

            string sql = "select MADP,LEFT(CONVERT(Datetime, NGAYNHAN, 103),11)as NGAYNHAN,LEFT(CONVERT(Datetime, NGAYTRA, 103),11)as NGAYTRA,TENKHACH,SLP,SDT,THONGTINDP from DATPHONG order by MADP desc ";
            DataTable temp = xl.table(sql);

            for (int i = 0; i < temp.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Mã phiếu đặt phòng"] = temp.Rows[i]["MADP"];
                dr["Ngày nhận phòng"] = temp.Rows[i]["NGAYNHAN"];
                dr["Ngày trả phòng"] = temp.Rows[i]["NGAYTRA"];
                dr["Tên khách"] = temp.Rows[i]["TENKHACH"];
                dr["Số lượng phòng"] = temp.Rows[i]["SLP"];
                dr["Số điện thoại"] = temp.Rows[i]["SDT"];
                dr["Thông tin đặt phòng"] = temp.Rows[i]["THONGTINDP"];
                dt.Rows.Add(dr);
            }
            ////////////////////////////////////////////////////////////////////////////////////////
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
            /////////////////////////////////////////////////////////////////////////////////
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dtct);

            DataRelation Datatablerelation = new DataRelation("Chi tiết đặt phòng", ds.Tables[0].Columns[0], ds.Tables[1].Columns[0], true);
            ds.Relations.Add(Datatablerelation);

            dataGrid1.ReadOnly = true;
            dataGrid1.PreferredColumnWidth = 120;
            dataGrid1.DataSource = ds.Tables[0];
            ////////////////////////////////////////////////////////////////////////////////////
            txt_mdp.DataBindings.Clear();
            txt_mdp.DataBindings.Add("Text", dataGrid1.DataSource, "Mã phiếu đặt phòng");

            dp_datenp.DataBindings.Clear();
            dp_datenp.DataBindings.Add("Value", dataGrid1.DataSource, "Ngày nhận phòng");

            dp_datetp.DataBindings.Clear();
            dp_datetp.DataBindings.Add("Value", dataGrid1.DataSource, "Ngày trả phòng");

            txt_tk.DataBindings.Clear();
            txt_tk.DataBindings.Add("Text", dataGrid1.DataSource, "Tên khách");

            txt_ttdp.DataBindings.Clear();
            txt_ttdp.DataBindings.Add("Text", dataGrid1.DataSource, "Thông tin đặt phòng");

            NumUD_slp.DataBindings.Clear();
            NumUD_slp.DataBindings.Add("Text", dataGrid1.DataSource, "Số lượng phòng");
        }

        private void NumUD_slp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'0' || e.KeyChar>'9')
            {
                if (e.KeyChar != (Char)8)
                {
                    MessageBox.Show("Chỉ nhập số từ 0 -> 9");
                    e.KeyChar = (Char)0;
                }
            }
        }

        private void btn_themdp_Click(object sender, EventArgs e)
        {
            int ngaynhanp = int.Parse(dp_datenp.Value.Day.ToString());
            int ngaytrap = int.Parse(dp_datetp.Value.Day.ToString());
            int thangtrap = int.Parse(dp_datetp.Value.Month.ToString());
            int thangnhanp = int.Parse(dp_datenp.Value.Month.ToString());
            int namnhanp = int.Parse(dp_datenp.Value.Year.ToString());
            int namtrap = int.Parse(dp_datenp.Value.Year.ToString());
            int namhientai = int.Parse(DateTime.Now.Year.ToString());
            int thanghientai = int.Parse(DateTime.Now.Month.ToString());
            int ngayhientai = int.Parse(DateTime.Now.Day.ToString());
            if (namhientai > namnhanp || namhientai > namtrap || (ngayhientai > ngaytrap && thanghientai == thangtrap && namhientai == namtrap) || (ngayhientai > ngaynhanp && thanghientai == thangnhanp && namhientai == namnhanp) || (thanghientai > thangnhanp && namhientai == namnhanp) || (thanghientai > thangtrap && namhientai == namtrap))
            {
                MessageBox.Show("Không thể đặt phong trong quá khứ");
            }
            else
            {
                if ((ngaytrap < ngaynhanp && thangtrap == thangnhanp && namtrap == namnhanp) || (thangtrap < thangnhanp && namnhanp == namtrap) || (namtrap < namnhanp))
                {
                    MessageBox.Show("Không thể trả trước khi nhận phòng");
                }
                else
                {
                    if (ktmadatphong("DP0001") == 0)
                    { txt_mdp.Text = "DP0001"; }
                    else
                    { txt_mdp.Text = MaTuDong("DP"); }

                    if (NumUD_slp.Value == 0)
                    {
                        MessageBox.Show("Số lượng phòng phải khác 0");
                    }
                    else
                    {
                        this.b_qldp.SaveDP();
                        qldp();
                    }
                }
            }
        }

        private void btn_suadp_Click(object sender, EventArgs e)
        {
            int ngaynhanp = int.Parse(dp_datenp.Value.Day.ToString());
            int ngaytrap = int.Parse(dp_datetp.Value.Day.ToString());
            int thangtrap = int.Parse(dp_datetp.Value.Month.ToString());
            int thangnhanp = int.Parse(dp_datenp.Value.Month.ToString());
            int namnhanp = int.Parse(dp_datenp.Value.Year.ToString());
            int namtrap = int.Parse(dp_datenp.Value.Year.ToString());
            int namhientai = int.Parse(DateTime.Now.Year.ToString());
            int thanghientai = int.Parse(DateTime.Now.Month.ToString());
            int ngayhientai = int.Parse(DateTime.Now.Day.ToString());
            if (namhientai > namnhanp || namhientai > namtrap || (ngayhientai > ngaytrap && thanghientai == thangtrap && namhientai == namtrap) || (ngayhientai > ngaynhanp && thanghientai == thangnhanp && namhientai == namnhanp) || (thanghientai > thangnhanp && namhientai == namnhanp) || (thanghientai > thangtrap && namhientai == namtrap))
            {
                MessageBox.Show("Không thể đặt phong trong quá khứ");
            }
            else
            {
                if ((ngaytrap < ngaynhanp && thangtrap == thangnhanp && namtrap == namnhanp) || (thangtrap < thangnhanp && namnhanp == namtrap) || (namtrap < namnhanp))
                {
                    MessageBox.Show("Không thể trả trước khi nhận phòng");
                }
                else
                {
                    if (NumUD_slp.Value == 0)
                    {
                        MessageBox.Show("Số lượng phòng phải khác 0");
                    }
                    else
                    {
                        this.b_qldp.UpdateDP();
                        qldp();
                    }
                }
            }
        }

        private void btn_xoadp_Click(object sender, EventArgs e)
        {
            this.b_qldp.DeleteDP();
            qldp();
        }

        private void cb_lp_SelectedValueChanged(object sender, EventArgs e)
        {
            //cb_P.SelectedIndex = -1;
            //this.b_qldp.Search_P();
            //this.b_qldp.Hienthi_P();
            if (cb_lp.Text.Trim() == "")
                cb_P.DataSource = null;
            else
            {
                cb_P.SelectedIndex = -1;
                this.b_qldp.Search_P();
                this.b_qldp.Hienthi_P();
            }
        }

        public string MaTuDong(string st)
        {
            xl = new XULYDULIEU();
            string s, snew;
            int i;
            string str = "select top 1 MADP from DATPHONG order by MADP desc";
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

        public static int ktmadatphong(string madp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-UNGM53F\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
            string sql = string.Format("select * from DATPHONG where MADP='" + madp + "'");
            SqlCommand cmd = new SqlCommand(sql, con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            DataView dv3 = new DataView(ds.Tables[0]);
            if (dv3.Count != 0) return 1;
            else return 0;
        }

        private void btn_themp_Click(object sender, EventArgs e)
        {
            int ngaynhanp = int.Parse(dp_datenp.Value.Day.ToString());
            int ngaytrap = int.Parse(dp_datetp.Value.Day.ToString());
            int thangtrap = int.Parse(dp_datetp.Value.Month.ToString());
            int thangnhanp = int.Parse(dp_datenp.Value.Month.ToString());
            int namnhanp = int.Parse(dp_datenp.Value.Year.ToString());
            int namtrap = int.Parse(dp_datenp.Value.Year.ToString());
            int namhientai = int.Parse(DateTime.Now.Year.ToString());
            int thanghientai = int.Parse(DateTime.Now.Month.ToString());
            int ngayhientai = int.Parse(DateTime.Now.Day.ToString());
            if (namhientai>namnhanp||namhientai>namtrap||(ngayhientai>ngaytrap&&thanghientai==thangtrap&&namhientai==namtrap)||(ngayhientai>ngaynhanp&&thanghientai==thangnhanp&&namhientai==namnhanp)||(thanghientai>thangnhanp&&namhientai==namnhanp)||(thanghientai>thangtrap&&namhientai==namtrap))
            {
                MessageBox.Show("Không thể đặt phong trong quá khứ");
            }
            else
            {
                if ((ngaytrap<ngaynhanp&&thangtrap==thangnhanp&&namtrap==namnhanp)||(thangtrap<thangnhanp&&namnhanp==namtrap)||(namtrap<namnhanp))
                {
                    MessageBox.Show("Không thể trả trước khi nhận phòng");
                }
                else
                {
                    this.b_qldp.SaveCTDP();
                    qldp();
                    this.b_qldp.UpdatePD();

                    this.b_qldp.Search_P();
                    this.b_qldp.Hienthi_P();
                    if (cb_P.SelectedIndex == -1)
                        cb_P.ResetText();

                    this.b_qldp.SearchPD();
                    this.b_qldp.HienthiPD();
                }
            }
        }

        private void btn_xoap_Click(object sender, EventArgs e)
        {
            if (cb_lp.SelectedIndex != -1)
            {
                this.b_qldp.UpdatePT();
                this.b_qldp.DeleteCTDP();
                qldp();

                this.b_qldp.Search_P();
                this.b_qldp.Hienthi_P();

                this.b_qldp.SearchPD();
                this.b_qldp.HienthiPD();
                if (cb_PD.SelectedIndex == -1)
                    cb_PD.ResetText();
            }
            else
            {
                this.b_qldp.UpdatePT();
                this.b_qldp.DeleteCTDP();
                qldp();

                this.b_qldp.SearchPD();
                this.b_qldp.HienthiPD();
                if (cb_PD.SelectedIndex == -1)
                    cb_PD.ResetText();
            }
        }

        private void txt_mdp_TextChanged(object sender, EventArgs e)
        {
            cb_PD.SelectedIndex = -1;
            this.b_qldp.SearchPD();
            this.b_qldp.HienthiPD();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Trim() == "")
                qldp();
            else
                this.b_qldp.Timkiem();
        }
    }
}
