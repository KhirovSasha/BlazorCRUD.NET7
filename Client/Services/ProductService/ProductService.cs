using BlazorCRUD.Shared;
using System.Net;
using System.Net.Http.Json;

namespace BlazorCRUD.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product?> GetProductById(int Id)
        {
            var result = await _http.GetAsync($"api/product/{Id}");

            if(result.StatusCode == HttpStatusCode.OK) 
            {
                return await result.Content.ReadFromJsonAsync<Product>();
            }

            return null;
        }

        public async Task GetProducts()
        {
            var results = await _http.GetFromJsonAsync<List<Product>>("api/product");

            if (results is not null) Products = results;
        }

        public Task UpdateProduct(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
