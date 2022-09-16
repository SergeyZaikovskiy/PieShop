using System.ComponentModel.DataAnnotations.Schema;

namespace PieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }

        public string Name { get; set; }      

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string AllergyInfo { get; set; }

        public decimal Price{ get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public bool IsPieOfTheWeek { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string Notes { get; set; }
    }
}
