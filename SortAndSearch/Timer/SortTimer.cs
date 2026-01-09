using System.Diagnostics;

namespace SortAndSearch.Timer;

public class SortTimer : ISortTimer
{
    private readonly Stopwatch _stopwatch = new();
    public TimeSpan Elapsed => _stopwatch.Elapsed;
    
    public void StartTimer() => _stopwatch.Restart();
    public void StopTimer() => _stopwatch.Stop();

    public string ShowTime()
    {
         return string.Format("{0:D2} Min {1:D2} S {2:D2} Ms {3:D2} Microseconds",
            _stopwatch.Elapsed.Minutes,
            _stopwatch.Elapsed.Seconds,
            _stopwatch.Elapsed.Milliseconds,
            _stopwatch.Elapsed.Microseconds);
    }

}