using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Timer;

namespace SortAndSearch.Extentions;

public static class TimerExtentions
{
    public static IServiceCollection AddTiming(this IServiceCollection services)
    {
        services.AddSingleton<ISortTimer, SortTimer>();
        return services;
    }
}