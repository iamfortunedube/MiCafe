using MiCafe.Models;
using MiCafe.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiCafe.Services
{
    public class ProductService : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryService();
        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {CategoryId = 1, Name = "Omelets", Price = 55.00m, ShortDescription = "This is a description"},
                new Product {CategoryId = 1, Name = "Lamb Curry Sandwich", Price = 35.00m, ShortDescription = "This is a description"},
                new Product {CategoryId = 1, Name = "Cheese", Price = 28.00m, ShortDescription = "This is a description"},
            };

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
