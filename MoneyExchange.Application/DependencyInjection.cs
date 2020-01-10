using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MoneyExchange.Application.Common.Behaviors;
using System.Reflection;

namespace MoneyExchange.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;

        }

    }
}
