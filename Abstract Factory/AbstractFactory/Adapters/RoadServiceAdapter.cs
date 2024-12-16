using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Adapters;

public class RoadServiceAdapter : IRoadService
{
    private readonly IRoadService _service;
    private readonly CarAdapterFactory _carAdapterFactory;
    
    public RoadServiceAdapter(IRoadService service, CarAdapterFactory carAdapterFactory)
    {
        _service = service;
        _carAdapterFactory = carAdapterFactory;
    }

    public void PlaceCarToRoad(Car car, Highway road)
    {
        var adaptedCar = _carAdapterFactory
            .GetAdapter(car)
            .Adapt(car);

        _service.PlaceCarToRoad(adaptedCar, road);
    }
}