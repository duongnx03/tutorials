using System;
using Microsoft.EntityFrameworkCore;

namespace Demo3Table.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>(u =>
            {
                u.HasKey(u => u.Id);
                u.HasData(new User[]
                {
                    new User{Id=1, Name = "Tri Lor", Email="tri", Password="123"},
                     new User{Id=2, Name = "Dien Lor", Email="dien", Password="123"}
                });
            });

			modelBuilder.Entity<Product>(p =>
			{
				p.HasKey(p => p.Id);
				p.HasData(new Product[]
				{
					new Product {Id = 1, Name = "Sua Chua", Description= "Do Lanh", Price= 7},
                    new Product {Id = 2, Name = "Trung Ga", Description= "Do Song", Price= 4},
                    new Product {Id = 3, Name = "Mi Goi", Description= "Do Co San", Price= 10}
                });
			});

            modelBuilder.Entity<Order>(o =>
            {
                o.HasKey(o => o.Id);
                o.HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);
                o.HasData(new Order[]
                {
                    new Order {Id = 1, UserId = 1, Address= "Trong Rung", OrderDate= DateTime.Now, Phone= "111"},
                   new Order {Id = 2, UserId = 2, Address= "Duoi Cau", OrderDate= DateTime.Now, Phone= "123"}
                });
            });

            modelBuilder.Entity<OrderDetail>(od =>
            {
                od.HasKey(od => new { od.ProductId, od.OrderId });
                od.HasOne(od => od.Order).WithMany(o => o.Details).HasForeignKey(o => o.OrderId);
                od.HasOne(od => od.Product).WithMany(p => p.OrderDetails).HasForeignKey(od => od.ProductId);
                od.HasData(new OrderDetail[]
                {
                    new OrderDetail {OrderId = 1, ProductId = 1, Quantity= 7},
                    new OrderDetail {OrderId = 1, ProductId = 2, Quantity= 3},
                    new OrderDetail {OrderId = 2, ProductId = 2, Quantity= 5},
                    new OrderDetail {OrderId = 2, ProductId = 3, Quantity= 71}
                });
            });

            modelBuilder.Entity<Cart>(c =>
            {
                c.HasOne(c => c.Product).WithMany(p => p.Carts).HasForeignKey(c => c.ProductId);
            });
        }
    }
}

