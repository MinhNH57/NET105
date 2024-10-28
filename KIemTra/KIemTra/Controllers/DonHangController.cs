using KIemTra.Model;
using KIemTra.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KIemTra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangController : ControllerBase
    {
        private readonly IDonHangSer _ser;
        private readonly MyDataDbContext _db;

        public DonHangController(IDonHangSer ser , MyDataDbContext db) { _ser = ser; _db = db; }
        [HttpGet]   
        public IActionResult GetAll()
        {
            var s = _ser.GetAllDonHangSer();
            if (s != null) { return Ok(s); }
            else { return BadRequest(); }   
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(DonHang dh)
        {
            try
            {
                if (_ser.CreateDonHangSer(dh))
                {
                    var slthem = dh.soLuong;
                    var s = _ser.GetAllDonHangSer().Find(x => x.IDSach == dh.IDSach).IDSach;
                    var s1 = _db.Sach.Find(s);
                    var slcon = s1.stock;
                    var soluongcapnhat = slcon - slthem;
                    if (soluongcapnhat >= 0)
                    {
                        s1.stock = soluongcapnhat;
                        _db.Sach.Update(s1);
                        _db.SaveChanges();
                    }
                    else
                    {
                        return BadRequest();
                    }

                    return Ok(dh);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update(DonHang dh)
        {
            if(_ser.UpdateDonHangSer(dh))
            {
                var slthem = dh.soLuong;
                var s = _ser.GetAllDonHangSer().Find(x => x.IDSach == dh.IDSach).IDSach;
                var s1 = _db.Sach.Find(s);
                var slcon = s1.stock;
                var soluongcapnhat = slcon - slthem;
                if (soluongcapnhat >= 0)
                {
                    s1.stock = soluongcapnhat;
                    _db.Sach.Update(s1);
                    _db.SaveChanges();
                }
                else
                {
                    return BadRequest();
                }

                return Ok(dh);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var s = _db.DonHang.Find(id);
            if(s != null)
            {
                var soLuong = s.soLuong;
                var idSach = s.IDSach;
                var sach = _db.Sach.Find(idSach);
                if (sach != null)
                {
                    sach.stock += soLuong;
                    _db.Sach.Update(sach);
                    _db.SaveChanges();
                }
            }
            if(_ser.DeleteDonHangSer(id))
            {
                return StatusCode(200);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("Total")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var hoaDon = _db.DonHang.Find(id);
                if (hoaDon == null)
                {
                    return NotFound("Hóa đơn không tồn tại.");
                }

                var idSach = hoaDon.IDSach;
                var sach = _db.Sach.FirstOrDefault(x => x.ID == idSach);

                if (sach == null)
                {
                    return NotFound("Sách không tồn tại.");
                }

                var giaTien = sach.GiaTien;
                var TongTien = hoaDon.soLuong * giaTien;

                return Ok(TongTien);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
