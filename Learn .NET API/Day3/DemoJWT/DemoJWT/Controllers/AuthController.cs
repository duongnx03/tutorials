using DemoJWT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task< User> Authenticate(UserLogin userLogin)
        {
            var lisUser = await db.Users.ToListAsync();
            if(lisUser != null && lisUser.Count > 0)
            {
                var currentUser = lisUser.SingleOrDefault(u => u.Email.ToLower() == userLogin.Email.ToLower() && u.Password == userLogin.Password);
                return currentUser;
            }
            return null;
        }

        [NonAction]
        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim("Name", user.Name),
                new Claim("Email", user.Email),
                new Claim(ClaimTypes.Role, user.Role)
        };
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"], claims, expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credential);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> login(UserLogin userLogin)
        {
            var user = await Authenticate(userLogin);
            if(user != null)
            {
                var token = GenerateToken(user);
                return Ok(new { token });
            }
            return NotFound("user not found");
        }

        
    }
}

