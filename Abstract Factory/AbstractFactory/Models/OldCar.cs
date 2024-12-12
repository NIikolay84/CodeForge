using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class OldCar : Car
    {
        public override CarGeneration CarGeneration => CarGeneration.Old;

        public OldCar(string brand, string model, IEngine engine) : base(brand, model, engine) { }
    }
}
