using AbstractFactory.Interfaces;
using AbstractFactory.Models;

namespace AbstractFactory.Adapters;

public class NewCarAdapter : OldCar
{
    public NewCarAdapter(NewCar newCar) : base(newCar.Brand, newCar.Model, newCar.Engine)
    {
    }

    public override CarGeneration CarGeneration => CarGeneration.Old;
}