using System;
using Demo3Table.IRepository;
using Demo3Table.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo3Table.Repository
{
    public class CartRepo : ICartRepo
    {
        private readonly DatabaseContext db;

        public CartRepo(DatabaseContext db)
        {
            this.db = db;
        }


        public async Task<int> AddCart(Cart cart)
        {
            var oldCart = await db.Carts.SingleOrDefaultAsync(c => c.UserId == cart.UserId && c.ProductId == cart.ProductId);
            if(oldCart == null)
            {
                db.Carts.Add(cart);
                var result = await db.SaveChangesAsync();
                return result;
            }
            return await UpdateQuantity(oldCart.Id, cart.Quantity);
        }

        public Task<int> DeleteCart(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cart>> GetAll(int userId)
        {
            return await db.Carts.Include(c => c.Product).Where(c => c.UserId == userId).ToListAsync();
        }

        public async Task<int> UpdateQuantity(int id, int quantity)
        {
            Cart? cart = await db.Carts.SingleOrDefaultAsync(c => c.Id == id);
            cart.Quantity += quantity;
            return await db.SaveChangesAsync();
        }
    }
}

