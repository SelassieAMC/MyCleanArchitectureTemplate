using CSharpFunctionalExtensions;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IQuery<TResult>
    {
    }

    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}
