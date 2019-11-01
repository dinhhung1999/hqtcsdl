using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLySieuThiEntity;
using System.Data;
namespace QuanLySieuThiDAL
{
    public class NhanvienDAL
    {
        connect dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhanvienDAL()
        {
            dc = new connect();
        }
        public DataTable getAllNhanVien()
        {
            string sql = "Select * from NHANVIEN";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }

        public bool Insert_nv(NhanVien nv)
        {
            string sql = "Insert into NHANVIEN values(@MaNV, @TenNV, @Ngaysinh, @Quequan, @Sdt, @BacLuong, @MaQL)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
                cmd.Parameters.Add("@Quequan", SqlDbType.NVarChar).Value = nv.Quequan;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.Sdt;
                cmd.Parameters.Add("@BacLuong", SqlDbType.Int).Value = nv.BacLuong;
                cmd.Parameters.Add("@MaQL", SqlDbType.NVarChar).Value = nv.Maql;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {

                return false;
            }

            return true;
        }

        public bool Update_nv(NhanVien nv)
        {
            string sql = "Update NHANVIEN set TenNV = @TenNV, NgaySinh = @Ngaysinh, QueQuan = @Quequan, SĐT = @Sdt, BacLuong = @Luong, MaQL = @MaQL Where MaNV = @MaNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
                cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
                cmd.Parameters.Add("@Quequan", SqlDbType.NVarChar).Value = nv.Quequan;
                cmd.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.Sdt;
                cmd.Parameters.Add("@Luong", SqlDbType.Int).Value = nv.BacLuong;
                cmd.Parameters.Add("@MaQL", SqlDbType.NVarChar).Value = nv.Maql;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool Delete_nv(NhanVien nv)
        {
            string sql = "Delete from NHANVIEN Where MaNV = @MaNV";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
