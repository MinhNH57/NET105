using Lab03_04.Models;
using Lab04.Repositories;

namespace Lab03_04.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _repo;

        public StudentService(IStudentRepo repo) { _repo = repo; }

        public bool CreateSinhVienSer(SinhVienModel sinhVien)
        {
            if(_repo.CreateSinhVien(sinhVien))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteSinhVienSer(Guid id)
        {
            if(_repo.DeleteSinhVien(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<SinhVienModel> GetAllSinhVienSer()
        {
            return _repo.GetAllSinhVien();
        }

        public SinhVienModel GetSinhVienBtIDSer(Guid id)
        {
            return _repo.GetSinhBienByID(id);
        }

        public bool UpdateSinhVienSer(SinhVienModel SinhVien)
        {
            if(_repo.UpdateSinhVien(SinhVien))
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
