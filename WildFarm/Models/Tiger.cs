namespace WildFarm.Models;

public class Tiger : Feline
{
    private const double WeightModifier = 1.00;
    public Tiger(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
    {
    }
    public override string ProduceSound()
    {
        return "ROAR!!!";
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
