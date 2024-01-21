using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo3Table.IRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo3Table.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo userRepo;
        public UserController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        [HttpGet("{email}/{password}")]
        public async Task<ActionResult> CheckLogin(string email, string password)
        {
            var user = await userRepo.Login(email, password);
            return Ok(user);
        }
    }
}

