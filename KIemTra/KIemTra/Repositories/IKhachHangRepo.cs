using KIemTra.Model;

namespace KIemTra.Repositories
{
    public interface IKhachHangRepo
    {
        public List<KhachHang> GetAllKH();
        public bool CreateKH(KhachHang kh);
        public bool UpdateKH(KhachHang kh);
        public bool DeleteKH(Guid id);
        public KhachHang GetKH(Guid id);
    }
}
