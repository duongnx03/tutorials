using System;
using Demo_CustomStatusCode.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_CustomStatusCode.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

