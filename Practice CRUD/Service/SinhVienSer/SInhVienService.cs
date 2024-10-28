using Practice_CRUD.Models;
using Practice_CRUD.Repositories;

namespace Practice_CRUD.Service.SinhVienSer
{
    public class SInhVienService
    {
        private readonly IRepositories _repo;

        public SInhVienService(IRepositories repo)
        {
            _repo = repo;
        }

        public List<SInhVien> GetAllSinhVienSer()
        {
            var s = _repo.GetAllSinhVien();
            return s;
        }
    }
}
