using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiEntity;
using System.Data;
namespace QuanLySieuThiDAL
{
    public class SQL_DSHD
    {
        DataConnection cn = new DataConnection();
        public void Delete(EC_DSHD et)
        {
            cn.ExecuteSql(@"DELETE FROM DSHD WHERE MaHD = N'" + et.MaHD + "'");
        }
        // sửa 
        public void Update(EC_DSHD et)
        {
            cn.ExecuteSql(@"UPDATE DSHD SET MaKH = N'" + et.MaKH + "', MaMH = N'" + et.MaMH + "' , SoLuongMua = N'" + et.SoLuongMua + "', MaNV = N'" + et.MaNV + "' WHERE MaHD = N'" + et.MaHD + "' ");
        }
        // lấy dữ liệu
        public DataTable LayDSHD(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM DSHD " + DieuKien);
        }
    }
}
