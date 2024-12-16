using AbstractFactory.Adapters;
using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class CarAdapterFactory
    {
        public ICarAdapter GetAdapter(Car car)
        {
            return car switch
            {
                NewCar _ => new NewCarAdapter(),
                ClassicCar _ => new ClassicCarAdapter(),
                _ => throw new InvalidOperationException("Unknown car type.")
            };
        }
    }
}
