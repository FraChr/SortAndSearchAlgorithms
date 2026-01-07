namespace SortAndSearch.Timer;

public interface ISortTimer
{
    void StartTimer();
    void StopTimer();
    TimeSpan Elapsed { get; }
}