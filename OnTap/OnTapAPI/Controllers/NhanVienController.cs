using Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnTapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly MyDataDbContext _db;

        public NhanVienController(MyDataDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var s = _db.NhanViens.ToList();
            return Ok(s);
        }

        [HttpGet("id")]
        public IActionResult GetByID(Guid ID)
        {
            var s = _db.NhanViens.Find(ID);
            return Ok(s);
        }

        [HttpPost]
        public IActionResult Create(NhanVien nv)
        {
            _db.NhanViens.Add(nv);
            if (_db.SaveChanges() > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("id")]
        public IActionResult Update(NhanVien nv)
        {
            _db.NhanViens.Update(nv);
            if (_db.SaveChanges() > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("id")]
        public IActionResult Delete(Guid id)
        {
            var s = _db.NhanViens.Find(id);
            _db.NhanViens.Remove(s);
            if (_db.SaveChanges() > 0)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
