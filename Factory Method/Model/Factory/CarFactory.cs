using FactoryMethod.Interfaces;

namespace FactoryMethod.Model.Factory;

abstract class CarFactory
{
    public abstract ICar CreateCar(string model, string color);
}