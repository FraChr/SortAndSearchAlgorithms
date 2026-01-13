namespace SortAndSearch.Utility;

public static class Utility
{
    public static bool IsSorted(IList<int> data)
    {
        for (var i = 1; i < data.Count; i++)
            if (data[i] < data[i - 1])
                return false;
        
        return true;
    }
}