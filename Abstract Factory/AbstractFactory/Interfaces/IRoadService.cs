using AbstractFactory.Models;

namespace AbstractFactory.Interfaces;

public interface IRoadService
{
    void PlaceCarToRoad(Car car, Highway highway);
}