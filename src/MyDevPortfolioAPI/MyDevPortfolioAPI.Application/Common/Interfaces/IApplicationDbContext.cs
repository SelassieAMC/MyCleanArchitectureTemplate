using ENT=MyDevPortfolioAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IApplicationDbContext 
    {
        DbSet<ENT.Person> People { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
