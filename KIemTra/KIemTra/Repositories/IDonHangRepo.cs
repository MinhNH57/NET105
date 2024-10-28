using KIemTra.Model;

namespace KIemTra.Repositories
{
    public interface IDonHangRepo
    {
        public List<DonHang> GetAllDonHang();
        public bool CreateDonHang(DonHang donHang);
        public bool UpdateDonHang(DonHang donHang);
        public bool DeleteDonHang(Guid ID);
    }
}
