using Lab03_04.Models;

namespace Lab04.Repositories
{
    public class LopHocRepo : ILopHocRepo
    {
        private readonly SinhVienDbContext _db;

        public LopHocRepo(SinhVienDbContext db) { _db = db; }
        public bool CreateClass(LopHocModel LopHoc)
        {
            _db.LopHoc.Add(LopHoc);
            if(_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteClass(Guid id)
        {
            var s = _db.LopHoc.Find(id);
            _db.LopHoc.Remove(s);
            if(_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<LopHocModel> GetAllClass()
        {
            return _db.LopHoc.ToList();
            
        }

        public LopHocModel GetClass(Guid id)
        {
            return _db.LopHoc.Find(id);
        }

        public bool UpdateClass(LopHocModel LopHoc)
        {
            _db.LopHoc.Update(LopHoc);
            if(_db.SaveChanges() > 0)
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
