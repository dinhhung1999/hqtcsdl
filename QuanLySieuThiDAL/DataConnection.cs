using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLySieuThiDAL
{
    public class DataConnection
    {
        public static SqlConnection Connect;
        string conn;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommand cmd;
        public void OpenConnect()
        {
            if (DataConnection.Connect == null)
                DataConnection.Connect = new SqlConnection("Data Source=DESKTOP-GN3V8MM\\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHI;Integrated Security=SSPI");
            if (DataConnection.Connect.State != ConnectionState.Open)
                DataConnection.Connect.Open();
        }
        public void CloseConnect()
        {
            if(DataConnection.Connect !=null)
            {
                if (DataConnection.Connect.State == ConnectionState.Open)
                    DataConnection.Connect.Close();
            }
        }
        public DataConnection()
        {
            conn = "Data Source=DESKTOP-GN3V8MM\\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHI;Integrated Security=SSPI";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);
        }
        //insert, update, delete
        public void ExecuteSql(string strSQL)
        {
            try
            {
                OpenConnect();
                SqlCommand sqlcmd = new SqlCommand(strSQL, Connect);
                sqlcmd.ExecuteNonQuery();
                CloseConnect();
            }
            catch
            {

            }
        }
        //select
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                OpenConnect();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, Connect);
                sqlda.Fill(dt);
                CloseConnect();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public String GetValue(string strSQL)
        {
            string temp = null;
            OpenConnect();
            SqlCommand sqlcmd = new SqlCommand(strSQL,Connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while(sqldr.Read())
                temp = sqldr[0].ToString();
            CloseConnect();
            return temp;
        }
        public DataTable sp_proc(string proc)
        {
            dt = new DataTable();
            OpenConnect();
            cmd = new SqlCommand(proc, Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            CloseConnect();
            return dt;
        }
    }

}
