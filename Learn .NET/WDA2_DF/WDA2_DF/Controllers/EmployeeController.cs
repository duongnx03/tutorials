
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WDA2_DF.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WDA2_DF.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext db;

        public EmployeeController(EmployeeDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var emp = db.Employees.Include(e => e.Position).ToListAsync();
            return View(emp);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Position position)
        {
            if (ModelState.IsValid)
            {
                db.Positions.Add(position);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(position);
        }

        public IActionResult Edit(string id)
        {
            var emp = db.Employees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Update(employee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

    }
}

