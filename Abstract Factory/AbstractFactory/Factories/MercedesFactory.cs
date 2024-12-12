using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class MercedesFactory : ICarFactory
    {
        public Crossover CreateCrossover()
            => new ("Mercedes Crossover", "ML450", new MercedesEngine());

        public Hatchback CreateHatchbak()
            => new("Mercedes Hatchbak", "A130", new MercedesEngine());

        public Sedan CreateSedan()
            => new("Merceds Sedan", "E500", new MercedesEngine());
    }
}
