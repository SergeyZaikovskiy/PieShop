namespace PieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }

        public string Name { get; set; }      

        public string ShortFescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price{ get; set; }

        public string ImageURL { get; set; }

        public string ImageThumbnailURL { get; set; }

        public bool IsPieOfTheweek { get; set; }

        // public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
