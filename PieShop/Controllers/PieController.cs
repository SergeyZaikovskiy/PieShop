using Microsoft.AspNetCore.Mvc;
using PieShop.DAL.Interfaces;
using PieShop.ViewModels;

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

        public IActionResult List()
        {
            var model = new PiesListViewModel();
            model.Pies = pieRepository.GetAllPies();
            model.CurrentCategoryName = "Super";

            return View(model);
        }
    }
}
