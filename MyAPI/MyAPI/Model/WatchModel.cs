using Db_Watch_and_Ring.Models;

namespace MyAPI.Model
{
    public class WatchModel
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int NamRaDoi { get; set; }
        public string? MoTa { get; set; }
        public Guid? LoaiMayID { get; set; }
        public Guid? MatKinhID { get; set; }
    }
}
