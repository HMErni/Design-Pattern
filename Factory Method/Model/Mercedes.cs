using FactoryMethod.Interfaces;

namespace FactoryMethod.Model;

public class Mercedes : ICar
{
    public string _model { get; init; } = string.Empty;
    public string _color { get; init; } = string.Empty;

    public void Describe()
    {
        Console.WriteLine($"The {_model} is a {_color} car.");
    }

    public void Start()
    {
        Console.WriteLine($"The {_model} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"The {_model} is starting...");
    }
}