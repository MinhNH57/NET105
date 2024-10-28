using APPAPI.Model;

namespace KIemTra.Services
{
    public interface ISer 
    {
        public List<ThucAn> GetAllKH();
        public bool CreateKH(ThucAn kh);
        public bool UpdateKH(ThucAn kh);
        public bool DeleteKH(Guid id);
        public ThucAn GetKH(Guid id);
    }
}
