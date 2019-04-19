using System.Threading.Tasks;
using jwt_api.Core.Domain.Models;

namespace jwt_api.Core.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] role);
        Task<User> FindByEmailAsync(string email);
    }
}