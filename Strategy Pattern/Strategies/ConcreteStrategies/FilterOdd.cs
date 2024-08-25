using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies.ConcreteStrategies;

public class FilterOdd : IFilter<int>
{
    public IEnumerable<int> Filter(IEnumerable<int> input)
    {
        return input.Where(x => x % 2 != 0);
    }

    public override string ToString()
    {
        return "Odd Filter";
    }
}