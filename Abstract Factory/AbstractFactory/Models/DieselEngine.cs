using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Diesle enging is running.");
        }
    }
}
