namespace SortAndSearch.Search;

public interface ISearchAlgorithm
{ 
    bool Search(IList<int> data, int target);
}