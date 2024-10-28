using KIemTra.Model;
using Microsoft.EntityFrameworkCore;

namespace KIemTra.Repositories
{
    public class DonHangRepo : IDonHangRepo
    {
        private readonly MyDataDbContext _db;
        public DonHangRepo(MyDataDbContext db) {_db = db;}
        public bool CreateDonHang(DonHang donHang)
        {
            _db.DonHang.Add(donHang);
            if(_db.SaveChanges() > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDonHang(Guid ID)
        {
            var s = _db.DonHang.Find(ID);
            _db.DonHang.Remove(s);
            if(_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<DonHang> GetAllDonHang()
        {
            return _db.DonHang.Include(x => x.HoaDonSachs).ToList();
        }

        public bool UpdateDonHang(DonHang donHang)
        {
            _db.DonHang.Update(donHang);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
