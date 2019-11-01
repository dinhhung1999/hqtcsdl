using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySieuThiEntity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySieuThiDAL
{
        public class SQL_CTIETHD
        {
            DataConnection cn = new DataConnection();
            public void Insert(EC_CTIETHD et)
            {
                cn.ExecuteSql(@"INSERT INTO CTIETHD(MaHD, MaMH, SoLuongMua) VALUES(N'"+ et.MaHD + "',N'" + et.MaMH + "',N'" + et.SoLuongMua + "')");
            }
            // sửa 
            public void Update(EC_CTIETHD et)
            {
                cn.ExecuteSql(@"UPDATE CTIETHD SET SoLuongMua = N'" + et.SoLuongMua + "' WHERE MaHD = N'" + et.MaHD + "' AND MaMH =N'" + et.MaMH + "'");
            }

            // xóa
            public void Delete(EC_CTIETHD et)
            {
                cn.ExecuteSql(@"DELETE FROM CTIETHD WHERE MaHD = N'" + et.MaHD + "' ");
            }
            // lấy dữ liệu
            public DataTable LayDuLieu(string DieuKien)
            {
                return cn.GetDataTable("SELECT * FROM CTIETHD " + DieuKien);
            }
        public DataTable LayTTHANG(String DieuKien)
            {
                return cn.GetDataTable("SELECT MaMH,TenMH, GiaMH FROM MATHANG " + DieuKien);
            }
        }
    }
