using Day2_Demo3Table.Data;
using Day2_Demo3Table.IRepository;
using Day2_Demo3Table.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2_Demo3Table.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly DatabaseContext db;

        public UserRepo(DatabaseContext db)
        {
            this.db = db;
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await db.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user;
        }
    }
}
