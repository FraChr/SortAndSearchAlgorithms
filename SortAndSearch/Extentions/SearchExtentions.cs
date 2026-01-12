using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Search;

namespace SortAndSearch.Extentions;

public static class SearchExtentions
{
    public static IServiceCollection AddSearch(this IServiceCollection services)
    {
        services.AddSingleton<ISearchAlgorithm, LinearSearch>();
        services.AddSingleton<ISearchAlgorithm, BinarySearch>();
        return services;
    }
}