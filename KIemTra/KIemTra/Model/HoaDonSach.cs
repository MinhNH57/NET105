namespace KIemTra.Model
{
    public class HoaDonSach
    {
        public Guid HoaDonId { get; set; }
        public DonHang HoaDon { get; set; }

        public Guid SachId { get; set; }
        public Sach Sach { get; set; }
    }
}
