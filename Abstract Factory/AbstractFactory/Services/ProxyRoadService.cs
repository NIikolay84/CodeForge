using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Services
{
    public class ProxyRoadService : IRoadService
    {
        private readonly IRoadService _roadService;
        private readonly ICarController _carController;

        public ProxyRoadService(IRoadService roadService, ICarController carController)
        {
            _roadService = roadService;
            _carController = carController;
        }

        public void PlaceCarToRoad(Car car, Highway highway)
        {
            if (_carController.CanPlaceCarOnRoad(car))
            {
                _roadService.PlaceCarToRoad(car, highway);
            }
            else
            {
                Console.WriteLine("Forbidden");
            }
        }
    }
}
