using SortAndSearch.Data;
using SortAndSearch.Search;
using SortAndSearch.Timer;
using static SortAndSearch.Utility.Utility;

namespace SortAndSearch;

public class App
{
    private readonly IEnumerable<ISortAlgorithm> _sortAlgorithms;
    private readonly IEnumerable<ISearchAlgorithm> _searchAlgorithm;
    private readonly ISortTimer _timer;
    private readonly GenerateList _generateList;

    public App(IEnumerable<ISortAlgorithm> sortAlgorithms, ISortTimer timer, GenerateList generateList, 
        IEnumerable<ISearchAlgorithm> searchAlgorithms)
    {
        _sortAlgorithms = sortAlgorithms;
        _searchAlgorithm = searchAlgorithms;
        _timer = timer;
        _generateList = generateList;
    }

    public void Run()
    {
        try
        {
            Console.WriteLine("==========================SORT===========================");
            RunSort();
            Console.WriteLine("==========================SEARCH=========================");
            RunSearch();
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"Error: {e.Message}");
            Environment.Exit(-1);
        }
    }
    
    private void RunSort()
    {
        _timer.StartTimer();
        var data = _generateList.GenerateRandom();
        _timer.StopTimer();

        Console.WriteLine($"time to generate collection = {_timer.ShowTime()}");
        
        foreach (var sort in _sortAlgorithms)
        {
            var copy = new List<int>(data);
            _timer.StartTimer();
            sort.Sort(copy);
            _timer.StopTimer();
                
            Console.WriteLine(IsSorted(copy)
                ? $"{sort.GetType().Name} sorted in {_timer.ShowTime()}"
                : $"{sort.GetType().Name} not sorted");
        }
    }

    private void RunSearch()
    {
        _timer.StartTimer();
        var data = _generateList.GenerateLinear();
        _timer.StopTimer();

        Console.WriteLine($"time to generate collection = {_timer.ShowTime()}");
        
        var target = _generateList.GetSearchTarget();
        foreach (var search in _searchAlgorithm)
        {
            _timer.StartTimer();
            var find = search.Search(data, target);
            /*var find = search.Search(data, 0);*/
            _timer.StopTimer();

            Console.WriteLine(find ? $"{search.GetType().Name} found match in {_timer.ShowTime()}" 
                : $"{search.GetType().Name} not found");
        }
    }
}