using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.DAL.Interfaces
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; } 

        Pie GetPieById(int id);

        public IEnumerable<Pie> GetPiesByName(string name);
    }
}
