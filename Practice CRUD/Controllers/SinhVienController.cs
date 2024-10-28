
using Microsoft.AspNetCore.Mvc;
using Practice_CRUD.Service.SinhVienSer;

namespace Practice_CRUD.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly SInhVienService s;

        public SinhVienController(SInhVienService sv)
        {
            s = sv;
        }
        public IActionResult Index()
        {
            var sinhVien = s.GetAllSinhVienSer();
            return View(sinhVien);
        }
    }
}
