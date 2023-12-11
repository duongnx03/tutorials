using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WDA1_CF.Models;

namespace WDA1_CF.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext db;
        public AccountController(DatabaseContext db)
        {
            this.db = db;
        }

        [Route("Index")]
      public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Name == username && a.Password == password);
            if(acc == null)
            {
                ViewBag.error = "Invalid username or password";
                return View("Index");
            }

            //login thanh cong
            HttpContext.Session.SetString("role", acc.Role);
            if (acc.Role == "User")
            {
                return Redirect($"Details/{acc.Id}");// khong co dau / => chuyen toi action
            }
            else
            {
                return Redirect("/admin/index");//co dau / chuyen toi controller
            }
            return View();
        }

        [Route("Details")]
        public async Task<IActionResult> Details(int id)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Id.Equals(id));
            return View(acc);
        }
    }
}

