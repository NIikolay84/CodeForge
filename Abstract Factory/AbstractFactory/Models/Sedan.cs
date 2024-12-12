using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Sedan : Car
    {
        public Sedan(string brand, string model, IEngine engine) : base(brand, model, engine) { }
    }
}
