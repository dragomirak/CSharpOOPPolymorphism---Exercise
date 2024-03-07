namespace WildFarm.Models;

public class Cat : Feline
{
    private const double WeightModifier = 0.30;
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }
    public override string ProduceSound()
    {
        return "Meow";
    }
    public override void EatFood(string foodType, int foodQuantity)
    {
        if ((foodType != "Vegetable") && (foodType != "Meat"))
        {
            throw new ArgumentException($"{GetType().Name} does not eat {foodType}!");
        }
        
        Weight += foodQuantity * WeightModifier;
        FoodEaten = foodQuantity;
    }
}
