using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Adapters;

public class NewCarAdapter : ICarAdapter
{
    public Car Adapt(Car car)
    {
        return new OldCar(car.Brand, car.Model, car.Engine);
    }
}