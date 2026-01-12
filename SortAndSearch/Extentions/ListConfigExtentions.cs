using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Data;

namespace SortAndSearch.Extentions;

public static class ListConfigExtentions
{
    public static IServiceCollection AddListConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ListConfig>(configuration.GetSection("ListConfig"));
        return services;
    }

    public static IServiceCollection AddListServices(this IServiceCollection services)
    {
        services.AddSingleton<GenerateList>();
        return services;
    }
}