using System.Diagnostics;

namespace SortAndSearch.Timer;

public class SortTimer : ISortTimer
{
    private readonly Stopwatch _stopwatch = new();
    public TimeSpan Elapsed => _stopwatch.Elapsed;
    public void StartTimer() => _stopwatch.Restart();
    public void StopTimer() => _stopwatch.Stop();

}