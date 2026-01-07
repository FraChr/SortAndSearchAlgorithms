using SortAndSearch.Data;
using SortAndSearch.Timer;

namespace SortAndSearch;

public class App
{
    private readonly IEnumerable<ISortAlgorithm> _sortAlgorithms;
    private readonly ISortTimer _timer;
    private readonly GenerateList _generateList;

    public App(IEnumerable<ISortAlgorithm> sortAlgorithms, ISortTimer timer, GenerateList generateList)
    {
        _sortAlgorithms = sortAlgorithms;
        _timer = timer;
        _generateList = generateList;
    }

    public void Run()
    {
        var data = _generateList.Generate();
        
        foreach (var sort in _sortAlgorithms)
        {
            var copy = new List<int>(data);
            _timer.StartTimer();
            sort.Sort(copy);
            _timer.StopTimer();
            Console.WriteLine($"{sort.GetType().Name} sorted in {_timer.Elapsed.Microseconds} Microseconds");
        }
    }
}