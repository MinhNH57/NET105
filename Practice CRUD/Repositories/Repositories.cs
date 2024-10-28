using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Practice_CRUD.Models;

namespace Practice_CRUD.Repositories
{
    public class Repositories : IRepositories
    {
        private readonly MyDataDbcontext context;

        public Repositories(MyDataDbcontext _db) { context = _db; }
        public SInhVien FindSinhVienByID(Guid id)
        {
            var sinhVien = context.SinhViens.FirstOrDefault(sv => sv.ID == id);
            return sinhVien;
        }

        public List<SInhVien> GetAllSinhVien()
        {
            var sinhViens = context.SinhViens.Include(x => x.lophoc).ToList();
            return sinhViens;
        }
    }
}
