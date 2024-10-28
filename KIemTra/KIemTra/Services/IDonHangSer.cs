using KIemTra.Model;

namespace KIemTra.Services
{
    public interface IDonHangSer
    {
        public List<DonHang> GetAllDonHangSer();
        public bool CreateDonHangSer(DonHang donHang);
        public bool UpdateDonHangSer(DonHang donHang);
        public bool DeleteDonHangSer(Guid ID);
    }
}
