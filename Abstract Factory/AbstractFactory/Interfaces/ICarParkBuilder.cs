using AbstractFactory.Models;

namespace AbstractFactory.Interfaces
{
    public interface ICarParkBuilder
    {
        ICarParkBuilder AddSedans(int count);
        ICarParkBuilder AddCrossovers(int count);
        ICarParkBuilder AddHatchbacks(int count);
        List<Car> Build();
    }
}
