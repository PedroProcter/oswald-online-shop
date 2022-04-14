namespace oswald_online_shop.Models
{
    public class User
    {
        public int id{ get; set; }
        public int clientId { get; set; }

        public string username { get; set; }
        public string pwd{ get; set; }
    }
}
