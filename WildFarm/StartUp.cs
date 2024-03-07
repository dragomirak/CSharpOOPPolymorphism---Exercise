using WildFarm.Models;

namespace WildFarm;

public class StartUp
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] animalTokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] foodTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string animalType = animalTokens[0];

            try
            {
                if (animalType == "Cat")
                {
                    Cat cat = new Cat(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                    Console.WriteLine(cat.ProduceSound());
                    animals.Add(cat);
                    cat.EatFood(foodTokens[0], int.Parse(foodTokens[1]));
                }
                else if (animalType == "Tiger")
                {
                    Tiger tiger = new (animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                    Console.WriteLine(tiger.ProduceSound());
                    animals.Add(tiger);
                    tiger.EatFood(foodTokens[0], int.Parse(foodTokens[1]));
                }
                else if (animalType == "Dog")
                {
                    Dog dog = new(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                    Console.WriteLine(dog.ProduceSound());
                    animals.Add(dog);
                    dog.EatFood(foodTokens[0], int.Parse(foodTokens[1]));
                }
                else if (animalType == "Mouse")
                {
                    Mouse mouse = new(animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                    Console.WriteLine(mouse.ProduceSound());
                    animals.Add(mouse);
                    mouse.EatFood(foodTokens[0], int.Parse(foodTokens[1]));
                }
                else if (animalType == "Owl")
                {
                    Owl owl = new(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));
                    Console.WriteLine(owl.ProduceSound());
                    animals.Add(owl);
                    owl.EatFood(foodTokens[0], int.Parse(foodTokens[1]));
                }
                else if (animalType == "Hen")
                {
                    Hen hen = new(animalTokens[1], double.Parse(animalTokens[2]), double.Parse(animalTokens[3]));
                    Console.WriteLine(hen.ProduceSound());
                    animals.Add(hen);
                    hen.EatFood(foodTokens[0], int.Parse(foodTokens[1]));
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}
