using PieShop.Models;
using System.Linq;

namespace PieShop.DAL.Interfaces
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAllCategories();

        Category GetCategoryById(int id);   

        Category GetCategoryByName(string name);
    }
}
