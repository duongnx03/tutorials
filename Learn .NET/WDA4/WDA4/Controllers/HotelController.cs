using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WDA4.Models;

namespace WDA4.Controllers
{
    public class HotelController : Controller
    {
        private readonly HotelDbContext db;

        public HotelController(HotelDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
              return db.Booking != null ? 
                          View(await db.Booking.ToListAsync()) :
                          Problem("Entity set 'HotelDbContext.Bookings'  is null.");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var acc = await db.Users.SingleOrDefaultAsync(o => o.Username == username && o.Password == password);
            if (acc == null)
            {
                ViewBag.error = "Invalid username or password";
                return View("Login");
            }
            return View("Create");
        }

       
        public IActionResult Create()
        {
            var username = HttpContext.Session.GetString("Username");
            var booking = new Booking
            {
                Username = username
            };
            return View(booking);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                var username = HttpContext.Session.GetString("Username");
                booking.Username = string.IsNullOrEmpty(username) ? booking.Username : username;
                db.Add(booking);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }

        public IActionResult Edit(int id)
        {
            var book = db.Booking.Find(id);
            if(book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Booking book)
        {
            if (ModelState.IsValid)
            {
                db.Update(book);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var book = await db.Booking.SingleOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            db.Booking.Remove(book);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
