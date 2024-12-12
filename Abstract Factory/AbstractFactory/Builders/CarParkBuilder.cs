using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Builders
{
    public class CarParkBuilder : ICarParkBuilder
    {
        private readonly ICarFactory _carFactory;
        private Dictionary<string, List<Car>> _cars = [];

        public CarParkBuilder(ICarFactory carFactory)
        {
            _carFactory = carFactory;
        }

        public ICarParkBuilder AddCrossovers(int count)
        {
            _cars["Crossovers"] = AddCars(count, _carFactory.CreateCrossover);
            return this;
        }

        public ICarParkBuilder AddHatchbacks(int count)
        {
            _cars["Hatchbacks"] = AddCars(count, _carFactory.CreateHatchbak);
            return this;
        }

        public ICarParkBuilder AddSedans(int count)
        {
            _cars["Sedans"] = AddCars(count, _carFactory.CreateSedan);
            return this;
        }

        public List<Car> Build()
        {
            var result = _cars.Values.SelectMany(cars => cars).ToList();
            _cars.Clear();
            return result;
        }

        private List<Car> AddCars(int count, Func<Car> createCar)
        {
            var cars = new List<Car>();
            for (int i = 0; i < count; i++)
                cars.Add(createCar());

            return cars;
        }
    }
}
