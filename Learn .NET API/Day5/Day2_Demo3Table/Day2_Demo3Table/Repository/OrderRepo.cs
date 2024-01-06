using System;
using Day2_Demo3Table.Data;
using Day2_Demo3Table.IRepository;
using Day2_Demo3Table.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2_Demo3Table.Repository
{
	public class OrderRepo : IOrderRepo
	{

        private readonly DatabaseContext db;

        public OrderRepo(DatabaseContext db)
        {
            this.db = db;
        }

        public async Task<int> AddOrder(Order order)
        {
            //tao transaction
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    //lay list cart cua user dua vao userId
                    var listCart = await db.Carts.Where(c => c.UserId == order.UserId).ToListAsync();
                    order.Details = new List<OrderDetail>();
                    //lay list cart gan vao order detail cua order
                    foreach (var item in listCart)
                    {
                        OrderDetail details = new OrderDetail();
                        details.ProductId = item.ProductId;
                        details.Quantity = item.Quantity;
                        order.Details.Add(details);
                    }
                    db.Orders.Add(order);
                    foreach (var cart in listCart)
                    {
                        db.Carts.Remove(cart);
                    }
                    var result = await db.SaveChangesAsync();
                    transaction.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }


        public async Task<IEnumerable<Order>> GetAllOrders(int userId)
        {
            return await db.Orders.Where(o => o.UserId == userId).ToListAsync();
        }

        public async Task<Order> GetOrderDetails(int OrderId)
        {
            var result = await db.Orders.Include(c => c.Details)
                .ThenInclude(od => od.Product)
                .SingleOrDefaultAsync(o => o.Id == OrderId);
            return result;
        }
    }
}

