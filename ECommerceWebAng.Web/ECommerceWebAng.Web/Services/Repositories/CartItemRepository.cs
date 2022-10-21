using ECommerceWebAng.Web.Data;
using ECommerceWebAng.Web.Models;
using ECommerceWebAng.Web.Services.Infastructure;

namespace ECommerceWebAng.Web.Services.Repositories
{
    public class CartItemRepository : ICartItem
    {
        private ApplicationDbContext _context;

        public CartItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Count()
        {
            return _context.Categories.Count(); 
        }

        public void Delete(int id)
        {
            var cartItem = _context.CartItems.FirstOrDefault(c => c.Id == id);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
            }
        }

        public CartItem GetCartItem(int id)
        {
            var cartItem = _context.CartItems.FirstOrDefault(x => x.Id == id);
            if (cartItem != null)
            {
                return cartItem;
            }
            return null;
        }

        public IEnumerable<CartItem> GetCartItems()
        {
            return _context.CartItems;
        }

        public void Insert(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(CartItem cartItem)
        {
            _context.CartItems.Update(cartItem);
        }
    }
}
