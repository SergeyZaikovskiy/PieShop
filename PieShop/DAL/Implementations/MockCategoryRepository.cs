using PieShop.DAL.Interfaces;
using PieShop.Models;
using System.Linq;

namespace PieShop.DAL.Implementations
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IQueryable<Category> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category GetCategoryByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
