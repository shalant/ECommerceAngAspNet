using ECommerceWebAng.Web.Models;

namespace ECommerceWebAng.Web.Services.Infastructure
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(Product product);
        int Count();
        void Save();
    }
}
