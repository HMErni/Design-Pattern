using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies.ConcreteStrategies;

public class FilterZeroes : IFilter<int>
{
    public IEnumerable<int> Filter(IEnumerable<int> input)
    {
        return input.Where(x => x > 0);
    }

    public override string ToString()
    {
        return "Remove Zeroes Filter";
    }
}