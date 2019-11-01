using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySieuThiDAL
{
    public class KetnoiDB
    {
        public static SqlConnection connect;
        public static void MoKetNoi()
        {
            if (KetnoiDB.connect == null)
                KetnoiDB.connect = new SqlConnection("Data Source=DESKTOP-GN3V8MM\\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHI;Integrated Security=SSPI");
            if (KetnoiDB.connect.State != ConnectionState.Open)
                KetnoiDB.connect.Open();
        }
        public void DongKetNoi()
        {
            if (KetnoiDB.connect != null)
            {
                if (KetnoiDB.connect.State == ConnectionState.Open)
                    KetnoiDB.connect.Close();
            }
        }
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {

            }

        }
        public DataTable GetDataTable(string srtSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(srtSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string strSQL)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }
    }
}
