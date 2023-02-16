using BlazorCRUD.Server.Data;
using BlazorCRUD.Shared;
using System.Linq;

namespace BlazorCRUD.Server.ProductService
{
    public class ProductService : IProductService
    {
        public readonly AppDbContext _dbContext;
        public ProductService(AppDbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public Task<Product> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(int productId, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
