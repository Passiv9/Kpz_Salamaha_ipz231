using System;
using RPGGame;

class Program
{
    static void Main()
    {
        IHero warrior = new Warrior();
        warrior = new Sword(warrior);
        warrior = new Armor(warrior);
        warrior = new Artifact(warrior);

        IHero mage = new Mage();
        mage = new Artifact(mage);
        mage = new Artifact(mage);

        IHero paladin = new Paladin();
        paladin = new Sword(paladin);
        paladin = new Armor(paladin);

        Console.WriteLine($"{warrior.GetDescription()} | Power: {warrior.GetPower()}");
        Console.WriteLine($"{mage.GetDescription()} | Power: {mage.GetPower()}");
        Console.WriteLine($"{paladin.GetDescription()} | Power: {paladin.GetPower()}");
    }
}
