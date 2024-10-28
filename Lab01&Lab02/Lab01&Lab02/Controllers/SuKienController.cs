using Lab01_Lab02.Models;
using Lab01_Lab02.ModelView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab01_Lab02.Controllers
{
    public class SuKienController : Controller
    {
        private readonly MyDataDbContext db;

        public SuKienController(MyDataDbContext context) { db = context; }
        public IActionResult Index()
        {
            var events = db.events.ToList();
            var eventWithTicketCounts = new List<SuKienVM>();

            foreach (var evt in events)
            {
                var ticketCount = db.tickets.Count(x => x.IDEvent == evt.Id);
                eventWithTicketCounts.Add(new SuKienVM
                {
                    Event = evt,
                    TicketCount = ticketCount
                });
            }

            return View(eventWithTicketCounts);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Event ev)
        {
            if(ev.Date <= DateTime.Now)
            {
                TempData["Error"] = "Khong the them duoc";
                return View(ev);
            }
            db.events.Add(ev);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            var s = db.events.Find(id);
            return View(s);
        }

        [HttpPost]
        public IActionResult Edit(Event ev)
        {
            if (ev.Date <= DateTime.Now)
            {
                TempData["Error"] = "Khong the them duoc";
                return View(ev);
            }
            db.events.Update(ev);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            var s = db.events.Find(id);
            db.events.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete1(Guid id)
        {
            var eventEntity = db.events.Find(id);


            var tickets = db.tickets.Where(t => t.IDEvent == id).ToList();

            if (tickets.Any())
            {

                TempData["ErrorMessage"] = "Sự kiện này có vé liên quan, không thể xóa.";
                return RedirectToAction("Index");
            }


            db.events.Remove(eventEntity);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id)
        {
            var s = db.events.Find(id);
            return View(s);
        }
    }
}
