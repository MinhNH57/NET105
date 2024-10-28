using Lab01_Lab02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Execution;
using Microsoft.EntityFrameworkCore;

namespace Lab01_Lab02.Controllers
{
    public class VeXemController : Controller
    {
        private readonly MyDataDbContext _db;

        public VeXemController(MyDataDbContext db) { _db = db; }
        public IActionResult Index()
        {
            var s = _db.tickets.ToList();
            return View(s);
        }
        public IActionResult Create()
        {
            var suKien = _db.events.ToList();
            ViewBag.SuKien = new SelectList(suKien, "Id", "Id");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Ticket t)
        {
            _db.tickets.Add(t);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var s = _db.tickets.Find(id);
            return View(s);
        }

        [HttpPost]
        public IActionResult Edit(Ticket t)
        {
            _db.tickets.Update(t);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var s = _db.tickets.Find(id);
            _db.tickets.Remove(s);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details (Guid id)
        {
           var ticket = _db.tickets
                .Include(x => x.Event)  
                .FirstOrDefault(x => x.Id == id);
            return View(ticket);
        }
    }
}
