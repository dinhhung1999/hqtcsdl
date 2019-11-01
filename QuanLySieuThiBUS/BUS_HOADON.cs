using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiDAL;
using QuanLySieuThiEntity;
using System.Data;
namespace QuanLySieuThiBUS
{
    public class BUS_HOADON
    {
        SQL_HOADON sql = new SQL_HOADON();
        public void Insert(EC_HOADON et)
        {
            sql.Insert(et);
        }
        // sửa 
        public void Update(EC_HOADON et)
        {
                sql.Update(et);
        }

        // xóa
        public void Delete(EC_HOADON et)
        {
            sql.Delete(et);
        }
        // lấy dữ liệu
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
        public DataTable LayTTKH(String DieuKien)
        {
            return sql.LayTTKH(DieuKien);
        }
        /*public DataTable LayTTNV(String DieuKien)
        {
            return sql.GetDataTable("SELECT MaNV,TenNV FROM NHANVIENST " + DieuKien);
        } */
    }
}
