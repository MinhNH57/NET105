using KIemTra.Model;
using KIemTra.Repositories;

namespace KIemTra.Services
{
    public class KhachHangSer : IKhachHangSer
    {
        private readonly IKhachHangRepo _repo;

        public KhachHangSer(IKhachHangRepo repo) { _repo = repo; }
        public bool CreateKH(KhachHang kh)
        {
            if(_repo.CreateKH(kh)) return true;
            return false;
        }

        public bool DeleteKH(Guid id)
        {
            if (_repo.DeleteKH(id)) return true;
            return false;
        }

        public List<KhachHang> GetAllKH()
        {
            return _repo.GetAllKH();
        }

        public KhachHang GetKH(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateKH(KhachHang kh)
        {
            if (_repo.UpdateKH(kh)) return true;
            return false;
        }
    }
}
