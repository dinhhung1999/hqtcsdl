using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiEntity;
using System.Data;
namespace QuanLySieuThiDAL
{
    public class SQL_KHACH
    {
        DataConnection cn = new DataConnection();
        // thêm
        public void Insert(EC_KHACH et)
        {
            cn.ExecuteSql(@"INSERT INTO KHACH(MaKH, TenKH, DiaChi) VALUES(N'"+ et.MaKH+ "',N'" + et.TenKH + "',N'" + et.DiaChi + "')");
        }
        // sửa 
        public void Update(EC_KHACH et)
        {
            cn.ExecuteSql(@"UPDATE KHACH SET MaKH = N'" + et.MaKH + "', TenKH = N'" + et.TenKH + "', DiaChi = N'" + et.DiaChi + "' WHERE MaKH = N'" + et.MaKH + "'");
        }
        // xóa
        public void Delete(EC_KHACH et)
        {
            cn.ExecuteSql(@"DELETE FROM KHACH WHERE MaKH = N'" + et.MaKH + "' ");
        }
        // lấy dữ liệu
        public DataTable TaoBang( string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM KHACH " + DieuKien);
        }
    }
}
