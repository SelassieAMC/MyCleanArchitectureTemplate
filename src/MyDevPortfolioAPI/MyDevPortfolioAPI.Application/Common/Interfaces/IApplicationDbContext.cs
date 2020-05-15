using MyDevPortfolioAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IApplicationDbContext 
    {
         DbSet<Person> People { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
