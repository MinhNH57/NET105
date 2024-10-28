using API.Migrations;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly MydataDbContext _db;

        public KhachHangController(MydataDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var s = _db.KhachHangs.ToList();
            return Ok(s);
        }

        [HttpPost]
        public IActionResult Create(KhachHang kh)
        {
            _db.KhachHangs.Add(kh);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(KhachHang Kh)
        {
            _db.KhachHangs.Update(Kh);
            _db.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var s = _db.KhachHangs.Find(id);
            _db.KhachHangs.Remove(s);
            _db.SaveChanges();
            return Ok();
        }
    }
}
