using Microsoft.AspNetCore.Identity;

namespace AmericaWalksApi.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
