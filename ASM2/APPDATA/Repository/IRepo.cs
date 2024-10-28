using APPAPI.Model;

namespace APPAPI.Repository
{
    public interface IRepo
    {
        public List<ThucAn> GetAll();
        public bool CreateKH(ThucAn kh);
        public bool UpdateKH(ThucAn kh);
        public bool DeleteKH(Guid id);
        public ThucAn GetKH(Guid id);
    }
}
