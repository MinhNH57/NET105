using Practice_CRUD.Models;

namespace Practice_CRUD.Repositories
{
    public interface IRepositories
    {
        public List<SInhVien> GetAllSinhVien();

        public SInhVien FindSinhVienByID(Guid id);
    }
}
