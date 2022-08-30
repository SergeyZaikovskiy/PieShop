using PieShop.DAL.Interfaces;
using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.DAL.Implementations
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> MockCategories
        {
            get
            {
                return new List<Category>()
                {

                    new Category {Id = 1, Name = "Fruit Pies", Description = "All fruit pies" },
                    new Category {Id = 2, Name = "Cheese cakes",  Description = "Cheese sweety pies"},
                    new Category {Id = 3, Name = "Seasonal pies", Description = "Best pies" }

                }.AsEnumerable();
            }
        }

        public IEnumerable<Category> GetAllCategories()
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
