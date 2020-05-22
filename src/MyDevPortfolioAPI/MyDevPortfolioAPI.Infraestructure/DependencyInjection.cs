using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Application.Person.Commands;
using MyDevPortfolioAPI.Core.Entities;
using MyDevPortfolioAPI.Infraestructure.Services;
using MyDevPortfolioAPI.Infrastructure.Persistence;
using static MyDevPortfolioAPI.Application.Person.Commands.AddBasicPersonalInfoCommand;

namespace MyDevPortfolioAPI.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            AddServices(services);
            AddRepositories(services);
            //AddHandlers(services);

            return services;
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddTransient<IDateTime, DateTimeService>();
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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPersonRepository, PersonRepository>();
        }
    }
}