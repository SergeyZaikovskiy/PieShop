using Microsoft.AspNetCore.Mvc;
using PieShop.DAL.Interfaces;
using System.Linq;

namespace PieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.GetAllCategories.OrderBy(x => x.Name);
            return View(categories);
        }
    }
}
