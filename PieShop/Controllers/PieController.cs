using Microsoft.AspNetCore.Mvc;
using PieShop.DAL.Interfaces;
using PieShop.Models;
using PieShop.ViewModels;
using System.Linq;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository category;

        public PieController(IPieRepository pieRepository, ICategoryRepository category)
        {
            this.pieRepository = pieRepository;
            this.category = category;
        }

        public IActionResult List(string categoryName)
        {
            var model = new PiesListViewModel();

            if (string.IsNullOrEmpty(categoryName))
            {
                model.Pies = pieRepository.GetAllPies;
                model.CurrentCategoryName = "All pies";
            }
            else
            {
                model.Pies = pieRepository.GetAllPies.Where(p => p.Category.Name == categoryName);
                model.CurrentCategoryName = categoryName;
            }

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var pie = pieRepository.GetPieById(id);

            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}
