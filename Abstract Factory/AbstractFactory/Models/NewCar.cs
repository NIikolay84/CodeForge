using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class NewCar : Car
    {
        public override CarGeneration CarGeneration => CarGeneration.New;

        public NewCar(string brand, string model, IEngine engine) : base(brand, model, engine) { }
    }
}
