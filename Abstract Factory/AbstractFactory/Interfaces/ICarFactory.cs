using AbstractFactory.Models;

namespace AbstractFactory.Interfaces
{
    public interface ICarFactory
    {
        Sedan CreateSedan();
        Crossover CreateCrossover();
        Hatchback CreateHatchbak();
    }
}
