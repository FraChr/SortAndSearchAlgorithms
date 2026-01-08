namespace SortAndSearch.Sort.BubbleSort;

public class BubbleSort : ISortAlgorithm
{

public void Sort(List<int> data)
    {
        var n = data.Count;
        
        int i, j;
        bool swapped;
        for (i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (j = 0; j < n - i - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    (data[j], data[j + 1]) = (data[j + 1], data[j]);
                    swapped = true;
                }
            }
            
            if (swapped == false) break;
        }
    }
}