using lab1.Interfaces;

namespace lab1.Models
{
    public class Meat : IFood
    {
        public string Name => "Meat";
        public int Calories => 500;
    }
}
