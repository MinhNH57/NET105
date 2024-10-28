using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnTapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult TinhLai(decimal soTien, int soThang, float tyLe)
        {
            float a = 1;
            for (int i = 1; i <= soThang; i++)
            {
                a *= (1 + tyLe / 100);
            }

            float soLai = (float.Parse(soTien.ToString()) * a) - (float)soTien;
            return Ok(soLai);
        }

        [HttpPost]
        [Route("Mang")]
        public IActionResult Search([FromBody] int[] arr)
        {
            if(arr.Length == 0)
            {
                return BadRequest();
            }
            else
            {
                var s = arr.OrderDescending().Take(3);
                return Ok(s.Reverse().Take(1));

            }
        }
    }
}
