using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoJWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoJWT.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DatabaseContext db;

        public ProductController(DatabaseContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetProduct()
        {
            return Ok(await db.Products.ToListAsync());
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<ActionResult> PostProduct([FromBody]Product product)
        {
            db.Products.Add(product);
            await db.SaveChangesAsync();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var pro = await db.Products.SingleOrDefaultAsync(p => p.Id == id);
            db.Products.Remove(pro);
            await db.SaveChangesAsync();
            return Ok(pro);
        }
    }
}

