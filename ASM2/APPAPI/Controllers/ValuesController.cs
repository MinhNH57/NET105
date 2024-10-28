using APPAPI.Model;
using KIemTra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISer _ser;

        public ValuesController(ISer ser) { _ser = ser; }

        [HttpGet]
        public IActionResult GetAll()
        {
            var s = _ser.GetAllKH();
            return Ok(s);
        }

        [HttpGet("id")]
        public IActionResult GetbyID(Guid id)
        {
            var s = _ser.GetKH(id);
            return Ok(s);
        }

        [HttpPost]
        public IActionResult Create(ThucAn kh)
        {
            if (_ser.CreateKH(kh))
            {
                return Ok();
            }
            else { return BadRequest(); }
        }

        [HttpPut]
        public IActionResult Edit(ThucAn kh)
        {
            if (_ser.UpdateKH(kh)) return Ok();
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
