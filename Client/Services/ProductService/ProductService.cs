using BlazorCRUD.Shared;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace BlazorCRUD.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ProductService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public async Task CreateProduct(Product product)
        {
            await _http.PostAsJsonAsync("api/product", product);
            _navigationManager.NavigateTo("products");
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

        public async Task UpdateProduct(int id, Product product)
        {
            await _http.PutAsJsonAsync($"api/product/{id}", product);
            _navigationManager.NavigateTo("products");
        }
    }
}
