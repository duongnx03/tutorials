using System;
using Demo3Table.Models;

namespace Demo3Table.IRepository
{
	public interface IProductRepo
	{
		Task<IEnumerable<Product>> GetProducts();
	}
}

