namespace WildFarm.Models;

public class Hen : Bird
{
    private const double WeightModifier = 0.35;
    public Hen(string name, double weight, double wingSize) 
        : base(name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Cluck";
    }
    public override void EatFood(string foodType, int foodQuantity)
    {
        Weight += foodQuantity * WeightModifier;
        FoodEaten = foodQuantity;
    }
}
