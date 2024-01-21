using System;
using Microsoft.EntityFrameworkCore;

namespace Student1427717.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<tbBook> tbBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<tbBook>()
                .Property(a => a.Price)
                .HasColumnType("decimal(15, 2)");

            modelBuilder.Entity<tbBook>().HasData(new tbBook[]
           {
                new tbBook{Id = 1, Title = "JS", Price = 100, ImageUrl = "cat.jpeg"},
                new tbBook{Id = 2, Title = "C++", Price = 200, ImageUrl = "cat.jpeg"}
             
           });
        }
    }
}

