using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class DieselEngineFactory : IEngineFactory
    {
        public IEngine CreateEngine() => new DieselEngine();
    }
}
