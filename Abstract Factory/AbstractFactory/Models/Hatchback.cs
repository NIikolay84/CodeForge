using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Hatchback : Car
    {
        public Hatchback(string brand, string model, IEngine engine) : base(brand, model, engine) { }
    }
}
