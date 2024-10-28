using KIemTra.Model;
using KIemTra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KIemTra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly IKhachHangSer _ser;

        public KhachHangController(IKhachHangSer ser) { _ser = ser; }

        [HttpGet]
        public IActionResult GetAll()
        {
            var s = _ser.GetAllKH();
            return Ok(s);
        }

        [HttpPost]
        public IActionResult Create(KhachHang kh)
        {
            if (_ser.CreateKH(kh))
            {
                return Ok();
            }
            else { return BadRequest(); }
        }

        [HttpPut]
        public IActionResult Edit(KhachHang kh)
        {
            if(_ser.UpdateKH(kh)) return Ok();
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            if (_ser.DeleteKH(id))
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
