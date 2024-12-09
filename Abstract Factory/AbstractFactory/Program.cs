using AbstractFactory.Factories;

var mercedes = new MercedesFactory().CreateCar();
Console.WriteLine($"{mercedes.Brand}: {mercedes.Model}: {mercedes.Engine.GetEngine()}\n");

var toyota = new ToyotaFactory().CreateCar();
Console.WriteLine($"{toyota.Brand}: {toyota.Model}: {toyota.Engine.GetEngine()}\n");






