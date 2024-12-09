using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class CrossoverBodyFactory : IBodyFactory
    {
        public IBody CreateBody() => new Crossover();
    }
}
