using System;
using Demo3Table.IRepository;
using Demo3Table.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo3Table.Repository
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

