using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKHACHSAN.GUI
{
    public partial class frm_CTHD : Form
    {
        BUS_LOGIC.BU_CTHD bcthd;
        public frm_CTHD()
        {
            InitializeComponent();
            this.bcthd = new BUS_LOGIC.BU_CTHD(this);
        }

        private void frm_CTHD_Load(object sender, EventArgs e)
        {
            this.cb_TK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_TK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

            txt_sp.Hide();

            dp_NGAYLHD.Text = DateTime.Now.ToString();

            dp_NGAYLHD.Value = DateTime.Today;

            bcthd.hienthiNVLT();
        }

        private void txt_P_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_MK_TextChanged(object sender, EventArgs e)
        {
            bcthd.SearchTK();
            bcthd.HienthiTK();

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        public void TongTien()// Method tinh tong tien
        {
            int a = Int32.Parse(txt_TP.Text);
            //txt_TP.Text = a.ToString("C");
            txt_TP.Text = string.Format("{0:0,000 VND}", double.Parse(txt_TP.Text));
            if (txt_TDV.Text != "")
            {
                int b = Int32.Parse(txt_TDV.Text);
                txt_TDV.Text = b.ToString("0,000 VND");
                txt_TT.Text = (a + b).ToString("0,000 VND");
            }
            else
            {
                txt_TT.Text = a.ToString("0,000 VND");
                txt_TDV.Text = "0";
            }
        }

        public static string CreateKey(string tiento)// Method tao ma hoa don
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        public static string ConvertTimeTo24(string hour)// Method chuyen doi thoi gian
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        private void btn_LHD_Click(object sender, EventArgs e)// Action lap hoa don
        {
            txt_MHD.Text = CreateKey("HD");

            bcthd.SearchPT();
            bcthd.HienthiPT();

            bcthd.SearchCTDV();
            bcthd.HienthiCTDV();

            bcthd.TP();
            bcthd.HienthiTP();

            bcthd.TDV();
            bcthd.HienthiTDV();

            TongTien();

            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void btn_InHD_Click(object sender, EventArgs e)// Action print hoa don
        {
            PrintDocument PD = new PrintDocument();

            PD.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateMHD);

            PD.Print();
        }

        private void CreateMHD(object sender, System.Drawing.Printing.PrintPageEventArgs e)// Method print hoa don
        {
            Graphics gra = e.Graphics;
            Font font = new Font("Times New Roman", 13);
            float FoneHight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            gra.DrawString("HOTEL MANAGEMENT", new Font("Times New Roman", 18), new SolidBrush(Color.Black), startX + 300, startY);
            gra.DrawString("---------- HÓA  ĐƠN ----------", new Font("Times New Roman", 16), new SolidBrush(Color.Black), startX + 300, startY + offset);

            offset = offset + (int)FoneHight;
            string mhd = "MÃ HÓA ĐƠN:";
            gra.DrawString(mhd, font, new SolidBrush(Color.Black), startX + 300, startY + offset * 2);
            gra.DrawString(txt_MHD.Text, font, new SolidBrush(Color.Black), startX + 440, startY + offset * 2);

            offset = offset + (int)FoneHight;
            string tk = "TÊN KHÁCH:";
            gra.DrawString(tk, font, new SolidBrush(Color.Black), startX + 300, startY + offset * 2);
            gra.DrawString(cb_TK.Text, font, new SolidBrush(Color.Black), startX + 440, startY + offset * 2);

            offset = offset + (int)FoneHight;
            string p = "PHÒNG:";
            gra.DrawString(p, font, new SolidBrush(Color.Black), startX + 300, startY + offset * 2);
            gra.DrawString(txt_P.Text, font, new SolidBrush(Color.Black), startX + 440, startY + offset * 2);
            offset = offset + (int)FoneHight;
            DataGridViewRow row = dataGridView1.Rows[0];
            gra.DrawString("NGÀY THUÊ:", font, Brushes.Black, startX + 300, startY + offset * 2);
            gra.DrawString(Convert.ToString(row.Cells["Column4"].Value), font, Brushes.Black, startX + 440, startY + offset * 2);
            offset = offset + (int)FoneHight;
            gra.DrawString("NGÀY TRẢ:", font, Brushes.Black, startX + 300, startY + offset * 2);
            gra.DrawString(Convert.ToString(row.Cells["Column6"].Value), font, Brushes.Black, startX + 440, startY + offset * 2);

            offset = offset + (int)FoneHight;
            string tp = "TIỀN PHÒNG:";
            gra.DrawString(tp, font, new SolidBrush(Color.Black), startX + 300, startY + offset * 2);
            gra.DrawString(txt_TP.Text, font, new SolidBrush(Color.Black), startX + 440, startY + offset * 2);

            if (dataGridView2.Rows.Count-1 > 0)
            {
                offset = offset + (int)FoneHight;
                gra.DrawString("CHI TIẾT DỊCH VỤ", new Font("Times New Roman", 13), Brushes.Black, startX + 300, startY + offset * 2);

                offset = offset + (int)FoneHight;
                e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 200, startY + offset * 2 + 16, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                gra.DrawString(Column8.HeaderText, new Font("Times New Roman", 11), new SolidBrush(Color.Black), startX + 200, startY + offset * 2 + 17);

                e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 284, startY + offset * 2 + 16, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                gra.DrawString(Column9.HeaderText, new Font("Times New Roman", 11), new SolidBrush(Color.Black), startX + 284, startY + offset * 2 + 17);

                e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 368, startY + offset * 2 + 16, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                gra.DrawString(Column11.HeaderText, new Font("Times New Roman", 11), new SolidBrush(Color.Black), startX + 368, startY + offset * 2 + 17);

                e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 452, startY + offset * 2 + 16, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                gra.DrawString(Column12.HeaderText, new Font("Times New Roman", 11), new SolidBrush(Color.Black), startX + 452, startY + offset * 2 + 17);

                e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 536, startY + offset * 2 + 16, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                gra.DrawString(Column13.HeaderText, new Font("Times New Roman", 11), new SolidBrush(Color.Black), startX + 536, startY + offset * 2 + 17);

                e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 620, startY + offset * 2 + 16, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                gra.DrawString(Column14.HeaderText, new Font("Times New Roman", 11), new SolidBrush(Color.Black), startX + 620, startY + offset * 2 + 17);


            

                offset = offset + (int)FoneHight;
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) // print datagridview
                {
                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 200, startY + offset * 2, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                    e.Graphics.DrawString(dataGridView2.Rows[i].Cells[0].FormattedValue.ToString(), new Font("Times New Roman", 11), Brushes.Black, startX + 200, startY + offset * 2);

                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 284, startY + offset * 2, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                    e.Graphics.DrawString(dataGridView2.Rows[i].Cells[1].FormattedValue.ToString(), new Font("Times New Roman", 11), Brushes.Black, startX + 284, startY + offset * 2);

                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 368, startY + offset * 2, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                    e.Graphics.DrawString(dataGridView2.Rows[i].Cells[3].FormattedValue.ToString(), new Font("Times New Roman", 11), Brushes.Black, startX + 368, startY + offset * 2);

                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 452, startY + offset * 2, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                    e.Graphics.DrawString(dataGridView2.Rows[i].Cells[4].FormattedValue.ToString(), new Font("Times New Roman", 11), Brushes.Black, startX + 452, startY + offset * 2);

                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 536, startY + offset * 2, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                    e.Graphics.DrawString(dataGridView2.Rows[i].Cells[5].FormattedValue.ToString(), new Font("Times New Roman", 11), Brushes.Black, startX + 536, startY + offset * 2);

                    e.Graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(startX + 620, startY + offset * 2, dataGridView2.Columns[0].Width, dataGridView2.Rows[0].Height));
                    e.Graphics.DrawString(dataGridView2.Rows[i].Cells[6].FormattedValue.ToString(), new Font("Times New Roman", 11), Brushes.Black, startX + 620, startY + offset * 2);

                    offset = offset + 11;
                }
            }
            offset = offset + (int)FoneHight;
            gra.DrawString("TIỀN DỊCH VỤ:", font, Brushes.Black, startX + 300, startY + offset * 2);
            gra.DrawString(txt_TDV.Text, font, Brushes.Black, startX + 440, startY + offset * 2);

            offset = offset + (int)FoneHight;
            gra.DrawString("TỔNG TIỀN:", font, Brushes.Black, startX + 300, startY + offset * 2);
            gra.DrawString(txt_TT.Text, font, Brushes.Black, startX + 440, startY + offset * 2);
            
            
        }

        public void Capnhat_PT()// Method cap nhat trang thai phong trong
        {        
                XULYDULIEU xl = new XULYDULIEU();
                string sql = "update PHONG set TINHTRANGP=N'Phòng trống' where MAP='" + txt_P.Text + "' ";
                xl.ThucThiSql(sql);
        }

        private void btn_LuuHD_Click(object sender, EventArgs e)// Action luu hoa don
        {
            bcthd.SaveHD();
            Capnhat_PT();
            btn_LHD.Enabled = false;
            btn_LuuHD.Enabled = false;
            btn_HuyHD.Enabled = false;
            btn_InHD.Enabled = false;
        }

        private void btn_HuyHD_Click(object sender, EventArgs e)// Action huy hoa don
        {
            txt_MHD.Clear();
            txt_TP.Clear();
            txt_TDV.Clear();
            txt_TT.Clear();
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                dataGridView1.Rows.Remove(dgvr);
            }
            foreach (DataGridViewRow dgvr in dataGridView2.Rows)
            {
                dataGridView2.Rows.Remove(dgvr);
            }
        }
    }
}
