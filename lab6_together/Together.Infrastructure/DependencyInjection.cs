using Microsoft.Extensions.DependencyInjection;
using Together.Application.Common.Interfaces;
using Together.Infrastructure.Persistence;

namespace Together.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services) {

        services.AddScoped<IEventRepository, EventMemRepository>();
        return services;
    }
}