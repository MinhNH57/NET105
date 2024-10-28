using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APPAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThucAnController : ControllerBase
    {
        [HttpGet("rinhTong")]
        public IActionResult TinhTongChiPhi(decimal gia, int soLuong, decimal giamGia, decimal phiVanChuyen, decimal thue)
        {
            decimal tongSanPham = gia * soLuong;
            decimal tongGiamGia = tongSanPham * giamGia / 100;
            decimal giaSauGiamGia = tongSanPham - tongGiamGia;
            decimal tongThue = giaSauGiamGia * thue / 100;
            decimal tongChiPhi = giaSauGiamGia + phiVanChuyen + tongThue;

            return Ok(tongChiPhi);
        }

        private static bool IsEvenDigitSum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum % 2 == 0;
        }

        [HttpPost("tinhmax")]
        public IActionResult GetMaxEvenDigitSum([FromBody] int[] numbers)
        {
            var maxEvenDigitSum = numbers
                .Where(n => IsEvenDigitSum(n))
                .OrderByDescending(n => n)
                .FirstOrDefault();

            if (maxEvenDigitSum == 0 && !numbers.Contains(0))
            {
                return NotFound("Không có số nào có tổng chữ số là số chẵn.");
            }

            return Ok(maxEvenDigitSum);
        }
    }
}
