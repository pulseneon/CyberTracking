using CyberTracking.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CyberTracking.EntityFramework
{
    public class TrackingDbContext : DbContext
    {
        public TrackingDbContext(DbContextOptions<TrackingDbContext> options)
            : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
    }
}
