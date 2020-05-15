using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MyDevPortfolioAPI.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
