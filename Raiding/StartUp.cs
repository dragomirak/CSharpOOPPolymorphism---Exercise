using Raiding.Models;

namespace Raiding;

public class StartUp
{
    static void Main()
    {
        List<BaseHero> raidGroup = new List<BaseHero>();

        int n = int.Parse(Console.ReadLine());
        while (raidGroup.Count < n)
        {
            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();
            if (heroType == "Druid")
            {
                Druid druid = new(heroName);
                raidGroup.Add(druid);
            }
            else if (heroType == "Paladin")
            {
                Paladin paladin = new(heroName);
                raidGroup.Add(paladin);
            }
            else if (heroType == "Rogue")
            {
                Rogue rogue = new(heroName);
                raidGroup.Add(rogue);
            }
            else if (heroType == "Warrior")
            {
                Warrior warrior = new(heroName);
                raidGroup.Add(warrior);
            }
            else
            {
                Console.WriteLine("Invalid hero!");
            }

        }

        int bossPower = int.Parse(Console.ReadLine());
        foreach (BaseHero hero in raidGroup)
        {
            Console.WriteLine(hero.CastAbility());
        }

        int raidGroupPower = raidGroup.Sum(x => x.Power);
        if (raidGroupPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }


    }
}
