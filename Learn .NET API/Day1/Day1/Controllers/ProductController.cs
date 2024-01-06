using Day1.Models;
using Day1.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
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
            return Ok(await repo.PostProduct(product));
        }
    }
}

