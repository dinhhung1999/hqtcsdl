using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiDAL;
using System.Data;
using QuanLySieuThiEntity;
namespace QuanLySieuThiBUS
{
    public class BUS_DSHD
    {
        SQL_DSHD sql = new SQL_DSHD();
        // sửa 
        public void Update(EC_DSHD et)
        {
            sql.Update(et);
        }
        // xóa
        public void Delete(EC_DSHD et)
        {
            sql.Delete(et);
        }
        public DataTable LayDSHD(string DieuKien)
        {
            return sql.LayDSHD(DieuKien);
        }
    }
}
