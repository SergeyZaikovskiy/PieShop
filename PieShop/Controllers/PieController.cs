using Microsoft.AspNetCore.Mvc;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
