namespace AbstractFactory.Models
{
    public class NewHighway : Highway
    {
        public override void PlaceCarToDrive(Car car)
        {
            car.Drive();
        }

    }
}
