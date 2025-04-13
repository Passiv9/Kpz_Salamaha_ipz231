using lab1.Interfaces;
using System.Collections.Generic;
using lab1.Models;
using lab1.Services;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            IAnimal lion = new Lion("Simba");
            IEnclosure lionEnclosure = new Enclosure("Savannah");
            lionEnclosure.AddAnimal(lion);

            IEmployee keeper = new Zookeeper("John");

            var animals = lionEnclosure.GetAnimals();
            var employees = new List<IEmployee> { keeper };

            var inventory = new Inventory(animals, employees);
            inventory.PrintReport();
        }
    }
}
