using Lab03_04.Models;

namespace Lab04.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly SinhVienDbContext _db;

        public StudentRepo(SinhVienDbContext db) { _db = db; }

        public bool CreateSinhVien(SinhVienModel sinhVien)
        {
            _db.SinhVien.Add(sinhVien);
            if (_db.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSinhVien(Guid id)
        {
            var s = _db.SinhVien.FirstOrDefault(x => x.Id == id);
            if (s != null)
            {
                _db.SinhVien.Remove(s);
                if (_db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public List<SinhVienModel> GetAllSinhVien()
        {
            var sv = _db.SinhVien.ToList();
            return sv;
        }

        public SinhVienModel GetSinhBienByID(Guid id)
        {
            var sv = _db.SinhVien.Find(id);
            return sv;
        }

        public bool UpdateSinhVien(SinhVienModel sinhVien)
        {
            _db.SinhVien.Update(sinhVien);
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
