﻿using Catalog.API.Entities;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(string id);
        Task<IEnumerable<Product>> GetProductByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductByCategoryAsync(string category);

        Task CreateProduct(Product product);
        Task<bool> DeleteProductAsync(string id);
        Task<bool> UpdateProductAsync(Product product);
    }
}
