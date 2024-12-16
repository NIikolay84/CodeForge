using AbstractFactory.Adapters;
using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Services;

public class RoadService : IRoadService
{
    public void PlaceCarToRoad(Car car, Highway road)
    {
        if (road is OldHighway && car is NewCar newCar)
        {
            var adaptedCar = new NewCarAdapter(newCar);
            road.PlaceCarToDrive(adaptedCar);
        }
        else
        {
            road.PlaceCarToDrive(car);
        }
    }
}