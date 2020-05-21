using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Infrastructure.Persistence;
using System.Threading.Tasks;

namespace MyDevPortfolioAPI.Infraestructure.Services
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(IApplicationDbContext context)
        {
            _context = (ApplicationDbContext)context;
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
