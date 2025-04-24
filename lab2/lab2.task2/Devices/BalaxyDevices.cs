using lab2.task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2.Devices
{
    public class BalaxyLaptop : ILaptop
    {
        public void Describe() => Console.WriteLine("Balaxy Laptop: Versatile and stylish.");
    }

    public class BalaxyNetbook : INetbook
    {
        public void Describe() => Console.WriteLine("Balaxy Netbook: Compact with decent battery.");
    }

    public class BalaxyEBook : IEBook
    {
        public void Describe() => Console.WriteLine("Balaxy EBook: AMOLED display reader.");
    }

    public class BalaxySmartphone : ISmartphone
    {
        public void Describe() => Console.WriteLine("Balaxy Smartphone: Cutting-edge Android device.");
    }
}
