using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine is running."); 
        }
    }
}
