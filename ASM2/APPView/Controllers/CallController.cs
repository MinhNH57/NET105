using APPView.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace APPView.Controllers
{
    public class CallController : Controller
    {

        private readonly HttpClient _httpclient;

        public CallController(HttpClient http) { _httpclient = http; }
        public async Task<IActionResult> Index()
        {
            var response = await _httpclient.GetAsync("https://localhost:7293/api/Values");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var sinhVienList = JsonConvert.DeserializeObject<List<ThucAn>>(jsonData);
                return View(sinhVienList);
            }
            return BadRequest("Không thể lấy dữ liệu từ API");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ThucAn cl)
        {
            if (ModelState.IsValid)
            {
                cl.ID = Guid.NewGuid();
                var jsonData = JsonConvert.SerializeObject(cl);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = await _httpclient.PostAsync("https://localhost:7293/api/Values", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Không thể thêm thuc an.");
                }
            }
            return View(cl);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var r = await _httpclient.GetAsync($"https://localhost:7293/api/Values/id?id={id}");
            if (r.IsSuccessStatusCode)
            {
                var jsonString = await r.Content.ReadAsStringAsync();
                var l = JsonConvert.DeserializeObject<ThucAn>(jsonString);
                return View(l);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ThucAn lh)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonConvert.SerializeObject(lh);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var respon = await _httpclient.PutAsync("https://localhost:7293/api/Values", content);
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

                var response = await _httpclient.DeleteAsync(url);

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
