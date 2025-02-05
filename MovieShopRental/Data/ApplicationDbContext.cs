using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieShopRental.Models;

namespace MovieShopRental.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

 
        public DbSet<Movies> Movie { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Rentals> Rental { get; set; }
        public DbSet<RentalDetails> RentalDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One Customer → Many Rentals
            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Rental) 
                .HasForeignKey(r => r.CustomerId);

            // One Movie → Many Rentals
            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Rental) 
                .HasForeignKey(r => r.MovieId);

            // One Rental → Many RentalDetails
            modelBuilder.Entity<RentalDetails>()
                .HasOne(rd => rd.Rental)
                .WithMany(r => r.RentalDetail) 
                .HasForeignKey(rd => rd.RentalId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
