using System.Runtime.InteropServices;
using Microsoft.Extensions.Options;

namespace SortAndSearch.Data;

public class GenerateList
{
    private readonly Random _random = new();
    private readonly ListConfig _config;

    public GenerateList(IOptions<ListConfig> config)
    {
        _config = config.Value;
    }

    /*public List<int> GenerateRandom()
    {
        var list = new List<int>(_config.Size);
        for (var i = 0; i < _config.Size; i++)
        {
            list.Add(_random.Next(_config.MinValue, _config.MaxValue + 1));
        }
        return list;
    }*/
    
    public int[] GenerateRandom()
    {
        var list = new int[_config.Size];
        
        for (var i = 0; i < _config.Size; i++)
        {
            list[i] = _random.Next(_config.MinValue, _config.MaxValue + 1);
        }
        return list;
    }

    public int[] GenerateLinear()
    {
        var size = _config.Size;
        var list = new int[size];

        Parallel.For(0, size, i =>
        {
            list[i] = i;
        });
        return list;
    }
    
    /*public int[] GenerateLinear()
    {
        var size = _config.Size;
        var list = new int[size];
        
        for (int i = 0; i < _config.Size; i++)
        {
            list[i] = i;
        }
        return list;
    }*/
    
    /*public List<int> GenerateLinear()
    {
        var size = _config.Size;
        var list = new List<int>(size);
        
        for (int i = 0; i < _config.Size; i++)
        {
            list.Add(i);
        }
        return list;
    }*/

    public int GetSearchTarget()
    {
        return _config.SearchTarget;
    }
}