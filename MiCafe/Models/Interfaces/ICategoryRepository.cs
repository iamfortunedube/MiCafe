using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiCafe.Models.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
