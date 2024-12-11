using AbstractFactory.Builders;
using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class CarParkFactory : ICarParkFactory
    {
        private ICarFactory _carFactory;

        public CarParkFactory(ICarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public CarPark CreateCarPark(string name, Action<ICarParkBuilder> conf)
        {
            var builder = new CarParkBuilder(_carFactory);
            conf(builder);
            var cars = builder.Build();

            return new CarPark(name, cars);
        }
    }
}
