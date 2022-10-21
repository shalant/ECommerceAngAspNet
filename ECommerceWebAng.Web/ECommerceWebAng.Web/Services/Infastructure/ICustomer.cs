using ECommerceWebAng.Web.Models;

namespace ECommerceWebAng.Web.Services.Infastructure
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        void Save();
    }
}
