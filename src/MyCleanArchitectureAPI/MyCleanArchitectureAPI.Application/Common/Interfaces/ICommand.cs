namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface ICommand
    {
    }

    public interface IQueryHandler<TQuery, out TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}
