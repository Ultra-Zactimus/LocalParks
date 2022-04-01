using Microsoft.EntityFrameworkCore;

namespace LocalPark.Models
{
  public class LocalParkContext : DbContext
  {
    public LocalParkContext(DbContextOptions<LocalParkContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Rohner Park", City = "Fortuna", Trails = "Rohner Trail", Notes = "Park closes at 7pm" }
        );
    }

    public DbSet<Park> Parks { get; set; }
  }
}