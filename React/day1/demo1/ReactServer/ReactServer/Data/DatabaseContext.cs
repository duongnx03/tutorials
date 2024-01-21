using Microsoft.EntityFrameworkCore;
using ReactServer.Models;

namespace ReactServer.Models
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
			modelBuilder.Entity<Product>().HasData(new Product[]
			{
				new Product{Id = 1, Name = "CoCa", Description= "Drink", Price = 10},
                new Product{Id = 2, Name = "7Up", Description= "Drink", Price = 7},
                new Product{Id = 3, Name = "Pepsi", Description= "Drink", Price = 9}
            });
        }
    }
}

