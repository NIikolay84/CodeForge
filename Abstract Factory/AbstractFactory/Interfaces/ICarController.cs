using AbstractFactory.Models;

namespace AbstractFactory.Interfaces
{
    public interface ICarController
    {
        bool CanPlaceCarOnRoad(Car car);
    }
}
