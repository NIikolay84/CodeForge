using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public IEngine Engine { get; }

        public Car(string brand, string model, IEngine engine)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
        }
    }
}
