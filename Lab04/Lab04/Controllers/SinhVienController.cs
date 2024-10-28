using Lab03_04.Models;
using Lab03_04.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace Lab03_04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly IStudentService _ser;

        public SinhVienController(IStudentService ser)
        {
            _ser = ser;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var s = _ser.GetAllSinhVienSer();
            if(s == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(s);
            }
        }

        [HttpGet("id")]
        public IActionResult Get(Guid id)
        {
            var s = _ser.GetSinhVienBtIDSer(id);
            if(s == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(s);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] SinhVienModel sinhVien)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                bool isCreated = _ser.CreateSinhVienSer(sinhVien);

                if (isCreated)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Failed to create SinhVien");
                }
            }
            catch (Exception ex)
            {
                // Ghi log hoặc thông báo chi tiết về lỗi
                return StatusCode(500, "An error occurred: " + ex.Message);
            }
        }


        [HttpPut]
        public IActionResult Update([FromBody] SinhVienModel sv)
        {
            if (sv == null)
            {
                return BadRequest("SinhVien object is null.");
            }

            var existingStudent = _ser.GetSinhVienBtIDSer(sv.Id);
            if (existingStudent == null)
            {
                return NotFound($"SinhVien with ID {sv.Id} not found.");
            }

            existingStudent.Name = sv.Name;
            existingStudent.Age = sv.Age;
            existingStudent.Major = sv.Major;
            existingStudent.ClassId = sv.ClassId;

            if (_ser.UpdateSinhVienSer(existingStudent))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Failed to update SinhVien.");
            }
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            if (_ser.DeleteSinhVienSer(id))
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
