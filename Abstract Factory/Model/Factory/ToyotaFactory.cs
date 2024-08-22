using AbstractFactory.Interfaces;

namespace AbstractFactory.Model.Factory;

public class ToyotaFactory : ICarFactory, IIndustrialCarFactory
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

    public IIndustrialCar CreateIndustrialCar(string carType, string color, double price)
    {
        return new IndustrialCar()
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