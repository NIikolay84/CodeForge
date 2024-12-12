using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class ToyotaFactory : ICarFactory
    {
        public Crossover CreateCrossover()
            => new("Toyota Crossover", "RAV 4", new ToyotaEngine());

        public Hatchback CreateHatchbak()
            => new("Toyota Hatchbak", "Corola", new ToyotaEngine());

        public Sedan CreateSedan()
            => new("Toyota Sedan", "Camry", new ToyotaEngine());
    }
}
