using Microsoft.EntityFrameworkCore;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Infrastructure.Persistence;
using System.Collections.Generic;

namespace MyDevPortfolioAPI.Infraestructure.Services
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        public BaseRepository(ApplicationDbContext context)
        {
            _entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities;
        }
    }
}
