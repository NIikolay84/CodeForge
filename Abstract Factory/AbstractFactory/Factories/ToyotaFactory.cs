using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ToyotaFactory : ICarFactory
    {
        public Car CreateCrossover()
            => new("Toyota Crossover", "RAV 4", new ToyotaEngine());

        public Car CreateHatchbak()
            => new("Toyota Hatchbak", "Corola", new ToyotaEngine());

        public Car CreateSedan()
            => new("Toyota Sedan", "Camry", new ToyotaEngine());
    }
}
