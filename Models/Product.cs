namespace oswald_online_shop.Models
{
    public class Product
    {
        public int id { get; set; }
        
        public string name { get; set; }
    
        public string category { get; set; }
        public double price { get; set; } 
        
        public string photoURL  { get; set; }


        public int Stock { get; set; }
    }
}
