using System;
using Demo3Table.Models;

namespace Demo3Table.IRepository
{
	public interface IOrderRepo
	{
		Task<int> AddOrder(Order order);
		Task<int> DeleteOrder(int Id);
		Task<IEnumerable<Order>> GetAllOrders();
	}
}

