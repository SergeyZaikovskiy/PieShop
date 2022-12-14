using System.Collections.Generic;

namespace PieShop.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Pie> Pies { get; set; }
    }
}
