using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThiEntity
{
    public class EC_CUNGCAP
    {
        private string _MaNCC;
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }

        private string _MaMH;
        public string MaMH { get => _MaMH; set => _MaMH = value; }

        private string _GiaBan;
        public string GiaBan { get => _GiaBan; set => _GiaBan = value; }
    }
}
