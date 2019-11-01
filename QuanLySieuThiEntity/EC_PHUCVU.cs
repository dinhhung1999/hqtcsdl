using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_PHUCVU
    {
        private string _MaNV;
        private string _MaKH;

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
    }
}
