using oswald_online_shop.Models;

namespace oswald_online_shop.Data.CartServices
{
    public class CartService
    {
        public readonly MyDBContext _myDBContext;
    
        public CartService(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }
        

        public async Task<bool> insertCart(Cart cart)
        {
            _myDBContext.Carts.Add(cart);
            return await _myDBContext.SaveChangesAsync()>0;
        }
    }
}
