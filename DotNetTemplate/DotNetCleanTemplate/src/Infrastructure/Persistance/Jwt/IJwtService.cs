using DotNetCleanTemplate.Domain.Entities.Users;
using System.Threading.Tasks;

namespace DotNetCleanTemplate.Persistence.Jwt
{
    public interface IJwtService
    {
        Task<AccessToken> GenerateAsync(User user);
        int? ValidateJwtAccessTokenAsync(string token);
    }
}
