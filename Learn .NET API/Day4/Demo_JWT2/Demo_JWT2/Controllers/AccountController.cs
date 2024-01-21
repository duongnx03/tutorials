using Demo_JWT2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo_JWT2.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly DatabaseContext db;
        public AccountController(DatabaseContext db)
        {
            this.db = db;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> GetAccount(int id)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Id == id);
            return Ok(acc);
        }

    }
}

