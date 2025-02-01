using AmericaWalksApi.Models.Domain;

namespace AmericaWalksApi.Repositories
{
    public interface ILocationRepository
    {
        Task<List<Location>> GetAllAsync();

        Task<Location?> GetByIdAsync(Guid id);

        Task<Location> CreateAsync(Location location);

        Task<Location?> UpdateAsync(Guid id,Location location);

        Task<Location?> DeleteAsync(Guid id);
    }
}
