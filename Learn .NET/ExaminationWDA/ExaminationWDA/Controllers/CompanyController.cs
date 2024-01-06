using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationWDA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExaminationWDA.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyDbContext db;
        IWebHostEnvironment env;

        public CompanyController(CompanyDbContext db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }
        public async Task< IActionResult> Index()
        {
            var list = await db.TbEmployees.ToListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TbEmployee employee)
        {
            if (ModelState.IsValid)
            {
                
                var filename = GetUniqueFilename(employee.UploadImage.FileName);
                var upload = Path.Combine(env.WebRootPath, "images");
                var filepath = Path.Combine(upload, filename);
                var stream = new FileStream(filepath, FileMode.Create);
                await employee.UploadImage.CopyToAsync(stream);

                employee.Photo = filename;
                db.TbEmployees.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");

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

        public IActionResult Update(int id)
        {
            var emp = db.TbEmployees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Update(TbEmployee employee)
        {
            if (ModelState.IsValid)
            {
                db.Update(employee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public async Task<IActionResult> SearchBySkills(string skill)
        {
            var searchList = await db.TbEmployees.Where(c => c.Skills.Contains(skill)).ToListAsync();
            return View(searchList);
        }

        
    }
}

