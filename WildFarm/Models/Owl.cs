namespace WildFarm.Models;

public class Owl : Bird
{
    private const double WeightModifier = 0.25;
    public Owl(string name, double weight, double wingSize) 
        : base(name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Hoot Hoot";
    }
    public override void EatFood(string foodType, int foodQuantity)
    {
        if (foodType != "Meat")
        {
            throw new ArgumentException($"{GetType().Name} does not eat {foodType}!");
        }

        Weight += foodQuantity * WeightModifier;
        FoodEaten = foodQuantity;
    }
}
