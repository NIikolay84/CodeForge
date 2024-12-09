using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    public class Crossover : IBody
    {
        public void Display()
        {
            Console.WriteLine("This is crossover.");
        }
    }
}
