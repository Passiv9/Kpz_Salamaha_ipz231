using lab2.task5;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        CharacterDirector director = new CharacterDirector();

        Character hero = director.CreateDreamHero();
        Character enemy = director.CreateEvilEnemy();

        hero.DisplayInfo();
        enemy.DisplayInfo();
    }
}
