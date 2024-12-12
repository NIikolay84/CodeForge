using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Crossover : Car
    {
        public Crossover(string brand, string model, IEngine engine) : base(brand, model, engine) { }
    }
}
