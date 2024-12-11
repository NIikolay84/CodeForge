namespace AbstractFactory.Models
{
    public class CarPark
    {
        public string Name { get; }
        public List<Car> Cars { get; }

        public CarPark(string name, List<Car> cars)
        {
            Name = name;
            Cars = cars;
        }

        public override string ToString()
        {
            return $"Park name: {Name}\n{string.Join("\n", Cars)}\n";
        }
    }
}
