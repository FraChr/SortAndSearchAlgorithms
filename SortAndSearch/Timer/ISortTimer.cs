namespace SortAndSearch.Timer;

public interface ISortTimer
{
    TimeSpan Elapsed { get; }
    void StartTimer();
    void StopTimer();
    public string ShowTime();
}