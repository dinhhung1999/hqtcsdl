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
    public class BUS_GianHang
    {
        SQL_GianHang sql = new SQL_GianHang();
        KetnoiDB cn = new KetnoiDB();
        //them du lieu
        public void ThemDuLieu(EC_GianHang et)
        {
            sql.ThemDuLieu(et);
        }
        //sua
        public void SuaDuLieu(EC_GianHang et)
        {
            sql.SuaDuLieu(et);
        }
        //xoa
        public void XoaDuLieu(EC_GianHang et)
        {
            sql.XoaDuLieu(et);
        }
        //lay dl
        public DataTable LayDuLieu(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
