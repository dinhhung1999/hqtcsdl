using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLySieuThiDAL;
using QuanLySieuThiEntity;
namespace QuanLySieuThiBUS
{
    public class BUS_MATHANG
    {
        SQL_MatHang sql = new SQL_MatHang();
        KetnoiDB cn = new KetnoiDB();
        //them du lieu
        public void ThemDuLieu(EC_MatHang et)
        {
            sql.ThemDuLieu(et);
        }
        //sua
        public void SuaDuLieu(EC_MatHang et)
        {
            sql.SuaDuLieu(et);
        }
        //xoa
        public void XoaDuLieu(EC_MatHang et)
        {
            sql.XoaDuLieu(et);
        }
        //laydl
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
