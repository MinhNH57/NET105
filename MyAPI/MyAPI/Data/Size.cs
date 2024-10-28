using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class Size
    {
        [Key]
        public Guid ID { get; }
        public string TenSize { get; set; }

        public virtual DongHoCT? donghoct { get; set; }
    }
}
