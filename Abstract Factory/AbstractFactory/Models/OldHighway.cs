namespace AbstractFactory.Models
{
    public class OldHighway : Highway
    {
        public override void PlaceCarToDrive(Car car)
        {
            if(car.CarGeneration == CarGeneration.Old)
            {
                car.Drive();
            }
            else
            {
                throw new Exception("This car can't drive");
            }
        }
    }
}
