using System;
using Microsoft.EntityFrameworkCore;

namespace ProductOrder.Models
{
	public class OrderDbContext : DbContext
	{
		public OrderDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<OrderDetail>(e =>
			{
				e.HasKey(o => new { o.OrderId, o.ProductName });//khai bao khoa chinh 
				e.HasOne(e => e.Order).WithMany(o => o.OrderDetails).HasForeignKey(o => o.OrderId);//khai bao khoa ngoai
			});
			modelBuilder.Entity<Order>().HasData(new Order[]
			{
				new Order {Id = "O001", Address= "HCM", Name = "Van A", Phone = "113"},
                new Order {Id = "O002", Address= "NA", Name = "Van B", Phone = "114"},
                new Order {Id = "O003", Address= "DN", Name = "Van C", Phone = "115"},
            });

			modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail[]
			{
				new OrderDetail{OrderId = "O001", ProductName = "Pepsi", Price =3, Quantity=10},
                new OrderDetail{OrderId = "O002", ProductName = "CoCa", Price =5, Quantity=3},
                new OrderDetail{OrderId = "O003", ProductName = "7Up", Price =8, Quantity=1},
            });
        }
    }
}

