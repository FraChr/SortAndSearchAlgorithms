using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SortAndSearch.Extentions;

namespace SortAndSearch;

class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("config.json", optional: false)
            .Build();
        
        var services = new ServiceCollection();

        services
            .AddListConfig(configuration)
            .AddListServices()
            .AddSorting()
            .AddSearch()
            .AddTiming()
            .AddAppServices();
        
        using var provider = services.BuildServiceProvider();
        
        var app = provider.GetRequiredService<App>();
        
        app.Run();
    }
}