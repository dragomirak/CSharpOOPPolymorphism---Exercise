namespace WildFarm.Models;

public class Mouse : Mammal
{
    private const double WeightModifier = 0.10;
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Squeak";
    }
    public override void EatFood(string foodType, int foodQuantity)
    {
        if ((foodType != "Vegetable") && (foodType != "Fruit"))
        {
            throw new ArgumentException($"{GetType().Name} does not eat {foodType}!");
        }

        Weight += foodQuantity * WeightModifier;
        FoodEaten = foodQuantity;
    }


}
