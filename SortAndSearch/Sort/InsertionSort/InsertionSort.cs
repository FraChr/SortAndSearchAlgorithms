namespace SortAndSearch.Sort.InsertionSort;

public class InsertionSort : ISortAlgorithm
{
    public void Sort(IList<int> data)
    {
        for (var i = 1; i < data.Count; i++)
        {
            var key = data[i];
            var j = i - 1;
            while (j >= 0 && data[j] > key)
            {
                data[j + 1] = data[j];
                j = j - 1;
            }
            data[j + 1] = key;
        }
    }
}