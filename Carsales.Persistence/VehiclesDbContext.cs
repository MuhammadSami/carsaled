using Microsoft.EntityFrameworkCore;

namespace Carsales.Persistence
{
    public class VehiclesDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }


    }
}