using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThiEntity;

namespace QuanLySieuThiDAL
{
    public class QuanLyDAL
    {
        connect dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public QuanLyDAL()
        {
            dc = new connect();
        }
        public DataTable getAllQuanLy()
        {
            string sql = "Select * from QuanLy";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
    }
}
