using KIemTra.Model;
using KIemTra.Repositories;

namespace KIemTra.Services
{
    public class SachService : ISachService
    {
        private readonly ISachRepo _repo;

        public SachService(ISachRepo repo) { _repo = repo; }
        public bool CreateSachSer(Sach sach)
        {
            if(_repo.CreateSach(sach))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSachSer(Guid id)
        {
            if (_repo.DeleteSach(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Sach> GetAllSachSer()
        {
            return _repo.GetAllSach();  
        }

        public bool UpdateSachSer(Sach sach)
        {
            if (_repo.UpdateSach(sach))
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
