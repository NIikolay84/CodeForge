using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ToyotaFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new Car("Toyota", "Camry", new ToyotaEngine());
        }
    }
}
