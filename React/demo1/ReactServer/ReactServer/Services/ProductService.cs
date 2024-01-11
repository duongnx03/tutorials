using System;
using Microsoft.EntityFrameworkCore;
using ReactServer.IRepository;
using ReactServer.Models;

namespace ReactServer.Services
{
	public class ProductService : IProductRepository
	{
		private readonly DatabaseContext db;

		public ProductService(DatabaseContext db)
		{
			this.db = db;
		}

        public async Task<Product> AddProduct(Product product)
        {
            db.Products.Add(product);
            await db.SaveChangesAsync();
            return product;
        }

        public Task<bool> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await db.Products.ToListAsync();
        }

        public Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

