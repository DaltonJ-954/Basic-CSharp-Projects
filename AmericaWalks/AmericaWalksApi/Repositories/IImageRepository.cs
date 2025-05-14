using AmericaWalksApi.Models.Domain;

namespace AmericaWalksApi.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
