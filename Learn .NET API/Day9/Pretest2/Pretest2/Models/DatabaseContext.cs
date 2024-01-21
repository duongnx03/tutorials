using System;
using Microsoft.EntityFrameworkCore;

namespace Pretest2.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{
			
		}

		public DbSet<tbNews> tbNews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<tbNews>().HasData(new tbNews[]
			{
				new tbNews{NewsId = "new1", NewsContent="ncc", DateOfPublish="4/1/2024"},
                new tbNews{NewsId = "new2", NewsContent="ndb", DateOfPublish="5/1/2024"},
                new tbNews{NewsId = "new3", NewsContent="dmm", DateOfPublish="6/1/2024"}
            });
        }
    }
}

