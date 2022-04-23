using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace oswald_online_shop.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<SliderOswald> Slider { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("");
                
         }
    }
}
