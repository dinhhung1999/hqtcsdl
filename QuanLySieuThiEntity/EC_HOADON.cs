using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_HOADON
    {
        private string _MaHD;
        private string _NgayBan;
        private string _MaKH;
        private string _MaNV;
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string NgayBan { get => _NgayBan; set => _NgayBan = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
    }
}