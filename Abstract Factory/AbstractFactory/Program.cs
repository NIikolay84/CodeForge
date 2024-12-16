using AbstractFactory.Adapters;
using AbstractFactory.Factories;
using AbstractFactory.Models;
using AbstractFactory.Services;

var newCar = new NewCar("Mercedes Crossover", "ML450", new MercedesEngine());
var oldCar = new OldCar("Toyota Crossover", "RAV 4", new ToyotaEngine());
var classicCar = new ClassicCar("Mercedes Sedan", "W211", new MercedesEngine());

var roadService = new RoadService();
var carAdapterFactory = new CarAdapterFactory();
var adaptedRoadService = new RoadServiceAdapter(roadService, carAdapterFactory);

adaptedRoadService.PlaceCarToRoad(newCar, new OldHighway());
adaptedRoadService.PlaceCarToRoad(classicCar, new OldHighway());






