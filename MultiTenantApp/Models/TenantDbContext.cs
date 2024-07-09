using Microsoft.EntityFrameworkCore;
using MultiTenantApp.Services;

namespace MultiTenantApp.Models
{
    public class TenantDbContext : DbContext    
    {
        private readonly ICurrentTenantService _currentTenantService;
        public string CurrentTenantId { get; set; }


        public TenantDbContext(DbContextOptions options, ICurrentTenantService currentTenantService) : base(options)
        {
            _currentTenantService = currentTenantService;
            CurrentTenantId = currentTenantService.TenantId;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Tenant> Tenants { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasQueryFilter(a => a.TenantId == CurrentTenantId);
        }


        // Every time something is saved
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<IMustHaveTenants>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                    case EntityState.Modified:
                        entry.Entity.TenantId = CurrentTenantId;
                        break;
                }
            }
            var result = base.SaveChanges();
            return result;
        }
    }
}
