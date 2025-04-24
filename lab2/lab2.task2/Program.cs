using lab2.task2.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFactory(new IProneFactory());
            Console.WriteLine();
            TestFactory(new KiaomiFactory());
            Console.WriteLine();
            TestFactory(new BalaxyFactory());
        }

        static void TestFactory(IDeviceFactory factory)
        {
            Console.WriteLine($"--- Testing {factory.GetType().Name} ---");
            factory.CreateLaptop().Describe();
            factory.CreateNetbook().Describe();
            factory.CreateEBook().Describe();
            factory.CreateSmartphone().Describe();
        }
    }
}
