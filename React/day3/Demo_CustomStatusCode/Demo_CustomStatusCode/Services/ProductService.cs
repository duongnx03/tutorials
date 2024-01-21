using System;
using Demo_CustomStatusCode.Data;
using Demo_CustomStatusCode.Models;
using Demo_CustomStatusCode.Repository;
using Microsoft.EntityFrameworkCore;

namespace Demo_CustomStatusCode.Services
{
	public class ProductService : ProductRepo
	{
        private readonly DatabaseContext db;
		public ProductService(DatabaseContext db) 
		{
            this.db = db;
		}

        public async Task<Product> AddProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                var result = await db.SaveChangesAsync();
                if(result == 1)
                {
                    return product;
                }
                return null;               
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public async Task<Product> DeleteProduct(int id)
        {
            var pro = await GetById(id);
            if (pro == null)
            {
                return null;
            }
            else
            {
                try
                {
                    db.Products.Remove(pro);
                    var result = await db.SaveChangesAsync();
                    if(result == 1)
                    {
                        return pro;
                    }
                    return null;
                }
                catch
                {
                    return null;
                }
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            try
            {
                var list = await db.Products.ToListAsync();
                return list;
            }
            catch
            {
                return null;
            }           
            
        }

        public async Task<Product> GetById(int id)
        {
            try
            {
                var pro = await db.Products.SingleOrDefaultAsync(p => p.Id == id);
                return pro;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            try
            {
                var oldPro = await GetById(product.Id);
                if(oldPro == null)
                {
                    return null;
                }
                oldPro.Price = product.Price;
                oldPro.Name = product.Name;
                oldPro.Description = product.Description;

                //db.Products.Update(product); neu resull == 0 thi them dong nay
                var result = await db.SaveChangesAsync();
                if(result == 1)
                {
                    return oldPro;
                }
                return null;
            }
            catch { return null; }
        }
    }
}

