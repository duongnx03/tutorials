using System;
using Demo3Table.Models;

namespace Demo3Table.IRepository
{
	public interface IUserRepo
	{
		Task<User> Login(string email, string password);
	}
}

