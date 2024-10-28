using KIemTra.Model;
using KIemTra.Repositories;

namespace KIemTra.Services
{
    public class DonHangSer : IDonHangSer
    {
        private readonly IDonHangRepo _repo;

        public DonHangSer(IDonHangRepo repo) { _repo = repo; }
        public bool CreateDonHangSer(DonHang donHang)
        {
            if (_repo.CreateDonHang(donHang))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDonHangSer(Guid ID)
        {
            if (_repo.DeleteDonHang(ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DonHang> GetAllDonHangSer()
        {
            return _repo.GetAllDonHang();
        }

        public bool UpdateDonHangSer(DonHang donHang)
        {
            if (_repo.UpdateDonHang(donHang))
            {
                return true;
            }
            else
            {
                return false ;
            }
        }
    }
}
