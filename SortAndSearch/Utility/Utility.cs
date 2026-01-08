namespace SortAndSearch.Utility;

public static class Utility
{
    public static bool IsSorted(List<int> data)
    {
        for (int i = 1; i < data.Count; i++)
            if (data[i] < data[i - 1])
                return false;
        
        return true;
    }
}