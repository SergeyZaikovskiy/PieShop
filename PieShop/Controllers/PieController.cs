using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PieShop.DAL.Interfaces;
using PieShop.Domain;
using PieShop.Models;
using PieShop.ViewModels;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<IActionResult> List(string categoryName, SortPieState sortState)
        {
            var pies = pieRepository.GetAllPies;

            pies = sortState switch
            {
                SortPieState.NameDesc =>  pies.Where(p => (!string.IsNullOrEmpty(categoryName)) ? p.Category.Name == categoryName : true).OrderByDescending(p => p.Name),
                SortPieState.PriceAsc =>  pies.Where(p => (!string.IsNullOrEmpty(categoryName)) ? p.Category.Name == categoryName : true).OrderBy(p => p.Price),
                SortPieState.PriceDes =>  pies.Where(p => (!string.IsNullOrEmpty(categoryName)) ? p.Category.Name == categoryName : true).OrderByDescending(p => p.Price),
                SortPieState.WeightAsc => pies.Where(p => (!string.IsNullOrEmpty(categoryName)) ? p.Category.Name == categoryName : true).OrderBy(p => p.Weight),
                SortPieState.WeightDes => pies.Where(p => (!string.IsNullOrEmpty(categoryName)) ? p.Category.Name == categoryName : true).OrderByDescending(p => p.Weight),
                _ => pies.Where(p => (!string.IsNullOrEmpty(categoryName)) ? p.Category.Name == categoryName : true).OrderBy(p => p.Name),
            };

            string currentCategory = string.IsNullOrEmpty(categoryName) ? "All pies" : categoryName;

            var model = new PiesListViewModel
            {
                Pies = await pies.AsNoTracking().ToListAsync(),
                CurrentCategoryName = currentCategory,
                SortPieViewModel = new SortPieViewModel(sortState)
            };
           
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
