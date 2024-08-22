namespace AbstractFactory.Interfaces;

public interface IIndustrialCarFactory
{
    public IIndustrialCar CreateIndustrialCar(string carType, string color, double price);
}