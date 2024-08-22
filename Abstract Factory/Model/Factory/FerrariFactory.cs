using AbstractFactory.Interfaces;

namespace AbstractFactory.Model.Factory;

public class FerrariFactory : ICarFactory
{
    public ICar CreateCar(string carType, string color, double price)
    {
        return new Car()
        {
            CarType = carType,
            Color = color,
            Price = price
        };
    }

    public ISuperCar CreateSuperCar(string carType, string color, double price)
    {
        return new SuperCar()
        {
            CarType = carType,
            Color = color,
            Price = price
        };
    }
}