using FactoryMethod.Interfaces;
using FactoryMethod.Model;
using FactoryMethod.Model.Factory;

namespace FactoryMethod;

public class Program
{
    public static void Main()
    {
        CarFactory mercedesFactory = new MercedesFactory();
        CarFactory ferrariFactory = new FerrariFactory();

        ICar mercedes = mercedesFactory.CreateCar("S-Class", "Red");
        mercedes.Describe();
        mercedes.Start();
        mercedes.Stop();

        ICar ferrari = ferrariFactory.CreateCar("F-150", "Black");
        ferrari.Describe();
        ferrari.Start();
        ferrari.Stop();
    }
}