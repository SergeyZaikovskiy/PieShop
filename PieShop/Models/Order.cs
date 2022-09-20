using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }

        [Required(ErrorMessage = "First name is required"), StringLength(50, MinimumLength = 3)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required"), StringLength(50, MinimumLength = 3)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required"), StringLength(50, MinimumLength = 5)]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; }
      
        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "ZipCode is required"), StringLength(6, MinimumLength = 6)]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "State is required"), StringLength(50, MinimumLength = 5)]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Country is required"), StringLength(50, MinimumLength = 2)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage ="Email is required"), DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Phone number is required"), DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public decimal OrderTotal { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime OrderTime { get; set; }
    }
}
