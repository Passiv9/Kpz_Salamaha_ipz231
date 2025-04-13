using lab1.Interfaces;
using System;

namespace lab1.Models
{
    public class Lion : IAnimal
    {
        public string Name { get; private set; }
        public string Species => "Lion";

        public Lion(string name)
        {
            Name = name;
        }

        public void Feed(IFood food)
        {
            Console.WriteLine($"{Name} the lion is eating {food.Name}.");
        }
    }
}
