using Lab03_04.Models;
using Lab04.Repositories;

namespace Lab04.Services
{
    public class LopHocService : ILopHocService
    {
        private readonly ILopHocRepo _repo;

        public LopHocService(ILopHocRepo repo) { _repo = repo; }
        public bool CreateLopHocSer(LopHocModel cl)
        {
            if(_repo.CreateClass(cl))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteLopHocSer(Guid id)
        {
            if(_repo.DeleteClass(id))
            {
                return true;
            }
            else
            {
                return false ;
            }
        }

        public List<LopHocModel> GetAllLopHocSer()
        {
            return _repo.GetAllClass();
        }

        public LopHocModel GetLopHocSer(Guid id)
        {
            return _repo.GetClass(id);
        }

        public bool UpdateLopHocSer(LopHocModel lopHoc)
        {
            if (_repo.UpdateClass(lopHoc))
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
