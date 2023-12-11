using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WDA1_CF.Models;
namespace WDA1_CF.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class AdminController : Controller
    {
        private readonly DatabaseContext db;

        public AdminController(DatabaseContext db)
        {
            this.db = db;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await db.Accounts.ToListAsync());
        }

        [Route("Create")]
        public IActionResult Create()
        {
           if( HttpContext.Session.GetString("role") != "admin")
            {
                return Redirect("/Account");
            }
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> Create(AccountTb account)
        {
            if (ModelState.IsValid)
            {
                db.Accounts.Add(account);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
           
        }
    }
}

