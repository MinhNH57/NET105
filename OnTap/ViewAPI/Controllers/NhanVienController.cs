using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using ViewAPI.Models;

namespace ViewAPI.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly HttpClient _httpClient;

        public NhanVienController(HttpClient httpClient) { _httpClient = httpClient; }
        public async Task<IActionResult> Index()
        {
            var respon = await _httpClient.GetAsync("https://localhost:7266/api/NhanVien");
            if (respon.IsSuccessStatusCode)
            {
                var jsonData = await respon.Content.ReadAsStringAsync();
                var nhanVienList = JsonConvert.DeserializeObject<List<NhanVien>>(jsonData);
                return View(nhanVienList);
            }
            return BadRequest();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NhanVien nv)
        {
            var json = JsonConvert.SerializeObject(nv);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var respon = await _httpClient.PostAsync("https://localhost:7266/api/NhanVien", content);

            if (respon.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }

            return View(respon);
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var s = await _httpClient.GetAsync($"https://localhost:7266/api/NhanVien/id?ID={id}");
            if (s.IsSuccessStatusCode)
            {
                var jsonString = await s.Content.ReadAsStringAsync();
                var l = JsonConvert.DeserializeObject<NhanVien>(jsonString);
                return View(l);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(NhanVien nv)
        {
            var json = JsonConvert.SerializeObject(nv);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var respon = await _httpClient.PutAsync("https://localhost:7266/api/NhanVien/id", content);
            if (respon.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            return View(respon);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid Id)
        {
            string url = $"https://localhost:7266/api/NhanVien/id?id={Id}";

            var s = await _httpClient.DeleteAsync(url);

            if (s.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View(s);
            }
        }

        public async Task<IActionResult> Details(Guid id)
        {
            var url = $"https://localhost:7266/api/NhanVien/id?ID={id}";

            var s = await _httpClient.GetAsync(url);
            if(s.IsSuccessStatusCode)
            {
                var i = await s.Content.ReadAsStringAsync();
                var a = JsonConvert.DeserializeObject<NhanVien>(i);
                return View(a);
            }
            else
            {
                return View(null);
            }
        }
    }
}
