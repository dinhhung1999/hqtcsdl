using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiEntity;
using System.Data;
namespace QuanLySieuThiDAL
{
    public class SQL_HOADON
    {
        DataConnection cn = new DataConnection();
        public void Insert(EC_HOADON et)
        {
            cn.ExecuteSql(@"INSERT INTO HOADON(MaHD, NgayBan, MaKH, MaNV) VALUES(N'" + et.MaHD+ "',N'" + et.NgayBan + "',N'" + et.MaKH + "',N'" + et.MaNV + "')");
        }
        // sửa 
        public void Update(EC_HOADON et)
        {
            cn.ExecuteSql(@"UPDATE HOADON SET NgayBan =N'" + et.NgayBan + "', MaKH =N'" + et.MaKH + "', MaNV =N'" + et.MaNV + "' WHERE MaHD = N'" + et.MaHD + "' ");
        }

        // xóa
        public void Delete(EC_HOADON et)
        {
            cn.ExecuteSql(@"DELETE FROM HOADON WHERE MaHD = N'" + et.MaHD + "' ");
        }
        // lấy dữ liệu
        public DataTable LayDuLieu(string DieuKien)
        {
            return cn.GetDataTable("SELECT * FROM HOADON " + DieuKien);
        }
        public DataTable LayTTKH(String DieuKien)
        {
            return cn.GetDataTable("SELECT MaKH,TenKH FROM KHACH " + DieuKien);
        }
    }
}
