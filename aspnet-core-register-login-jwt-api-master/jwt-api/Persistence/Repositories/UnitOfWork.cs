using System.Threading.Tasks;
using jwt_api.Core.Domain.Repositories;
using jwt_api.Persistence.Context;

namespace jwt_api.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task CompleteAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}