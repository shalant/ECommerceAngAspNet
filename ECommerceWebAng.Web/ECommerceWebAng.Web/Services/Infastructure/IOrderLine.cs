using ECommerceWebAng.Web.Models;

namespace ECommerceWebAng.Web.Services.Infastructure
{
    public interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();
        OrderLine GetOrderLine(int id);
        void Insert(OrderLine orderLine);
        void Update(OrderLine orderLine);
        int Count();
        void Save();
    }
}
