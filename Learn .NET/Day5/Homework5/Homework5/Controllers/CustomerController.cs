using System;
using Homework5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Homework5.Controllers
{
	public class CustomerController : Controller
	{
		private readonly CustomerDbContext db;

		public CustomerController(CustomerDbContext db)
		{
			this.db = db;
		}

		public async Task<IActionResult> Index()
		{
            var customers = await db.Customers.ToListAsync();
            return View(customers);
		}

		public async Task<IActionResult> Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind("Id, Name, Birthday, Gender, Email")] Customer customer)
		{
			if (ModelState.IsValid)
			{
				db.Add(customer);
				await db.SaveChangesAsync();// save vao db
				return RedirectToAction("Index");
			}
			return View(customer);
		}

		public async Task<IActionResult> UpdateOrDelete(int id)
		{
            if (id == null)
            {
                return NotFound();
            }

            var customer = await db.Customers.FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        public IActionResult Edit(int id)
        {
            var customer = db.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Update(customer);
                await db.SaveChangesAsync();
                return RedirectToAction("UpdateOrDelete", new { id = customer.Id });
            }

            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Customers.Remove(customer);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

