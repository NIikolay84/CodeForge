using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class ClassicCar : Car
    {
        public ClassicCar(string brand, string model, IEngine engine) : base(brand, model, engine) { }

        public override CarGeneration CarGeneration => CarGeneration.Classic;
    }
}
