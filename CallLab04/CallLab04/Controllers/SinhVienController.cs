using CallLab04.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CallLab04.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly HttpClient _httpClient;

        public SinhVienController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7265/api/SinhVien");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var sinhVienList = JsonConvert.DeserializeObject<List<SinhVien>>(jsonData);
                return View(sinhVienList);
            }
            return BadRequest("Không thể lấy dữ liệu từ API");
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                sinhVien.Id = Guid.NewGuid();
                var jsonData = JsonConvert.SerializeObject(sinhVien);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("https://localhost:7265/api/SinhVien", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ModelState.AddModelError(string.Empty, $"Không thể thêm sản phẩm. Chi tiết lỗi: {errorContent}");
                }
            }
            return View(sinhVien);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var url = $"https://localhost:7265/api/SinhVien/id?id={id}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();

                var sv = JsonConvert.DeserializeObject<SinhVien>(jsonData);

                return View(sv);
            }
            else
            {
                return NotFound();
            } 
        }
        [HttpPost]
        public async Task<IActionResult> Edit(SinhVien sv)
        {
            if (ModelState.IsValid)
            {
                var jsonData = JsonConvert.SerializeObject(sv);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync("https://localhost:7265/api/SinhVien", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Không thể thêm sản phẩm.");
                }
            }
            return View(sv);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var url = $"https://localhost:7265/api/SinhVien?id={id}";

            var response = await _httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
