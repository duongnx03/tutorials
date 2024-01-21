using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_CustomStatusCode.CustomStatus;
using Demo_CustomStatusCode.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo_CustomStatusCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepo repo;

        public ProductController(ProductRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                var result = await repo.GetAll();
               
                if(result == null)
                {
                    CustomResult custom = new CustomResult(401, "Get List Fail", null);//401 loi repository
                    return BadRequest(custom);
                }
                else if(result.Count() == 0)
                {
                    CustomResult custom = new CustomResult(201, "List is Empty", null);
                    return Ok(custom);
                }
                else
                {
                    CustomResult custom = new CustomResult(200, "Get List Success", result);
                    return Ok(custom);
                }

            }
            catch(Exception e)
            {
                CustomResult custom = new CustomResult(402, e.Message, null);//402 loi controller
                return Ok(custom);
            }
        }
    }
}

