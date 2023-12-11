using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase    {
        private readonly ProductDbContext db;

        public ProductController(ProductDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var list = await db.Products.ToListAsync();
            return Ok(list);// trả về một HTTP 200 
        }

       
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            db.Products.Add(product);
            var result = await db.SaveChangesAsync();
            if(result == 1)
            {
                return Ok(product);
            }
            else
            {
                return BadRequest();//trả về một HTTP 400
            }
        }


        //api/product/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var pro = await db.Products.SingleOrDefaultAsync(x => x.Id == id);
            db.Products.Remove(pro);
            await db.SaveChangesAsync();
            return Ok(pro);
        }


       
    }
}

