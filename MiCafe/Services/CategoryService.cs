using MiCafe.Models;
using MiCafe.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiCafe.Services
{
    public class CategoryService : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Breakfast", Description = "This is a breakfast"},
                new Category {CategoryId = 2, CategoryName = "Sandwich", Description = "This is a sandwich"},
                new Category {CategoryId = 3, CategoryName = "Salads", Description = "This is a salads"},
            };
    }
}
