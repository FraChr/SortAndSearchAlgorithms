using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Data;
using SortAndSearch.Sort.BubbleSort;
using SortAndSearch.Timer;

namespace SortAndSearch;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddSingleton(new ListConfig { Size = 50, MinValue = 1, MaxValue = 1000 });
        services.AddSingleton<GenerateList>();
        services.AddSingleton<ISortAlgorithm, BubbleSort>();
        services.AddSingleton<ISortTimer, SortTimer>();
        services.AddSingleton<App>();
        
        using var provider = services.BuildServiceProvider();
        
        var app = provider.GetRequiredService<App>();
        
        app.Run();
    }
}