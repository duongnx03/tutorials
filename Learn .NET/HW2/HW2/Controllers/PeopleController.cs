using HW2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW2.Controllers
{
    public class PeopleController : Controller
    {
        private readonly BankDbContext db;

        public PeopleController(BankDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var account = await db.TbPeople.SingleOrDefaultAsync(p => p.Username == username && p.Password == password);
            if(account == null)
            {
                ViewBag.error = "Invalid user name or password";
                return View("Index");
            }

            //login thanh cong => add session
            HttpContext.Session.SetString("username", username);
            HttpContext.Session.SetString("role", (account.Roles==true)?"employee":"customer");

            if (account.Roles == true) // employee role
            {
                return RedirectToAction("Menu");
            }
            else //customer role
            {
                return RedirectToAction("Details");
            }
        }

        public IActionResult Menu()
        {
            return View();
        }

        public async Task<IActionResult> Show()
        {
            return View(await db.TbPeople.Where(t=>t.Roles==false).ToListAsync());
        }

        public async Task<IActionResult> Details()
        {
            var username = HttpContext.Session.GetString("username");
            var cus = await db.TbPeople.SingleOrDefaultAsync(t=> t.Username == username);
            return View(cus);
        }

        public async Task<IActionResult> Remove()
        {
            return View(await db.TbPeople.Where(t => t.Roles == false).ToListAsync());
        }

        public async Task<IActionResult> Delete(string id)
        {
            var cus = await db.TbPeople.SingleOrDefaultAsync(t => t.Username == id);
            db.TbPeople.Remove(cus);
            await db.SaveChangesAsync();
            return RedirectToAction("Remove");
        }

    }
}
