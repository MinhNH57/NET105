using KIemTra.Model;

namespace KIemTra.Services
{
    public interface ISachService
    {
        public List<Sach> GetAllSachSer();
        public bool CreateSachSer(Sach sach);
        public bool UpdateSachSer(Sach sach);
        public bool DeleteSachSer(Guid id);
    }
}
