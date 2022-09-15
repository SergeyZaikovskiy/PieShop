using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Pie> Pies{ get; set; }
        
        public DbSet<Category> Categories{ get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // modelBuilder.
        //}
    }
}
