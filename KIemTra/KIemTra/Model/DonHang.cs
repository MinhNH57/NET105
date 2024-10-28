namespace KIemTra.Model
{
    public class DonHang
    {
        public Guid ID { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IDSach { get; set; }
        public string status { get; set; } = "Pending";
        public int soLuong { get; set; } = 1;
        public KhachHang? KhachHang { get; set; }
        public ICollection<HoaDonSach>? HoaDonSachs { get; set; }
    }
}
