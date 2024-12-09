using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class MercedesFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new Car ("Mercedes", "W211", new MercedesEngine());
        }
    }
}
