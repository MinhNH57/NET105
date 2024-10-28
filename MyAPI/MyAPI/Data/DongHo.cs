using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class DongHo
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int NamRaDoi { get; set; }
        public string? MoTa { get; set; }
        public Guid? LoaiMayID { get; set; }
        public Guid? MatKinhID {get; set; }

        public virtual ThuongHieu? thuonghieu { get; set; }
        public virtual LoaiMay? loaimay { get; set; }
        public virtual MatKinh? matkinh { get; set;}
        public virtual ICollection<DongHoCT> DongHoCTs { get; set; }
    }
}
