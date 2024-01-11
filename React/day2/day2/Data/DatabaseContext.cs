using System;
using day2.Models;
using Microsoft.EntityFrameworkCore;

namespace day2.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options) 
		{
		}

		public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Student>().HasData(new Student[]
			{
				new Student{Id = 1, Name = "Nhi", Mark = 100, Email = "nhi@gmail.com"},
                new Student{Id = 2, Name = "Tri", Mark = 80, Email = "tri@gmail.com"},
				new Student{Id = 3, Name = "Dien", Mark = 60, Email = "dien@gmail.com"}
            });
        }
    }
}

