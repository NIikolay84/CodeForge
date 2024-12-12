using AbstractFactory.Factories;

var toyotaFactory = new ToyotaFactory();
var toyotaParkFactory = new CarParkFactory(toyotaFactory);
var toyotaPark = toyotaParkFactory.CreateCarPark("Toyota park", builder =>
{
    builder.AddSedans(2);
    builder.AddCrossovers(6);
});

Console.WriteLine(toyotaPark.ToString());

var mercedesFactory = new MercedesFactory();
var mercedesParkFactory = new CarParkFactory(mercedesFactory);
var mercedesPark = mercedesParkFactory.CreateCarPark("Mercedes park", builder =>
{
    builder.AddSedans(1);
    builder.AddCrossovers(2);
    builder.AddHatchbacks(1);
    builder.AddCrossovers(6);
});

Console.WriteLine(mercedesPark.ToString());








