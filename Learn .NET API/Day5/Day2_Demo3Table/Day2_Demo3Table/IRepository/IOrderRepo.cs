using Day2_Demo3Table.Models;

namespace Day2_Demo3Table.IRepository
{
    public interface IOrderRepo
    {
        Task<int> AddOrder(Order order);

        Task<IEnumerable<Order>> GetAllOrders(int userId);

        Task<Order> GetOrderDetails(int OrderId);
    }
}
