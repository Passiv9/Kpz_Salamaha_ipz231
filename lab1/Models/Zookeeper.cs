using lab1.Interfaces;

namespace lab1.Models
{
    public class Zookeeper : IEmployee
    {
        public string Name { get; private set; }
        public string Role => "Zookeeper";

        public Zookeeper(string name)
        {
            Name = name;
        }
    }
}
