﻿using BlazorCRUD.Shared;

namespace BlazorCRUD.Server.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProductById(int productId);
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(int productId, Product product);
        Task<bool> DeleteProduct(int productId);
    }
}
