using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class MercedesEngine : IEngine
    {
        public string GetEngine() => "OM646";
    }
}
