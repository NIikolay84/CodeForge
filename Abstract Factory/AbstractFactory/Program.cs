using AbstractFactory.Adapters;
using AbstractFactory.Controllers;
using AbstractFactory.Factories;
using AbstractFactory.Models;
using AbstractFactory.Services;

var crossover = new Crossover("Toyota Crossover", "RAV 4", new ToyotaEngine());
var sedan = new Sedan("Mercedes Sedan", "W211", new MercedesEngine());


var roadService = new RoadService();
var carController = new CarController();
var proxyRoadService = new ProxyRoadService(roadService, carController);

proxyRoadService.PlaceCarToRoad(crossover, new NewHighway());
proxyRoadService.PlaceCarToRoad(sedan, new NewHighway());








