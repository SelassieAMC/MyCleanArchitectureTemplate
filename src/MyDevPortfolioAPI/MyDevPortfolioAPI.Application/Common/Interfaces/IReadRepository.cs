using System.Collections.Generic;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
    }
}
