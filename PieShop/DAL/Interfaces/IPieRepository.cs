using PieShop.Models;
using System.Linq;

namespace PieShop.DAL.Interfaces
{
    public interface IPieRepository
    {
        IQueryable<Pie> GetAllPies();

        Pie GetPieById(int id);
        
        Pie GetPieByName(string name);
    }
}
