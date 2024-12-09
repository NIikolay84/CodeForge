using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class ElectricEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine() => new ElectricEngine();
    }
}
