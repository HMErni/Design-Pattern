using AbstractFactory.Interfaces;

namespace AbstractFactory.Model;

public class IndustrialCar : IIndustrialCar
{

    public string CarType { get; init; } = string.Empty;
    public string Color { get; init; } = string.Empty;
    public double Price { get; init; }

    public void Describe()
    {
        Console.WriteLine($"The {CarType} is an industrial car. It's a {Color} car and costs {Price} dollars.");
    }

    public void DoSomethingIndustrial()
    {
        Console.WriteLine($"The {CarType} is doing something industrial...");
    }

    public void Start()
    {
        Console.WriteLine($"The {CarType} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"The {CarType} is stopping...");
    }

    public override string ToString()
    {
        return $"Car Type: {CarType}, Color: {Color}, Price: {Price}";
    }
}