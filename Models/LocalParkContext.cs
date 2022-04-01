using Microsoft.EntityFrameworkCore;

namespace LocalPark.Models
{
    public class LocalParkContext : DbContext
    {
        public LocalParkContext(DbContextOptions<LocalParkContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 2, Name = "Test", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}