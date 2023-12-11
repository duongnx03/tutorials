using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework3DF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Homework3DF.Controllers
{
   
    public class StockController : Controller
    {
        private readonly StockContext db;
        IWebHostEnvironment env;//thu vien nhan file vat ly

        public StockController(StockContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(string username, string password)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Username == username && a.Password == password);
            if(acc != null)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Listitem");
            }
            ViewBag.error = "error";
            return View("Index");
        }

        public async Task<IActionResult> Listitem()
        {
            if(HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Index");
            }
            ModelView model = new ModelView();
            model.Items = await db.Items.ToListAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ModelView modelView)
        {
            if (ModelState.IsValid)
            {
                var Item = modelView.Item;
                var filename = GetUniqueFilename(Item.UploadImage.FileName);
                var upload = Path.Combine(env.WebRootPath, "Images");
                var filepath = Path.Combine(upload, filename);
                var stream = new FileStream(filepath, FindMode.Create);
                await Item.
               
            }

            ModelView model = new ModelView();
            model.Items = await db.Items.ToListAsync();
            return View("Listitem", model);
        }

        [NonAction]
        private string GetUniqueFilename(string filename)
        {
            filename = Path.GetFileName(filename);
            return Path.GetFileNameWithoutExtension(filename) + "=" + DateTime.Now.Ticks + Path.GetExtension(filename);
        }
    }
}

