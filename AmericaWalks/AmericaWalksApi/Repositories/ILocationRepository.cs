using AmericaWalksApi.Models.Domain;

namespace AmericaWalksApi.Repositories
{
    // I created this ILocationRepository interface to establish definitions to any methods that I want to expose from the Location Domain
    public interface ILocationRepository
    {
        Task<List<Location>> GetAllAsync();

        Task<Location?> GetByIdAsync(Guid id);

        Task<Location> CreateAsync(Location location);

        Task<Location?> UpdateAsync(Guid id,Location location);

        Task<Location?> DeleteAsync(Guid id);
    }
}
