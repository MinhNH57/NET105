using KIemTra.Model;

namespace KIemTra.Repositories
{
    public class SachRepo : ISachRepo
    {
        private readonly MyDataDbContext _db;

        public SachRepo(MyDataDbContext db) { _db = db; }

        public bool CreateSach(Sach sach)
        {
            _db.Sach.Add(sach);
            if(_db.SaveChanges() > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSach(Guid id)
        {
            var s = _db.Sach.Find(id);
            _db.Sach.Remove(s);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Sach> GetAllSach()
        {
            return _db.Sach.ToList();
        }

        public Sach GetSach(Guid id)
        {
            return _db.Sach.Find(id);
        }

        public bool UpdateSach(Sach sach)
        {
            _db.Sach.Update(sach);
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
