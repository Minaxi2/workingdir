using System.Threading.Tasks;
using jwt_api.Core.Domain.Models;
using jwt_api.Core.Domain.Services.Communication;

namespace jwt_api.Core.Domain.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);

    }
}