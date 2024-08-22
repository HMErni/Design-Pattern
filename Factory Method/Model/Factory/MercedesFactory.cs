using FactoryMethod.Interfaces;

namespace FactoryMethod.Model.Factory;

class MercedesFactory : CarFactory
{
    public override ICar CreateCar(string model, string color)
    {
        return new Mercedes()
        {
            _model = model,
            _color = color
        };
    }
}