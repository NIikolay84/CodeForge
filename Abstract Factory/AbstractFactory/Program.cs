using AbstractFactory.Factories;
using AbstractFactory.Models;

var newCar = new NewCar("Mercedes Crossover", "ML450", new MercedesEngine());
var oldCar = new OldCar("Toyota Crossover", "RAV 4", new ToyotaEngine());

var newWay = new NewHighway();
newWay.PlaceCarToDrive(oldCar);
newWay.PlaceCarToDrive(newCar);

var oldway = new OldHighway();
oldway.PlaceCarToDrive(oldCar);
oldway.PlaceCarToDrive(newCar);








