using Microsoft.EntityFrameworkCore;
using ParkingSystem_API.Model;

namespace ParkingSystem_API.Data
{
    public class ParkingSystemDbContext : DbContext
    {
        public ParkingSystemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ParkingSummary> parkingSummaries { get; set; }
        public DbSet<ParkingDetails> parkingDetails { get; set; }
        public DbSet<VehicleDbModel> vehicleDbModels { get; set; }
    }
}
