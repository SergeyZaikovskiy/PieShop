using Microsoft.AspNetCore.Mvc;
using PieShop.DAL.Interfaces;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pieOfTheWeek = new HomeViewModel
            {
                PiesOfTheWeek = pieRepository.PiesOfTheWeek
            };        
            return View(pieOfTheWeek); 
        }
    }
}
