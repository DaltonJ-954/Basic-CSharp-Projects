using AmericaWalksApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AmericaWalksApi.Data
{
    public class AmericaWalksDbContext : DbContext
    {
        public AmericaWalksDbContext(DbContextOptions<AmericaWalksDbContext> dbContectOptions) : base(dbContectOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy Moderate Hard
        }
    }
}