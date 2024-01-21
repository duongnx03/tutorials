using System;
using Demo3Table.IRepository;
using Demo3Table.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo3Table.Repository
{
	public class ProductRepo : IProductRepo
	{
        private readonly DatabaseContext db;

        public ProductRepo(DatabaseContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await db.Products.ToListAsync();
        }
    }
}

