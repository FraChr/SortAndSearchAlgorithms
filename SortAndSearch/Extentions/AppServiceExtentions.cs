using Microsoft.Extensions.DependencyInjection;

namespace SortAndSearch.Extentions;

public static class AppServiceExtentions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddSingleton<App>();
        return services;
    }
}