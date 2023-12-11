using System;
using Microsoft.EntityFrameworkCore;
using DemoFulentAPI.Models;

namespace DemoFulentAPI.Models
{
	public class ProductContext : DbContext
	{
		public ProductContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>(c =>
			{
				c.HasKey(c => c.Id);
				c.Property(c => c.Name).HasMaxLength(150);
			});
			modelBuilder.Entity<Category>().HasData(new Category[]
			{
				new Category{Id = 1, Name = "Food"},
                new Category{Id = 2, Name = "Book"}
            });

			modelBuilder.Entity<Product>(p =>
			{
				p.HasKey(p => p.Id);
				p.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.Id);
			});

            modelBuilder.Entity<Product>().HasData(new Product[]
			{
                new Product{Id = 1, Name = "Food", CategoryId = 1},
                new Product{Id = 2, Name = "Book", CategoryId = 2}
            });

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<DemoFulentAPI.Models.Category> Category { get; set; } = default!;

		public DbSet<DemoFulentAPI.Models.Product> Product { get; set; } = default!;

	}
}

