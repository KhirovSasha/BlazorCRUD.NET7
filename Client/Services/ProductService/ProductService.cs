using BlazorCRUD.Shared;
using System.Net.Http.Json;

namespace BlazorCRUD.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
