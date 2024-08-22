namespace AbstractFactory.Interfaces;

public interface ICarFactory
{
    public ICar CreateCar(string carType, string color, double price);

    public ISuperCar CreateSuperCar(string carType, string color, double price);

}