using AmericaWalksApi.Data;
using AmericaWalksApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AmericaWalksApi.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly AmericaWalksDbContext dbContext;

        public SQLWalkRepository(AmericaWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public async Task<Walk?> DeleteAsync(Guid id)
        {
           var existingWalk = await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWalk == null)
            {
                return null;
            }

            dbContext.Walks.Remove(existingWalk);
            await dbContext.SaveChangesAsync();
            return existingWalk;
        }

        public async Task<List<Walk>> GetAllAsync(string? filterOn = null, string? filterQuery = null)
        {
            // Do more research regarding the Include() method
            // .Include(x => x.Difficulty) is type safe meaining, this avoids the lazy loading problem, where related data is fetched separately for each walk.
            // Instead of using a lambda function (x => x.Property), "Location" specifies the property name as a string. both give similar results

            //return await dbContext.Walks.Include("Difficulty").Include("Location").ToListAsync();

            var walks = dbContext.Walks.Include("Difficulty").Include("Location").AsQueryable();

            // Filtering
            if (string.IsNullOrWhiteSpace(filterOn) == false && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("Name", StringComparison.OrdinalIgnoreCase))
                {
                    walks = walks.Where(x => x.Name.Contains(filterQuery));
                }
            }


            return await walks.ToListAsync();
        }

        public async Task<Walk?> GetByIdAsync(Guid id)
        {
            return await dbContext.Walks
                .Include("Difficulty")
                .Include("Location")
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Walk?> UpdateAsync(Guid id, Walk walk)
        {
            var existingWalk = await dbContext.Walks.FirstOrDefaultAsync(x => x.Id == id);

            if (existingWalk == null)
            {
                return null;
            }


            existingWalk.Name = walk.Name;
            existingWalk.Description = walk.Description;
            existingWalk.LengthInMiles = walk.LengthInMiles;
            existingWalk.LocationImageUrl = walk.LocationImageUrl;
            existingWalk.DifficultyId = walk.DifficultyId;
            existingWalk.LocationId = walk.LocationId;

            await dbContext.SaveChangesAsync();

            return existingWalk;

        }
    }
}
