using System;
using Demo_CustomStatusCode.CustomStatus;
using Demo_CustomStatusCode.Data;
using Demo_CustomStatusCode.Models;
using Demo_CustomStatusCode.Repository;
using Microsoft.EntityFrameworkCore;

namespace Demo_CustomStatusCode.Services
{
	public class ProductCustomService : IProductCustomRepo
	{
        private readonly DatabaseContext db;
        public ProductCustomService(DatabaseContext db)
        {
            this.db = db;
        }

        public async Task<CustomResult> AddProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                var result = await db.SaveChangesAsync();
                if(result == 1)
                {
                    CustomResult custom = new CustomResult(200, "Create Success", product);
                    return custom;
                }
                CustomResult cus = new CustomResult(402, "Create Fail", null);
                return cus;
            }
            catch(Exception e)
            {
                CustomResult custom = new CustomResult(402, e.Message, null);
                return custom;
            }
        }

        public Task<CustomResult> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomResult> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResult> GetById(int id)
        {
            try
            {
                var pro = await db.Products.SingleOrDefaultAsync(p => p.Id == id);
                if(pro == null)
                {
                    CustomResult custom = new CustomResult(402, "", null);
                    return custom;
                }
                return null;
                
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Task<CustomResult> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

