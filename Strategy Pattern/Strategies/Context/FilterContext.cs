using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies.Context;

public class FilterContext<T>
{
    private IFilter<T> FilterStrat;

    public FilterContext()
    {
    }

    public FilterContext(IFilter<T> filterStrat)
    {
        FilterStrat = filterStrat;
    }

    public void SetFilter(IFilter<T> filterStrat)
    {
        FilterStrat = filterStrat;
    }

    public void ExecuteFilter(IEnumerable<T> input)
    {
        Console.WriteLine(FilterStrat);

        var filtered = FilterStrat.Filter(input);

        Console.Write("Filtered numbers:");
        foreach (var item in filtered)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
    }
}