using AbstractFactory.Models;

namespace AbstractFactory.Interfaces
{
    public interface ICarParkFactory
    {
        CarPark CreateCarPark(string name, Action<ICarParkBuilder> conf);
    }
}
