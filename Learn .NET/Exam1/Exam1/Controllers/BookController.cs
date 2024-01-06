using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam1.Controllers
{
    public class BookController : Controller
    {
        private readonly BookDbContext db;

        public BookController(BookDbContext db)
        {
            this.db = db;
        }
        
        public IActionResult Index()
        {
            var books = db.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,PublishedDate")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Add(book);
                await db.SaveChangesAsync();
                return RedirectToAction("Index"); // Chuyển hướng đến action "Index" sau khi tạo mới thành công.
            }
            return View(book);
        }


        public async Task< IActionResult> Delete(string id)
        {
            var book = await db.Books.FirstOrDefaultAsync(o => o.Id == id);
            var listBookDetails = await db.BookDetails.Where(b => b.BookId == id).ToListAsync();
            db.BookDetails.RemoveRange(listBookDetails);

            if (book == null)
            {
                return NotFound();
            }
            db.Books.Remove(book);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult > Details(string id)
        {
            var listBookDetails = await db.BookDetails.Where(b => b.BookId == id).ToListAsync();
            ViewBag.BookId = id;
            return View(listBookDetails);
        }

        public IActionResult CreateBookDetail(string BookId)
        {
            ViewBag.BookId = BookId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatebookDetail(BookDetails bookDetails)
        {
            if (ModelState.IsValid)
            {
                db.BookDetails.Add(bookDetails);
                await db.SaveChangesAsync();
                return Redirect($"Details/{bookDetails.BookId}");
            }
            ViewBag.BookId = bookDetails.BookId;
            return View();
        }

        public async Task<IActionResult> DeleteBookDetail(string bookid)
        {
            var bookDetails = await db.BookDetails.SingleOrDefaultAsync(o => o.BookId == bookid);

            if (bookDetails == null)
            {
                return NotFound();
            }

            db.BookDetails.Remove(bookDetails);
            await db.SaveChangesAsync();

            return Redirect($"Details/{bookDetails.BookId}");
        }

    }
}

