using System;
using Microsoft.EntityFrameworkCore;

namespace Exercise.Models
{
	public class UserDbContext : DbContext
	{
		public UserDbContext(DbContextOptions options): base(options)
		{

		}

		public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<User>().HasData(new User[]
			{
				new User {Username="user1", Password="123", Name="Van A", Yob=2000},
				new User {Username="user2", Password="123", Name="Van B", Yob=2003},
				new User {Username="user3", Password="123", Name="Van C", Yob=2009}

            });
        }
    }
}

