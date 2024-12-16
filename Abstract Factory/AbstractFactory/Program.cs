using AbstractFactory.Factories;
using AbstractFactory.Models;
using AbstractFactory.Services;

var newCar = new NewCar("Mercedes Crossover", "ML450", new MercedesEngine());
var oldCar = new OldCar("Toyota Crossover", "RAV 4", new ToyotaEngine());

var roadService = new RoadService();
roadService.PlaceCarToRoad(oldCar, new OldHighway());
roadService.PlaceCarToRoad(newCar, new OldHighway());







