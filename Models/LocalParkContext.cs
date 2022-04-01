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
                  new Park { ParkId = 1, Name = "Test 1", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 2, Name = "Test 2", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 3, Name = "Test 3", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 4, Name = "Test 4", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 5, Name = "Test 5", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 6, Name = "Test 6", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 7, Name = "Test 7", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 8, Name = "Test 8", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 9, Name = "Test 9", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 10, Name = "Test 10", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" },
                  new Park { ParkId = 11, Name = "Test 11", City = "The Land of Test", Trails = "Test", Notes = "Test this api is working" }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}