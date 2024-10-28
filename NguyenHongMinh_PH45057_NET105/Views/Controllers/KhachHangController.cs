using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using Views.Models;

namespace Views.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly HttpClient _http;

        public KhachHangController(HttpClient http)
        {
            _http = http;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _http.GetAsync("https://localhost:7029/api/KhachHang");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var sinhVienList = JsonConvert.DeserializeObject<List<KhachHang>>(jsonData);
                return View(sinhVienList);
            }
            return BadRequest("Không thể lấy dữ liệu từ API");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]  
        public async Task<IActionResult> Create(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                kh.ID = Guid.NewGuid();
                var jsonData = JsonConvert.SerializeObject(kh);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = await _http.PostAsync("https://localhost:7029/api/KhachHang", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Không thể thêm thuc an.");
                }
            }
            return View(kh);


        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id)
        {
            var r = await _http.GetAsync($"https://localhost:7293/api/Values/id?id={id}");
            if (r.IsSuccessStatusCode)
            {
                var jsonString = await r.Content.ReadAsStringAsync();
                var l = JsonConvert.DeserializeObject<KhachHang>(jsonString);
                return View(l);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(KhachHang lh)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonConvert.SerializeObject(lh);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var respon = await _http.PutAsync("https://localhost:7293/api/Values", content);
                if (respon.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(lh);
                }
            }
            return View(lh);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                string url = $"https://localhost:7293/api/Values?id={id}";

                var response = await _http.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {

                    TempData["Message"] = "Xóa thành công!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Error"] = "Xóa không thành công!";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Lỗi xảy ra: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
