using AbstractFactory.Models;

namespace AbstractFactory.Interfaces
{
    public interface ICarAdapter
    {
        public Car Adapt(Car car);
    }
}
