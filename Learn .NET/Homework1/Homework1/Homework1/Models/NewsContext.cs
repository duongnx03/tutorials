using System;
using Microsoft.EntityFrameworkCore;

namespace Homework1.Models
{
	public class NewsContext : DbContext
	{
		public NewsContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<tbAdmin> Admins { get; set; }
        public DbSet<tbNews> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<tbAdmin>().HasData(new tbAdmin { Username = "admin", Password = "123" });
            base.OnModelCreating(modelBuilder);
        }
    }
}

