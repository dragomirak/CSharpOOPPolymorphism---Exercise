namespace WildFarm.Models;

public abstract class Animal : ISound
{
    protected Animal(string name, double weight)
    {
        Name = name;
        Weight = weight;
        
    }

    public string Name { get; set; }
    public double Weight { get; set; }
    public int FoodEaten { get; set; }

    public abstract string ProduceSound();
    public abstract void EatFood(string foodType, int foodQuantity);
    
        
    
}
