using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class MercedesFactory : ICarFactory
    {
        public Car CreateCrossover()
            => new("Mercedes Crossover", "ML450", new MercedesEngine());

        public Car CreateHatchbak()
            => new("Mercedes Hatchbak", "A130", new MercedesEngine());

        public Car CreateSedan()
            => new("Merceds Sedan", "E500", new MercedesEngine());
    }
}
