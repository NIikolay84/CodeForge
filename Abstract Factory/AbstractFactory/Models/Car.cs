using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Car
    {
        public IBody Body { get; }
        public IEngine Engine { get; }

        public Car(ICarFactory factory)
            => (Body, Engine) = (factory.CreateBody(), factory.CreateEngine());
    }
}
