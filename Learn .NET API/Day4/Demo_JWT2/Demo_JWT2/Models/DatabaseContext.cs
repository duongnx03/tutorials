using System;
using Microsoft.EntityFrameworkCore;

namespace Demo_JWT2.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

		public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Account>().HasData(new Account[]
			{
				new Account {Id = 1, Email = "user", Name="Van A", Password = "123", Role="User"},
                new Account {Id = 2, Email = "admin", Name="Van B", Password = "123", Role="Admin"}
            });
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product {Id = 1, Name = "user", Description="Van A", Price = 10},
                new Product {Id = 2, Name = "user", Description="Van A", Price = 10},
            });
        }
    }
}

