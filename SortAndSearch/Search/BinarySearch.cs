namespace SortAndSearch.Search;

public class BinarySearch : ISearchAlgorithm
{
    public bool Search(IList<int> data, int target)
    {
        var low = 0;
        var high = data.Count - 1;
        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (data[mid] == target) return true;
            else if (data[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return false;
    }
}