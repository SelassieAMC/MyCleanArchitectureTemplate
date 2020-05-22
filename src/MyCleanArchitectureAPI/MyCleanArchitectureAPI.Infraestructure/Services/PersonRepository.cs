using Microsoft.EntityFrameworkCore;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Core.Entities;
using MyDevPortfolioAPI.Infrastructure.Persistence;
using System;

namespace MyDevPortfolioAPI.Infraestructure.Services
{
    public sealed class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        private readonly DbSet<Person> _people;

        public PersonRepository(IApplicationDbContext context) :base((ApplicationDbContext)context)
        {
            _people = context.People;
        }

        public Person GetById(Guid id)
        {
            return _people.Find(id);
        }

        public void CreatePerson(Person person)
        {
            _people.Add(person);
        }

        public void AddPersonalInfo(Person person)
        {
            _people.Update(person);
        }
    }
}
