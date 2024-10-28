using KIemTra.Model;
using KIemTra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KIemTra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SachController : ControllerBase
    {
        private readonly ISachService _ser;

        public SachController(ISachService ser) { _ser = ser; }
        [HttpGet]
        public IActionResult GetAllSach()
        {
            var s= _ser.GetAllSachSer();
            if(s != null)
            {
                return Ok(s);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(Sach s)
        {
            if(_ser.CreateSachSer(s))
            {
                return Ok(s);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update([FromBody] Sach s)
        {
            if (_ser.UpdateSachSer(s))
            {
                return Ok(s);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult Delete([FromBody]Guid id)
        {
            if(!_ser.DeleteSachSer(id))
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }
    }
}
