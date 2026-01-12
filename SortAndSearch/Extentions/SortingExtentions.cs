using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Sort.BubbleSort;
using SortAndSearch.Sort.InsertionSort;
using SortAndSearch.Sort.QuickSort;

namespace SortAndSearch.Extentions;

public static class SortingExtentions
{
    public static IServiceCollection AddSorting(this IServiceCollection services)
    {
        services.AddSingleton<ISortAlgorithm, QuickSort>();
        services.AddSingleton<ISortAlgorithm, BubbleSort>();
        services.AddSingleton<ISortAlgorithm, InsertionSort>();
        return services;
    }
}