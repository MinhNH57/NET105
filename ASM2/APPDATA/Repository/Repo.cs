using APPAPI.Model;

namespace APPAPI.Repository
{
    public class Repo : IRepo
    {
        private readonly MyDataDbContext _db;

        public Repo(MyDataDbContext db) { _db = db; }
        public bool CreateKH(ThucAn kh)
        {
            _db.ThucAns.Add(kh);
            if (_db.SaveChanges() > 0)
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
            var s = _db.ThucAns.Find(id);
            _db.ThucAns.Remove(s);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ThucAn> GetAll()
        {
            return _db.ThucAns.ToList();
        }

        public ThucAn GetKH(Guid id)
        {
            return _db.ThucAns.Find(id);
        }

        public bool UpdateKH(ThucAn kh)
        {
            _db.ThucAns.Update(kh);
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
