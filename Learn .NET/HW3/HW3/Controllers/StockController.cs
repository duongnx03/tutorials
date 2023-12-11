using HW3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW3.Controllers
{
    public class StockController : Controller
    {
        private readonly StockContext db;
        IWebHostEnvironment env; //thu vien nhan file vat ly

        public StockController(StockContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Username == username && a.Password == password);
            if (acc != null)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Listitem");
            }

            ViewBag.error = "error";
            return View("Index");
        }

        public async Task<IActionResult> Listitem()
        {
            if (HttpContext.Session.GetString("username") == null)
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
            if(ModelState.IsValid)
            {
                var Item = modelView.Item;
                var filename = GetUniqueFilename(Item.UploadImage.FileName);
                var upload = Path.Combine(env.WebRootPath, "images");
                var filepath = Path.Combine(upload, filename);
                var stream = new FileStream(filepath, FileMode.Create);
                await Item.UploadImage.CopyToAsync(stream);

                //luu db
                Item.Image = filename;
                db.Items.Add(Item);
                await db.SaveChangesAsync();
            }
            ModelView model = new ModelView();
            model.Items = await db.Items.ToListAsync();
            return View("Listitem", model);
        }

        [NonAction]
        private string GetUniqueFilename(string filename)
        {
            filename = Path.GetFileName(filename);
            return Path.GetFileNameWithoutExtension(filename) + "-" + DateTime.Now.Ticks
                +Path.GetExtension(filename);
        }

    }
}
