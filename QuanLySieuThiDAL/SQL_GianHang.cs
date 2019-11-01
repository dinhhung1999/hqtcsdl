using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySieuThiEntity;
namespace QuanLySieuThiDAL
{
    public class SQL_GianHang
    {
        KetnoiDB cn = new KetnoiDB();
        //them du lieu
        public void ThemDuLieu(EC_GianHang et)
        {
            cn.ThucThiCauLenhSQL(@"insert into GIANHANG values ('" + et.MaGH + "', N'" + et.TenGH + "','" + et.ViTri + "',  N'" + et.MaNV + "'");
        }
        //sua
        public void SuaDuLieu(EC_GianHang et)
        {
            cn.GetValue(@"update GIANHANG set TenGH = N'" + et.TenGH + "', ViTri = N'" + et.ViTri + "', MaNV = N'" + et.MaNV + "' where MaGH = '" + et.MaGH + "'");
        }
        //xoa
        public void XoaDuLieu(EC_GianHang et)
        {
            cn.ThucThiCauLenhSQL(@"delete from GIANHANG where MaGH = '" + et.MaGH + "'");
        }
        //lay dl
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from GIANHANG" + DieuKien);
        }
    }
}
