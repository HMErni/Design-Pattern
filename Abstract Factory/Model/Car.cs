using AbstractFactory.Interfaces;

namespace AbstractFactory.Model;

public class Car : ICar
{
    public string CarType { get; init; } = string.Empty;
    public string Color { get; init; } = string.Empty;
    public double Price { get; init; }

    public void Describe()
    {
        Console.WriteLine($"The {CarType} is an ordinary car. It's a {Color} car and costs {Price} dollars.");
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