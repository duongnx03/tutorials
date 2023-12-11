using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Homework2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework2.Controllers
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

        public async Task<IActionResult> Index(string username, string password)
        {
            var account = await db.TbPeople.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
            if (account != null)
            {
                ViewBag.error = "Invalid username or password";
                return View("Index");
            }

            HttpContext.Session.SetString("username", username);
            if (account.Roles == true)
            {
                return RedirectToAction("Menu");
            }
            else
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
            return View(await db.TbPeople.Where(t => t.Roles == false).ToListAsync());
        }

        public async Task<IActionResult> Details()
        {
            var username = HttpContext.Session.GetString("username");
            var cus = await db.TbPeople.SingleOrDefaultAsync(p => p.Username == username);
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

