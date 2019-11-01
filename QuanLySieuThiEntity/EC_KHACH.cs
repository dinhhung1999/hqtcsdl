using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_KHACH
    {
        private string _MaKH;
        public string MaKH { get => _MaKH; set => _MaKH = value; }

        private string _TenKH;
        public string TenKH { get => _TenKH; set => _TenKH = value; }

        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
    }
}
