using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieShopRental.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        [Required]
        public string Director { get; set; }

        public ICollection<Rentals> Rental { get; set; }
    }
}
