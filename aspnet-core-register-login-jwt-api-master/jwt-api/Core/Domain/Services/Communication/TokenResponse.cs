using jwt_api.Core.Domain.Services.Communication;
using jwt_api.Core.Security.Token;

namespace jwt_api.Core.Domain.Services.Communication
{
    public class TokenResponse : BaseResponse
    {
        public AccessToken Token { get; set; }

        public TokenResponse(bool success, string message, AccessToken token) : base(success, message)
        {
            Token = token;
        }
    }
}