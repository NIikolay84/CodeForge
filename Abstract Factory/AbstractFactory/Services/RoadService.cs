using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Services;

public class RoadService : IRoadService
{
    public void PlaceCarToRoad(Car car, Highway road)
    {
       road.PlaceCarToDrive(car);
    }
}