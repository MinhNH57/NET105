using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class ChatLieu
    {
        [Key]
        public Guid ID { get; }
        public string TenChatLieu { get; set; }
        public virtual ICollection<DongHoCT_ChatLieu> cl_dhct { get; set; }
    }
}
