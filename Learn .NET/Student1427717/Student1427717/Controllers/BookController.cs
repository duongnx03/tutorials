using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student1427717.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Student1427717.Controllers
{
    public class BookController : Controller
    {
        private readonly DatabaseContext db;
        IWebHostEnvironment env;

        public BookController(DatabaseContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }



        public async Task<IActionResult>  Index(string title)
        {
            var list = string.IsNullOrEmpty(title)
                ?await db.tbBooks.ToListAsync()
                :await db.tbBooks.Where(b => b.Title.Contains(title)).ToListAsync();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(tbBook tbBook)
        {
            if (ModelState.IsValid)
            {
                if (tbBook.UploadImage != null)
                {

                    var filename = GetUniqueFilename(tbBook.UploadImage.FileName);
                    var upload = Path.Combine(env.WebRootPath, "images");
                    var filepath = Path.Combine(upload, filename);
                    var stream = new FileStream(filepath, FileMode.Create);
                    await tbBook.UploadImage.CopyToAsync(stream);

                    tbBook.ImageUrl = filename;
                    db.tbBooks.Add(tbBook);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [NonAction]
        private string GetUniqueFilename(string filename)
        {
            filename = Path.GetFileName(filename);
            return Path.GetFileNameWithoutExtension(filename) + "-" + DateTime.Now.Ticks
                + Path.GetExtension(filename);
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await db.tbBooks.SingleOrDefaultAsync(i => i.Id == id));
        }
    }
}

