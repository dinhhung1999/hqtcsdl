using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLySieuThiDAL
{
    public class connect
    {
        string conn;
        public connect()
        {
            conn = " Data Source=DESKTOP-GN3V8MM\\SQLEXPRESS;Initial Catalog=QUANLYSIEUTHI;Integrated Security=SSPI";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conn);

        }
    }
}
