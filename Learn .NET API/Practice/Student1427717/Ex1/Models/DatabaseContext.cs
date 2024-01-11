using System;
using Microsoft.EntityFrameworkCore;

namespace Ex1.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<>().HasData(new[])
            {
                            
            });
        }

    }
}

