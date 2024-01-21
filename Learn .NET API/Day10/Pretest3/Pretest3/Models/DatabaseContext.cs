using System;
using Microsoft.EntityFrameworkCore;

namespace Pretest3.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options): base(options)
		{

		}

		public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Account>().HasData( new Account[]
			{
                new Account {Username="user", Password="123", Balance= 1000},
               new Account {Username="amdin", Password="123", Balance= 33000}
               
            });
        }
    }
}

