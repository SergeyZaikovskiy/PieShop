using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.DAL.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }

        Category GetCategoryById(int id);

        IEnumerable<Category> GetCategoryByName(string name);
    }
}
