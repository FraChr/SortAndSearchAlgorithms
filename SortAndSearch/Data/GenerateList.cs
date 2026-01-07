namespace SortAndSearch.Data;

public class GenerateList
{
    private readonly Random _random = new Random();
    private readonly ListConfig _config;

    public GenerateList(ListConfig config)
    {
        _config = config;
    }

    public List<int> Generate()
    {
        var list = new List<int>(_config.Size);
        for (int i = 0; i < _config.Size; i++)
        {
            list.Add(_random.Next(_config.MinValue, _config.MaxValue + 1));
        }
        return list;
    }
}