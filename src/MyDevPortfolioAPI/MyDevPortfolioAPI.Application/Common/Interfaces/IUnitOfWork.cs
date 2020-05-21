using System.Threading.Tasks;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
