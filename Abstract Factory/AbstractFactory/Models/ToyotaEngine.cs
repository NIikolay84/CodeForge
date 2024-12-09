using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class ToyotaEngine : IEngine
    {
        public string GetEngine() => "V6 engine";
    }
}
