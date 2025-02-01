using AmericaWalksApi.Data;
using AmericaWalksApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AmericaWalksApi.Repositories
{
    public class SQLLocationRepository : ILocationRepository
    {
        private readonly AmericaWalksDbContext dbContext;

        public SQLLocationRepository(AmericaWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Location> CreateAsync(Location location)
        {
            await dbContext.Locations.AddAsync(location);
            await dbContext.SaveChangesAsync();
            return location;
        }

        public async Task<Location?> DeleteAsync(Guid id)
        {
            var existingLocation = await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);

            if (existingLocation == null)
            {
                return null;
            }

            dbContext.Locations.Remove(existingLocation);
            await dbContext.SaveChangesAsync();
            return existingLocation;
        }

        public async Task<List<Location>> GetAllAsync()
        {
            return await dbContext.Locations.ToListAsync();
        }

        public async Task<Location?> GetByIdAsync(Guid id)
        {
            return await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Location?> UpdateAsync(Guid id, Location location)
        {
            var existingLocation = await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);

            if (existingLocation == null)
            {
                return null;
            }

            existingLocation.Code = location.Code;
            existingLocation.WalkLocation = location.WalkLocation;
            existingLocation.LocationImageUrl = location.LocationImageUrl;

            await dbContext.SaveChangesAsync();
            return existingLocation;
        }
    }
}
