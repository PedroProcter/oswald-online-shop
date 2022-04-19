namespace oswald_online_shop.Models
{
    public class Orders
    {
        public int id { get; set; }
        public string cartId { get; set; }
        public int productId { get; set; }

        public string state { get; set; }
        public double price { get; set; }


    }
}
