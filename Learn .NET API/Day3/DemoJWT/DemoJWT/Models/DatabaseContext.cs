using System;
using Microsoft.EntityFrameworkCore;

namespace DemoJWT.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product {Id = 1, Name = "Pepsi", Price = 12, Description = "Drink"},
                new Product {Id = 2, Name = "Chocopie", Price = 12, Description = "Cake"}
            });
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User {Id = 1, Name = "Tri lo", Email = "user", Password = "123", Role = "User"},
                new User {Id = 2, Name = "Dien lo", Email = "admin", Password = "123", Role = "Admin"},
            });
        }
    }
}

