using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class MauSac
    {
        public Guid ID { get;}
        public string TenMau { get; set; }

        public virtual ICollection<DongHoCT_MauSac> ms_dhct { get; set; }

    }
}
