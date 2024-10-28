using KIemTra.Model;
using Microsoft.EntityFrameworkCore;

namespace KIemTra.Repositories
{
    public class KhachHangRepo : IKhachHangRepo
    {
        private readonly MyDataDbContext _db;

        public KhachHangRepo(MyDataDbContext db)  { _db = db; }
        public bool CreateKH(KhachHang kh)
        {
           _db.KhachHang.Add(kh);
            if(_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteKH(Guid id)
        {
            var s = _db.KhachHang.Find(id);
            _db.KhachHang.Remove(s);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<KhachHang> GetAllKH()
        {
            return _db.KhachHang.ToList();
        }

        public KhachHang GetKH(Guid id)
        {
            return _db.KhachHang.Find(id);
        }

        public bool UpdateKH(KhachHang kh)
        {
            _db.KhachHang.Update(kh);
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
