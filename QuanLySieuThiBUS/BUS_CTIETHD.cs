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
    public class BUS_CTIETHD
    {
        SQL_CTIETHD sql = new SQL_CTIETHD();
        public void Insert(EC_CTIETHD et)
        {
            sql.Insert(et);
        }
        // sửa 
        public void Update(EC_CTIETHD et)
        {
            sql.Update(et);
        }

        // xóa
        public void Delete(EC_CTIETHD et)
        {
            sql.Delete(et);
        }
        // lấy dữ liệu
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.LayDuLieu(DieuKien);
        }
        public DataTable LayTTHANG(String DieuKien)
        {
            return sql.LayTTHANG(DieuKien);
        }
    }
}
