using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Builders
{
    public class CarParkBuilder : ICarParkBuilder
    {
        private readonly ICarFactory _carFactory;
        private List<Car> _cars = [];

        public CarParkBuilder(ICarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public ICarParkBuilder AddCrossovers(int count)
        {
            AddCars(count, _carFactory.CreateCrossover);
            return this;
        }

        public ICarParkBuilder AddHatchbacks(int count)
        {
            AddCars(count, _carFactory.CreateHatchbak);
            return this;
        }

        public ICarParkBuilder AddSedans(int count)
        {
            AddCars(count, _carFactory.CreateSedan);
            return this;
        }

        public List<Car> Build()
        {
            var result = _cars;
            _cars = new List<Car>();
            return result;
        }

        private void AddCars(int count, Func<Car> createCar)
        {
            for (int i = 0; i < count; i++)
                _cars.Add(createCar());
        }

    }
}
