using BlazorCRUD.Server.ProductService;
using BlazorCRUD.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCRUD.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            return await _productService.GetProducts();
        }

        [HttpGet("{id}")]
        public async Task<Product?> GetProductById(int id)
        {
            return await _productService.GetProductById(id);
        }
    }
}
