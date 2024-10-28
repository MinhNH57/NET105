using KIemTra.Model;

namespace KIemTra.Repositories
{
    public interface ISachRepo
    {
        public List<Sach> GetAllSach();
        public bool CreateSach(Sach sach);
        public bool UpdateSach(Sach sach);
        public bool DeleteSach(Guid id);
        public Sach GetSach(Guid id);
    }
}
