using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieShopRental.Models
{
    public class Customers
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public ICollection<Rentals> Rental { get; set; }
    }
}
