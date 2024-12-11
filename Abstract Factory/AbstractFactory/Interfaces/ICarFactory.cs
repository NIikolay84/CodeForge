using AbstractFactory.Models;

namespace AbstractFactory.Interfaces
{
    public interface ICarFactory
    {
        Car CreateSedan();
        Car CreateCrossover();
        Car CreateHatchbak();
    }
}
