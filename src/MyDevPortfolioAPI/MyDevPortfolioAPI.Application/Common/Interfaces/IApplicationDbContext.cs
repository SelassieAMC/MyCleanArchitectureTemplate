using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using ENT = MyDevPortfolioAPI.Core.Entities;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<ENT.Person> People { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
