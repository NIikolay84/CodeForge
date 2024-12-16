using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public IEngine Engine { get; }
        public virtual CarGeneration CarGeneration => CarGeneration.Default;

        public Car(string brand, string model, IEngine engine)
        {
            Brand = brand;
            Model = model;
            Engine = engine;
        }

        public void Drive()
        {
            Console.WriteLine($"Wroom-wroom, I am {this.GetType().Name}: {Brand}: {Model}");
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Engine: {Engine.GetEngine()}";
        }
    }

    public enum CarGeneration
    {
        Default = 0,
        New = 1,
        Old = 2,
        Classic = 3,
    }

}
