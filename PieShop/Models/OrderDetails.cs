using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class OrderDetails
    {
        public int OrederDetailsId { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int PieId { get; set; }

        public Pie Pie { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }
    }
}
