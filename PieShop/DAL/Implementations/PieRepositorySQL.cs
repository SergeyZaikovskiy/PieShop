using Microsoft.EntityFrameworkCore;
using PieShop.DAL.Interfaces;
using PieShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShop.DAL.Implementations
{
    public class PieRepositorySQL : IPieRepository
    {
        private readonly AppDbContext db;

        public PieRepositorySQL(AppDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return db.Pies.Include(c => c.Category);
        }

        public Pie GetPieById(int id)
        {
            return db.Pies.Find(id);
        }

        public IEnumerable<Pie> GetPiesByName(string name)
        {
            return db.Pies.Include(c => c.Category).Where( p => p.Name.StartsWith(name));
        }

        public IEnumerable<Pie> PiesOfTheWeek()
        {
            return db.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
        }

        public void Commit()
        {
            db.SaveChanges();
        }
    }
}
