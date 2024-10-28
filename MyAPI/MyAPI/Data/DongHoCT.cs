using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class DongHoCT
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public int NamSX { get; set; }
        public string? TienIch {  get; set; }
        public decimal GiaTien { get; set; }
        public int SoLuong { get; set; }
        public string? Image { get; set; }
        public Guid? DayDeoID { get; set; }
        public Guid? SizeID {  get; set; }

        public virtual ICollection<DongHoCT_MauSac> dhct_ms { get; set; }
        public virtual ICollection<DongHoCT_ChatLieu> hdct_cl { get; set; }
        public virtual DongHo? DongHo { get; set; }
        public virtual Size? size { get; set; }
        public virtual DayDeo? daydeo { get; set; }
    }
}
