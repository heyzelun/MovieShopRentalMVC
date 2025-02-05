using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShopRental.Models
{
    public class RentalDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double RentalPrice { get; set; }
        [Required]
        public string RentalStatus { get; set; }
        public int RentalId { get; set; }
        [ForeignKey("RentalId")]
        public Rentals Rental { get; set; }
        
    }
}
