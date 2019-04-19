using jwt_api.Core.Domain.Models;

namespace jwt_api.Core.Domain.Services.Communication
{
    public class CreateUserResponse : BaseResponse
    {
        public User User { get; set; }

        public CreateUserResponse(bool success, string message, User user) : base(success, message)
        {
            User = user;
        }
    }
}