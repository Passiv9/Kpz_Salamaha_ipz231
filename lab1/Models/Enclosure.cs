using lab1.Interfaces;
using System.Collections.Generic;

namespace lab1.Models
{
    public class Enclosure : IEnclosure
    {
        private List<IAnimal> _animals = new List<IAnimal>();
        public string Type { get; private set; }

        public Enclosure(string type)
        {
            Type = type;
        }

        public void AddAnimal(IAnimal animal)
        {
            _animals.Add(animal);
        }

        public List<IAnimal> GetAnimals() => _animals;
    }
}
