using AmericaWalksApi.Models.Domain;

namespace AmericaWalksApi.Repositories
{
    public interface ILocationRepository
    {
        Task<List<Location>> GetAllAsync();

        Task<Location?> GetById(Guid id);
    }
}
