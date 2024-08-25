using StrategyPattern.Strategies.Interfaces;

namespace StrategyPattern.Strategies.ConcreteStrategies;

public class FilterEven : IFilter<int>
{
    public IEnumerable<int> Filter(IEnumerable<int> input)
    {
        return input.Where(x => x % 2 == 0 && x != 0);
    }

    public override string ToString()
    {
        return "Even Filter";
    }
}