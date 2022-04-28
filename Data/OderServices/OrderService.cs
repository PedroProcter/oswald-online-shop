using Microsoft.EntityFrameworkCore;
using oswald_online_shop.Models;

namespace oswald_online_shop.Data.OrderServices
{
    public class OrderService
    {
        public readonly MyDBContext _mydbcontext;

        public OrderService(MyDBContext mydbcontext)
        {
            _mydbcontext = mydbcontext;
        }
        public async Task<bool> insertOrder(Orders order)
        {
            _mydbcontext.Orders.Add(order);
            return await _mydbcontext.SaveChangesAsync() > 0;
        }

        public async Task<bool> deleteOrder(int id)
        {
            var order = await _mydbcontext.Orders.FindAsync(id);
            _mydbcontext.Orders.Remove(order);
            return await _mydbcontext.SaveChangesAsync() > 0;
        }








    

   

    }
}
