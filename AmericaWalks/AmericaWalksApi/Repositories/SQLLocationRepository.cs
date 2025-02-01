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


        public async Task<List<Location>> GetAllAsync()
        {
            return await dbContext.Locations.ToListAsync();
        }

        public async Task<Location?> GetById(Guid id)
        {
            return await dbContext.Locations.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
