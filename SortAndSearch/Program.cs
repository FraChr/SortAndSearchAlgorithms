using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Data;
using SortAndSearch.Sort.BubbleSort;
using SortAndSearch.Sort.QuickSort;
using SortAndSearch.Timer;

namespace SortAndSearch;

class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("config.json", optional: false)
            .Build();
        
        var services = new ServiceCollection();
        
        services.Configure<ListConfig>(configuration.GetSection("ListConfig"));
        
        services.AddSingleton<GenerateList>();
        services.AddSingleton<ISortAlgorithm, BubbleSort>();
        services.AddSingleton<ISortAlgorithm, QuickSort>();
        
        services.AddSingleton<ISortTimer, SortTimer>();
        services.AddSingleton<App>();
        
        using var provider = services.BuildServiceProvider();
        
        var app = provider.GetRequiredService<App>();
        
        app.Run();
    }
}