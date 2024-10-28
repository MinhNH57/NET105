


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HocLucController : ControllerBase
{
    [HttpGet("tinh-hoc-luc")]
    public IActionResult TinhHocLuc(double math, double eng, double his, string nganh)
    {
        if (math < 0 || math > 10 || eng < 0 || eng > 10 || his < 0 || his > 10)
        {
            return BadRequest("Điểm phải nằm trong khoảng từ 0 đến 10.");
        }

        switch (nganh.ToLower())
        {
            case "math":
                math *= 2;
                break;
            case "eng":
                eng *= 2;
                break;
            case "his":
                his *= 2;
                break;
            default:
                return BadRequest("Ngành học không hợp lệ. Vui lòng chọn 'math', 'eng', hoặc 'his'.");
        }

        double diemTrungBinh = (math + eng + his) / 4.0;

        string hocLuc;
        if (diemTrungBinh >= 8)
        {
            hocLuc = "Giỏi";
        }
        else if (diemTrungBinh >= 6.5)
        {
            hocLuc = "Khá";
        }
        else
        {
            hocLuc = "Trung bình";
        }

        return Ok(new
        {
            DiemTrungBinh = diemTrungBinh,
            HocLuc = hocLuc
        });
    }

    [HttpPost("sap-xep-duy-nhat")]
    public IActionResult SapXepDuyNhat([FromBody] int[] soNguyens)
    {
        if (soNguyens == null || soNguyens.Length == 0)
        {
            return BadRequest("Mảng số nguyên không được trống.");
        }

        var ketQua = soNguyens.Distinct().OrderByDescending(x => x).ToList();

        return Ok(ketQua);
    }

}
