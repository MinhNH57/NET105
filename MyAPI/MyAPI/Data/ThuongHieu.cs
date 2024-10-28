using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class ThuongHieu
    {
        public Guid ID { get;set; }
        public string TenTH { get; set; }
        public string QuocGia { get; set; }
        public int NamThanhLap { get; set; }

        public virtual ICollection<DongHo> DongHos { get; set; }
    }
}
