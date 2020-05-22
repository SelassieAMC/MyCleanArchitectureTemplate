using ENT = MyDevPortfolioAPI.Core.Entities;

namespace MyDevPortfolioAPI.Application.Common.Interfaces
{
    public interface IPersonRepository
    {
        void CreatePerson(ENT.Person person);

        void AddPersonalInfo(ENT.Person person);
    }
}
