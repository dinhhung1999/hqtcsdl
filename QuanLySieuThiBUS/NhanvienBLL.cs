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
    public class NhanvienBLL
    {
        NhanvienDAL dalNV;
        public NhanvienBLL()
        {
            dalNV = new NhanvienDAL();
        }
        public DataTable getAllNhanVien()
        {
            return dalNV.getAllNhanVien();
        }
        public bool Insert_nv(NhanVien nv)
        {
            return dalNV.Insert_nv(nv);
        }

        public bool Update_nv(NhanVien nv)
        {
            return dalNV.Update_nv(nv);
        }

        public bool Delete_nv(NhanVien nv)
        {
            return dalNV.Delete_nv(nv);
        }
    }
}
