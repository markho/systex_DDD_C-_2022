using Microsoft.Extensions.DependencyInjection;

namespace Lab3;
public static class DependencyInjection {
    public static IServiceCollection Application(this IServiceCollection services) {
        return services;
    }
}