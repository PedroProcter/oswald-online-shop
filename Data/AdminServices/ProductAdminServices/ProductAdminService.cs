using Microsoft.EntityFrameworkCore;
using oswald_online_shop.Models;

namespace oswald_online_shop.Data.AdminServices.ProductAdminServices
{
    public class ProductAdminService
    {
        public readonly MyDBContext _dbContext;

        public ProductAdminService(MyDBContext myDbContext)
        {
            _dbContext = myDbContext;
        }

        public async Task<bool> deleteProduct(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            _dbContext.Products.Remove(product);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Product>> getAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> getProduct(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }

        public async Task<bool> insertProduct(Product product)
        {
            _dbContext.Products.Add(product);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> saveProduct(Product product)
        {
            if (product.id==0)
                return await insertProduct(product);
            else
                return await updateProduct(product);
        }

        public async Task<bool> updateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}

