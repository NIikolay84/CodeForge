using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class SedanBodyFactory : IBodyFactory
    {
        public IBody CreateBody() => new Sedan();
    }
}
