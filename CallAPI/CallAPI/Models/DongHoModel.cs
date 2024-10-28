namespace CallAPI.Models
{
    public class DongHoModel
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int NamRaDoi { get; set; }
        public string? MoTa { get; set; }
        public Guid? LoaiMayID { get; set; }
        public Guid? MatKinhID { get; set; }
    }
}
