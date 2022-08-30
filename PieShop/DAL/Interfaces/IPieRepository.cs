using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.DAL.Interfaces
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        IEnumerable<Pie> PiesOfTheWeek();  

        Pie GetPieById(int id);

        public IEnumerable<Pie> GetPiesByName(string name);
    }
}
