using System;
using Demo_CustomStatusCode.Models;

namespace Demo_CustomStatusCode.Repository
{
	public interface ProductRepo
	{
		Task<IEnumerable<Product>> GetAll();
		Task<Product> GetById(int id);
		Task<Product> AddProduct(Product product);
		Task<Product> UpdateProduct(Product product);
		Task<Product> DeleteProduct(int id);
    }
}
