using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class NhanVien
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int Yuoi { get; set; }
        public string DiaChi { get; set; }
        public string sodienthoai { get; set; }
        public int LoaiKhachHang { get; set; }
    }
}
