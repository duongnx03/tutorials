using LastPretest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LastPretest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DatabaseContext db;

        public AccountController(DatabaseContext db)
        {
            this.db = db;
        }

        [HttpGet("login/{username}/{password}")]
        public async Task<Account> GetLogin(string username, string password)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Username == username && a.Password == password);
            if (acc != null)
            {
                return acc;
            }
            return null;
        }

        [HttpGet("withdraw/{username}/{amount}")]
        public async Task<bool> GetWithdraw(string username, int amount)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Username == username);
            if (acc != null)
            {
                acc.Balance -= amount;

                return true;
            }
            return false;
        }

        [HttpGet("deposite/{username}/{amount}")]
        public async Task<bool> GetDeposite(string username, int amount)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Username == username);
            if (acc != null)
            {
                acc.Balance += amount;
                return true;
            }
            return false;
        }
    }
}
