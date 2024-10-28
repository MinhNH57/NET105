using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class MatKinh
    {
        public Guid ID { get; set; }
        public string TenLoaiDay { get; set; }
        public string TenCl { get; set; }

        public virtual DongHo dongho { get; set; }
    }
}
