using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Demo_JWT2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo_JWT2.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly DatabaseContext db;
        private readonly IConfiguration configuration;

        public AuthController(DatabaseContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        [NonAction]
        private async Task<Account> Authenticate(AccountLogin userLogin)
        {
                var currentAccount = await db.Accounts.SingleOrDefaultAsync(u => u.Email == userLogin.Email && u.Password == userLogin.Password);
                return currentAccount;
           
        }

        [NonAction]
        private string GenerateToken(Account user)
        {
            var securiryKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credential = new SigningCredentials(securiryKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim("Name", user.Name),
                new Claim("Email", user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"], claims, expires: DateTime.Now.AddMinutes(50),
                signingCredentials: credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login([FromBody] AccountLogin accountLogin)
        {
            var account = await Authenticate(accountLogin);
            if (account != null)
            {
                var token = GenerateToken(account);
                return Ok(new { token });
            }
            return NotFound("account not found");
        }
    }
}

