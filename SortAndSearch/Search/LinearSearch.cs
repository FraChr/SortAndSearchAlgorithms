using System.Globalization;

namespace SortAndSearch.Search;

public class LinearSearch : ISearchAlgorithm
{
    public bool Search(IList<int> data, int target)
    {
        for (int i = 0; i < data.Count; i++)
        {
            if (data[i] == target) 
                return true;
        }
        return false;
    }
}