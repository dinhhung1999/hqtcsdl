using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_CTIETHD
    {
        private string _MaHD;
        private string _MaMH;
        private string _SoLuongMua;
        private string _ThanhTien;
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaMH { get => _MaMH; set => _MaMH = value; }
        public string SoLuongMua { get => _SoLuongMua; set => _SoLuongMua = value; }
        public string ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
    }
}
