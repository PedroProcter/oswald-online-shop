namespace oswald_online_shop.Models
{
    public class Cart
    {
        public int id { get; set; }

        public string idClient { get; set; }
        public Decimal price { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string location { get; set; }

    }
}
