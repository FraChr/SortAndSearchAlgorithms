namespace SortAndSearch.Sort.QuickSort;

public class QuickSort : ISortAlgorithm
{
    public void Sort(IList<int> data)
    {
        ArgumentNullException.ThrowIfNull(data);
        
        if(data.Count <= 1) return;
        
        var low = 0;
        var high = data.Count - 1;

        QSort(data, low, high);
    }

    private void QSort(IList<int> data, int low, int high)
    {
        if (low < high)
        {
            var pivotIndex = Partition(data, low, high);
            QSort(data, low, pivotIndex - 1);
            QSort(data, pivotIndex + 1, high);
        }
    }

    private int Partition(IList<int> data, int low, int high)
    {
        var pivot = data[high];
        var i = low - 1;
        for (var j = low; j <= high - 1; j++)
        {
            if (data[j] <= pivot)
            {
                i = i + 1;
                (data[i], data[j]) = (data[j], data[i]);
            }
        }
        (data[i + 1], data[high]) = (data[high], data[i + 1]);
        return i + 1;
    }
}