using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pretest3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pretest3.Controllers
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
        public async Task<IActionResult> Login(string username, string password)
        {
            var acc = await db.Accounts.FirstOrDefaultAsync(a => a.Username == username && a.Password == password);
            if (acc != null)
            {
                return Ok(acc); // Trả về thông tin tài khoản nếu đăng nhập thành công
            }
            return NotFound("Account not found");
        }


        [HttpGet("Withdraw/{username}/{amount}")]
        public async Task<IActionResult> Withdraw(string username, int amount)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(a => a.Username == username);
            if (acc != null)
            {
                if (acc.Balance >= amount)
                {
                    acc.Balance -= amount;
                    await db.SaveChangesAsync();
                    return Ok(true);
                }
                return BadRequest("Insufficient balance");
            }
            return NotFound("Account not found");
        }

        [HttpGet("Deposit/{username}/{amount}")]
        public async Task<IActionResult> Deposit(string username, int amount)
        {
            var acc = await db.Accounts.SingleOrDefaultAsync(d => d.Username == username);
            if (acc != null)
            {
                acc.Balance += amount;
                await db.SaveChangesAsync();
                return Ok(true);
            }
            return NotFound("Account not found");
        }


    }
}

