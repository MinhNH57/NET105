

using APPAPI.Model;
using APPAPI.Repository;

namespace KIemTra.Services
{
    public class Ser : ISer
    {
        private readonly IRepo _repo;

        public Ser(IRepo repo) { _repo = repo; }
        public bool CreateKH(ThucAn kh)
        {
            if(_repo.CreateKH(kh)) return true;
            return false;
        }

        public bool DeleteKH(Guid id)
        {
            if (_repo.DeleteKH(id)) return true;
            return false;
        }

        public List<ThucAn> GetAllKH()
        {
            return _repo.GetAll();
        }

        public ThucAn GetKH(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateKH(ThucAn kh)
        {
            if (_repo.UpdateKH(kh)) return true;
            return false;
        }
    }
}
