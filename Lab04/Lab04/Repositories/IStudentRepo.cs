using Lab03_04.Models;

namespace Lab04.Repositories
{
    public interface IStudentRepo
    {
        public List<SinhVienModel> GetAllSinhVien();
        public SinhVienModel GetSinhBienByID(Guid id);
        public bool CreateSinhVien(SinhVienModel sinhVien);
        public bool UpdateSinhVien(SinhVienModel sinhVien);
        public bool DeleteSinhVien(Guid id);
    }
}
