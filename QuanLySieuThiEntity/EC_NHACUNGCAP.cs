using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_NHACUNGCAP
    {
        private string _MaNCC;
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }

        private string _TenNCC;
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }


        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }

        private string _SDT;
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}
