using MovieShopRental.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopRental.Models
{
    public class Rentals
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateOnly RentalDate { get; set; }
        [Required]
        public bool IsPaid { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customers Customer { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movies Movie { get; set; }

        public ICollection<RentalDetails>? RentalDetail { get; set; }
    }
}