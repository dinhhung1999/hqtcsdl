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
    public class QuanlyBLL
    {
        QuanLyDAL dalNV;
        public QuanlyBLL()
        {
            dalNV = new QuanLyDAL();
        }
        public DataTable getAllQuanLy()
        {
            return dalNV.getAllQuanLy();
        }
    }
}
