namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    {
    }
}
