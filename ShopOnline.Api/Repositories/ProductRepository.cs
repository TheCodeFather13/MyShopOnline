using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDbContext _shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            _shopOnlineDbContext = shopOnlineDbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var productCategories = await _shopOnlineDbContext.ProductCategories.ToListAsync();
            return productCategories;
        }

        [HttpGet]
        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _shopOnlineDbContext.Products.ToListAsync();
            return products;
        }
    }
}
