
using Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exercise.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly UserDbContext db;
        public UserController(UserDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var list = await db.Users.ToListAsync();
            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] User user)
        {
            try
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest();
            }
        }

        [HttpGet("{username}")]
        public async Task<ActionResult> GetUser(string username)
        {
            var user =await db.Users.SingleOrDefaultAsync(x => x.Username == username);
            if(user != null)
            {
                return Ok(user);
            }
            return BadRequest();
        }

        [HttpPut]
        public async Task<ActionResult> PutUser([FromBody] User user)
        {
            var olduser = await db.Users.SingleOrDefaultAsync(u => u.Username == user.Username);
            if(olduser != null)
            {
                olduser.Password = user.Password;
                olduser.Name = user.Name;
                olduser.Yob = user.Yob;
                await db.SaveChangesAsync();
                return NoContent(); //200 without body
            }
            return BadRequest();
        }

        [HttpDelete("{username}")]
        public async Task<ActionResult> DeleteUser(string username)
        {
            var olduser = await db.Users.SingleOrDefaultAsync(u => u.Username == username);
            if (olduser != null)
            {
                db.Users.Remove(olduser);
                await db.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest();
        }
    }
}

