using lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        void Feed(IFood food);
    }
}

