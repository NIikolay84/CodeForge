using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Controllers
{
    public class CarController : ICarController
    {
        public bool CanPlaceCarOnRoad(Car car)
        {
            return car is not Sedan;
        }
    }
}
