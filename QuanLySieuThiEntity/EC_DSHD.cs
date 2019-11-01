using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_DSHD
    {
        private string _MaHD;
        private string _MaKH;
        private string _MaMH;
        private string _NgayLap;
        private string _SoLuongMua;
        private string _ThanhTien;
        private string _MaNV;

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public string NgayLap { get => _NgayLap; set => _NgayLap = value; }
        public string SoLuongMua { get => _SoLuongMua; set => _SoLuongMua = value; }
        public string ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
    }
}
