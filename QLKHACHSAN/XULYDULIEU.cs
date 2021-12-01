using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKHACHSAN
{
    class XULYDULIEU
    {
        SqlConnection con;
        public XULYDULIEU()
        {
            this.con = new SqlConnection();
            this.con.ConnectionString = @"Data Source=DESKTOP-UNGM53F\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        }

        public void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public DataTable table(string sql)
        {
            this.MoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.Fill(tb);
            this.DongKetNoi();
            return tb;
        }// truy vấn dữ liệu rồi đổ vào đối tượng DataTable

        public int ThucThiSql(string sql)
        {
            int result = 0;
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, con);
            result = (int)cmd.ExecuteNonQuery();
            this.DongKetNoi();
            return result;
        }// thực hiện insert, update, delete dữ liệu

        public int ThucThiGiaTri(string sql)
        {
            int result = 0;
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql, con);
            result = (int)cmd.ExecuteScalar();
            this.DongKetNoi();
            return result;
        }//lấy 1 giá trị đơn như giá trị đếm, tổng, trung bình, hoặc các giá trị kết hợp khác từ dữ liệu

        public int ThucThiinsertImage(String SQL, byte[] anh)
        {
            int result = 0;
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.Parameters.Add("@ANH", SqlDbType.Image).Value = anh;
            result = (int)cmd.ExecuteNonQuery();
            this.DongKetNoi();
            return result;
        }
    }
}
