using FactoryMethod.Interfaces;

namespace FactoryMethod.Model.Factory;

class FerrariFactory : CarFactory
{
    public override ICar CreateCar(string model, string color)
    {
        return new Ferrari()
        {
            _model = model,
            _color = color
        };
    }
}