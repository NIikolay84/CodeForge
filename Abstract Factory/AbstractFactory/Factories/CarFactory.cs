using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    internal class CarFactory(IBodyFactory bodyFactory, IEngineFactory engineFactory) : ICarFactory
    {
        public IBody CreateBody() => bodyFactory.CreateBody();

        public IEngine CreateEngine() => engineFactory.CreateEngine();
    }
}
