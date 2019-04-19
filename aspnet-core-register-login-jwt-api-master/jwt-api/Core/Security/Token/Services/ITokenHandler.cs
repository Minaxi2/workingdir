using jwt_api.Core.Domain.Models;

namespace jwt_api.Core.Security.Token.Services
{
    public interface ITokenHandler
    {
        AccessToken CreateAccessToken(User user);
        RefreshToken TakeRefreshToken(string token);
        void RevokeRefreshToken(string token);
    }
}