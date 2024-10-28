using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class DayDeo
    {
        public Guid ID { get; }
        public string LoaiDay { get; set;}
        public string? TenClDay { get; set;}
        public virtual DongHoCT? donghoct { get; set;}
    }
}
