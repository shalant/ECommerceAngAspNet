using ECommerceWebAng.Web.Models;

namespace ECommerceWebAng.Web.Services.Infastructure
{
    public interface IOrder
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void Delete(Order order);
        int Count();
        void Save();
    }
}
