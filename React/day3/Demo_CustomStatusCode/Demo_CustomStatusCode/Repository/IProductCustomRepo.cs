using System;
using Demo_CustomStatusCode.CustomStatus;
using Demo_CustomStatusCode.Models;

namespace Demo_CustomStatusCode.Repository
{
	public interface IProductCustomRepo
	{
        Task<CustomResult> GetAll();
        Task<CustomResult> GetById(int id);
        Task<CustomResult> AddProduct(Product product);
        Task<CustomResult> UpdateProduct(Product product);
        Task<CustomResult> DeleteProduct(int id);
    }
}

