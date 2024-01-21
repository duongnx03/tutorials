using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactServer.IRepository;
using ReactServer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository repo;

        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            return Ok(await repo.GetProducts());
        }

        [HttpPost]
        public async Task<ActionResult> PostProduct(Product product)
        {
            return Ok(await repo.AddProduct(product));
        }
    }
}

