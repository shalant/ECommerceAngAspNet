using ECommerceWebAng.Web.Models;

namespace ECommerceWebAng.Web.Services.Infastructure
{
    public interface ISubCategory
    {
        IEnumerable<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(int id);
        void Insert(SubCategory subCategory);
        void Update(SubCategory subCategory);
        void Delete(SubCategory subCategory);
        int Count();
        void Save();
    }
}
