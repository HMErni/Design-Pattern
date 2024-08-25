using StrategyPattern.Strategies.ConcreteStrategies;
using StrategyPattern.Strategies.Context;

namespace StrategyPattern;

public class Program
{
    public static void Main()
    {
        var filterContext = new FilterContext<int>();

        List<int> numbers = new List<int>() { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5, 0, 6, 0, 7, 0, 8, 0, 9, 0, 10 };

        filterContext.SetFilter(new FilterZeroes());
        filterContext.ExecuteFilter(numbers);

        filterContext.SetFilter(new FilterOdd());
        filterContext.ExecuteFilter(numbers);

        filterContext.SetFilter(new FilterEven());
        filterContext.ExecuteFilter(numbers);
    }
}