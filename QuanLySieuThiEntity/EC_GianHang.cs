using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_GianHang
    {
        private string _MaGH;
        private string _TenGH;
        private string _ViTri;
        private string _MaNV;

        public string MaGH { get => _MaGH; set => _MaGH = value; }
        public string TenGH { get => _TenGH; set => _TenGH = value; }
        public string ViTri { get => _ViTri; set => _ViTri = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
    }
}
