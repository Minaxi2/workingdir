using System.Threading.Tasks;

namespace jwt_api.Core.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}