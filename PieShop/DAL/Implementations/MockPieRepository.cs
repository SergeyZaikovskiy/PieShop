using PieShop.DAL.Interfaces;
using PieShop.Models;
using System.Linq;

namespace PieShop.DAL.Implementations
{
    public class MockPieRepository : IPieRepository
    {
        public IQueryable<Pie> GetAllPies()
        {
            throw new System.NotImplementedException();
        }

        public Pie GetPieById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Pie GetPieByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
