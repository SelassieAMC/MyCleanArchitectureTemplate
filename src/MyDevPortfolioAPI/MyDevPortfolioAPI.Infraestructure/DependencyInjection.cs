using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Core.Entities;
using MyDevPortfolioAPI.Infraestructure.Services;
using MyDevPortfolioAPI.Infrastructure.Persistence;

namespace MyDevPortfolioAPI.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddServices(services);
            AddRepositories(services);

            return services;
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<MessageService>();
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlServer(
                                configuration.GetConnectionString("DefaultConnection"),
                                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IRepository<Person>, PersonRepository>();
        }
    }
}