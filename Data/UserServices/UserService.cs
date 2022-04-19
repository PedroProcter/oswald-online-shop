using Microsoft.EntityFrameworkCore;
using oswald_online_shop.Models;

namespace oswald_online_shop.Data.UserServices
{
    public class UserService
    {
        public readonly MyDBContext _myDBContext;

        public UserService(MyDBContext myDBContext)
        {
            _myDBContext=myDBContext;
        }

        public async Task <IEnumerable<User>> getAllUsers()
        {
            return await _myDBContext.Users.ToListAsync();
        }

        public async Task<bool> insertUser(User user)
        {
            _myDBContext.Users.Add(user);
            return await _myDBContext.SaveChangesAsync() > 0;
        } 

    }
}
