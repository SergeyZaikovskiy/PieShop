using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.ViewModels
{
    public class PiesListViewModel
    {
        public List<Pie> Pies { get; set; }

        public string CurrentCategoryName { get; set; }

        public SortPieViewModel SortPieViewModel { get; set; }
    }
}
