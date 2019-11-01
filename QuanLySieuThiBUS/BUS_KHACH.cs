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
    public class BUS_KHACH
    {
        SQL_KHACH sql = new SQL_KHACH();
        // thêm
        public void Insert(EC_KHACH et)
        {
            sql.Insert(et);
        }
        // sửa 
        public void Update(EC_KHACH et)
        {
            sql.Update(et);
        }

        // xóa
        public void Delete(EC_KHACH et)
        {
            sql.Delete(et);
        }
        // lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
