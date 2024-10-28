using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class KhachHang
    {
        public Guid ID { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }    
        public int Yuoi { get; set; }
        public string DiaChi { get; set; }

       
        public string sodienthoai { get; set; }
        public int LoaiKhachHang { get; set; }
    }
}
