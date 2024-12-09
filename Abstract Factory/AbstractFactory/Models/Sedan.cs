using AbstractFactory.Interfaces;

namespace AbstractFactory.Models
{
    internal class Sedan : IBody
    {
        public void Display()
        {
            Console.WriteLine("This is sedan.");
        }
    }
}
