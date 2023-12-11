using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework1.Controllers
{   
    public class NewsController : Controller
    {
        private readonly NewsContext db;
        public NewsController(NewsContext db)
        {
            this.db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var acc = await db.Admins.SingleOrDefaultAsync(a => a.Username == username && a.Password == password);
            if(acc != null)
            {
                HttpContext.Session.SetString("admin", username);
                return RedirectToAction("Admin");
            }
            ViewBag.error = "Login fail";
            return View("Index");
        }

        public IActionResult Admin()
        {
            if(HttpContext.Session.GetString("admin") == null){
                return View("Index");// khong co session thi chuyen view login
            }
            return View();
            
        }

        public async Task<IActionResult> ShowAllNews()
        {
            var list = await db.News.ToListAsync();
            return View(list);
        }

        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNews(tbNews news)
        {
            db.News.Add(news);
            await db.SaveChangesAsync();
            return RedirectToAction("Admin");
        }
    }
}

