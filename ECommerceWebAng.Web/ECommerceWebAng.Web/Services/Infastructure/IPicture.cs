using ECommerceWebAng.Web.Models;

namespace ECommerceWebAng.Web.Services.Infastructure
{
    public interface IPicture
    {
        Picture GetPicture(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        void Save();
    }
}
