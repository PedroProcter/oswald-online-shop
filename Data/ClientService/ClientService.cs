using oswald_online_shop.Models;

namespace oswald_online_shop.Data.ClientService
{
    public class ClientService
    {
        public readonly MyDBContext _myDBContext;

        public ClientService(MyDBContext myDBContext)
        {
            _myDBContext=myDBContext;
        }

        public async Task<bool> insertClient(Client client)
        {
             _myDBContext.Clients.Add(client);
            return  await _myDBContext.SaveChangesAsync()>0;
        }
    }
}
