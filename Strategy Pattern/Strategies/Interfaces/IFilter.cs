namespace StrategyPattern.Strategies.Interfaces;

public interface IFilter<T>
{

    public IEnumerable<T> Filter(IEnumerable<T> input);

}