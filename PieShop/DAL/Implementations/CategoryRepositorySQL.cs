using PieShop.DAL.Interfaces;
using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.DAL.Implementations
{
    public class CategoryRepositorySQL : ICategoryRepository
    {
        private readonly AppDbContext db;

        public CategoryRepositorySQL(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return db.Categories;
        }

        public Category GetCategoryById(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> GetCategoryByName(string name)
        {
            return db.Categories.Where(c => c.Name.StartsWith(name));
        }
    }
}
