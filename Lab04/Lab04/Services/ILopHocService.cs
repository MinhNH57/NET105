using Lab03_04.Models;
using Lab04.Repositories;

namespace Lab04.Services
{
    public interface ILopHocService
    {
        public List<LopHocModel> GetAllLopHocSer();
        public LopHocModel GetLopHocSer(Guid id);
        public bool CreateLopHocSer(LopHocModel cl);
        public bool DeleteLopHocSer(Guid id);
        public bool UpdateLopHocSer(LopHocModel lopHoc);
    }
}
