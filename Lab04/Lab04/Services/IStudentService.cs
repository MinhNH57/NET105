using Lab03_04.Models;

namespace Lab03_04.Services
{
    public interface IStudentService
    {
        public List<SinhVienModel> GetAllSinhVienSer();
        public SinhVienModel GetSinhVienBtIDSer(Guid id);
        public bool CreateSinhVienSer(SinhVienModel sinhVien);
        public bool UpdateSinhVienSer(SinhVienModel SinhVien);
        public bool DeleteSinhVienSer(Guid id);
    }
}
