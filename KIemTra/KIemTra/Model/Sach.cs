namespace KIemTra.Model
{
    public class Sach
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string TacGia { get; set; }
        public decimal GiaTien { get; set; }
        public int stock { get; set; }
        public ICollection<HoaDonSach>? HoaDonSachs { get; set; }
    }
}
