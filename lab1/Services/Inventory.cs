using lab1.Interfaces;
using System;
using System.Collections.Generic;

namespace lab1.Services
{
    public class Inventory
    {
        private List<IAnimal> _animals;
        private List<IEmployee> _employees;

        public Inventory(List<IAnimal> animals, List<IEmployee> employees)
        {
            _animals = animals;
            _employees = employees;
        }

        public void PrintReport()
        {
            Console.WriteLine("Animals in the Zoo:");
            foreach (var animal in _animals)
                Console.WriteLine($"- {animal.Name} ({animal.Species})");

            Console.WriteLine("\nEmployees:");
            foreach (var employee in _employees)
                Console.WriteLine($"- {employee.Name}, {employee.Role}");
        }
    }
}
