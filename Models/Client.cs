namespace oswald_online_shop.Models
{
    public class Client
    {
        public int id { get; set; }
        public string cartId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime birthDay { get; set; }

    }
}
