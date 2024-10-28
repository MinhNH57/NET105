using CallLab04.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CallLab04.Controllers
{
    public class LopHocController : Controller
    {
        private readonly HttpClient _httpclient;

        public LopHocController(HttpClient http) { _httpclient = http; }
        public async Task<IActionResult> Index()
        {
            var response = await _httpclient.GetAsync("https://localhost:7265/api/LopHoc");

            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var sinhVienList = JsonConvert.DeserializeObject<List<LopHoc>>(jsonData);
                return View(sinhVienList);
            }
            return BadRequest("Không thể lấy dữ liệu từ API");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(LopHoc cl) 
        {
            if (ModelState.IsValid)
            {
                cl.Id = Guid.NewGuid();
                var jsonData = JsonConvert.SerializeObject(cl);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                var response = await _httpclient.PostAsync("https://localhost:7265/api/LopHoc/create", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Không thể thêm lớp học.");
                }
            }
            return View(cl);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var r = await _httpclient.GetAsync($"https://localhost:7265/api/LopHoc/getby?id={id}");
            if (r.IsSuccessStatusCode)
            {
                var jsonString = await r.Content.ReadAsStringAsync();
                var l = JsonConvert.DeserializeObject<LopHoc>(jsonString);
                return View(l);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(LopHoc lh)
        {
            if(ModelState.IsValid)
            {
                var jsonData = JsonConvert.SerializeObject(lh);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var respon = await _httpclient.PutAsync("https://localhost:7265/api/LopHoc", content);
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
    }
}
