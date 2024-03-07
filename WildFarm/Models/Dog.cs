namespace WildFarm.Models;

public class Dog : Mammal
{
    private const double WeightModifier = 0.40;
    public Dog(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
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
