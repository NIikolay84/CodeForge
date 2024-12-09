using AbstractFactory.Factories;
using AbstractFactory.Models;


var car1 = new Car(new CarFactory(new CrossoverBodyFactory(),new DieselEngineFactory()));
car1.Body.Display();
car1.Engine.Start();

Console.WriteLine("");

var car2 = new Car(new CarFactory(new SedanBodyFactory(), new ElectricEngineFactory()));
car2.Body.Display();
car2.Engine.Start();




