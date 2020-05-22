using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MyDevPortfolioAPI.Application.Common.Interfaces;
using MyDevPortfolioAPI.Application.Common.Services;
using MyDevPortfolioAPI.Application.Person.Commands;
using System.Reflection;
using static MyDevPortfolioAPI.Application.Person.Commands.AddBasicPersonalInfoCommand;

namespace MyDevPortfolioAPI.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<MessageService>();
            AddHandlers(services);
        }

        
        public static void AddHandlers(IServiceCollection services)
        {
            services.TryAddTransient<ICommandHandler<AddBasicPersonalInfoCommand>,AddBasicPersonalInfoCommandHandler>();
        }

        
    }
}
