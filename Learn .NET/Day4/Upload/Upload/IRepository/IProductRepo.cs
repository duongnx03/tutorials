using System;
using Upload.Models;

namespace Upload.IRepository
{
	public interface IProductRepo
	{
        Task<IEnumerable<Product>> GetProducts();

		Task<Product> GetProduct(int id);

		Task<int> Create(Product product);

		Task<int> Update(Product product);

		Task<int> Delete(int id);
	}
}

