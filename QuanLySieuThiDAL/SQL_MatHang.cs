using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThiEntity;
using System.Data.SqlClient;
namespace QuanLySieuThiDAL
{
    public class SQL_MatHang
    {
        KetnoiDB cn = new KetnoiDB();
        //them du lieu
        public void ThemDuLieu(EC_MatHang et)
        {
            cn.ThucThiCauLenhSQL(@"insert into MATHANG values ('" + et.MaMH1 + "', N'" + et.TenMH1 + "','" + et.SoLuong1 + "','" + et.GiaMH1 + "','" + et.NSX1 + "', N'" + et.MaGH1 + "', N'" + et.MaNV1 + "'");
        }
        //sua
        public void SuaDuLieu(EC_MatHang et)
        {
            cn.ThucThiCauLenhSQL(@"update MATHANG set TenMH = N'" + et.TenMH1 + "',SoLuong='" + et.SoLuong1 + "',GiaMH = '" + et.GiaMH1 + "',NSX = '" + et.NSX1 + "',MaGH = N'" + et.MaGH1 + "',MaNV = N'" + et.MaNV1 + "' where MaMH =  '" + et.MaMH1 + "'");
        }
        //xoa
        public void XoaDuLieu(EC_MatHang et)
        {
            cn.ThucThiCauLenhSQL(@"delete from MATHANG where MaMH = '" + et.MaGH1 + "'");
        }
        //laydl
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from MATHANG " + DieuKien);
        }
    }
}
