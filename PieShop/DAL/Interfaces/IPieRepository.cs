using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.DAL.Interfaces
{
    public interface IPieRepository
    {
        IQueryable<Pie> GetAllPies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; } 

        Pie GetPieById(int id);

        public IEnumerable<Pie> GetPiesByName(string name);
    }
}
