using BlazorCRUD.Server.Data;
using BlazorCRUD.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD.Server.ProductService
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _dbContext;
        public ProductService(AppDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public async Task<Product> CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var dbProduct = await _dbContext.Products.FindAsync(productId);
            if (dbProduct == null) return false;

            _dbContext.Remove(dbProduct);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Product?> GetProductById(int productId)
        {
            return await _dbContext.Products.FindAsync(productId);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> UpdateProduct(int productId, Product product)
        {
            var productDb = await _dbContext.Products.FindAsync(productId);
            if(productDb != null)
            {
                productDb.Title = product.Title;
                productDb.Price = product.Price;
                productDb.Category = product.Category;

                await _dbContext.SaveChangesAsync();
            }
            return product;
        }
    }
}
