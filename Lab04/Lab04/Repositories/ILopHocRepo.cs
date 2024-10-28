using Lab03_04.Models;

namespace Lab04.Repositories
{
    public interface ILopHocRepo
    {
        public List<LopHocModel> GetAllClass();
        public LopHocModel GetClass(Guid id);
        public bool CreateClass(LopHocModel LopHoc);
        public bool UpdateClass(LopHocModel LopHoc);
        public bool DeleteClass(Guid id);
    }
}
