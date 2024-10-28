using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class DongHoCT_MauSac
    {
        public Guid ID { get; }
        
        public virtual DongHoCT? donghoct { get; set; }
        public virtual MauSac? mausac { get; set; }
    }
}
