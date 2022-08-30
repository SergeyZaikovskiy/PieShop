using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.DAL.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();

        Category GetCategoryById(int id);   

        Category GetCategoryByName(string name);
    }
}
