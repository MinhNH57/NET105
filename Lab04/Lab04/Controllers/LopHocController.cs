using Lab03_04.Models;
using Lab04.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace Lab04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocController : ControllerBase
    {
        private readonly ILopHocService _ser;

        public LopHocController(ILopHocService ser) { _ser = ser; }

        [HttpGet]
        public IActionResult GetAll()
        {
            var s =  _ser.GetAllLopHocSer();
            if(s == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(s);
            }
        }

        [HttpGet]
        [Route("getby")]
        //[HttpPost]
        public IActionResult Get( Guid id)
        {
            var s = _ser.GetLopHocSer(id);
            if(s == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(s);
            }
        }
        //[HttpPost]
        //[Route("edit")]
        [HttpPut]
        public IActionResult Edit([FromBody] LopHocModel cl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loph = _ser.GetLopHocSer(cl.Id);
            if (loph != null)
            {
                loph.Name = cl.Name; 

                if (_ser.UpdateLopHocSer(loph))
                {
                    return Ok();
                }
                else
                {
                    return StatusCode(500, "Có lỗi xảy ra khi cập nhật lớp học.");
                }
            }
            else
            {
                return NotFound("Lớp học không được tìm thấy.");
            }
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] LopHocModel lopHoc)
        {
            if(_ser.CreateLopHocSer(lopHoc))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            if (_ser.DeleteLopHocSer(id))
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
