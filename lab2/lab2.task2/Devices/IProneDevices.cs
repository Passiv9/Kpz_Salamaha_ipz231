using lab2.task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2.Devices
{
    public class IProneLaptop : ILaptop
    {
        public void Describe() => Console.WriteLine("IProne Laptop: High-end performance.");
    }

    public class IProneNetbook : INetbook
    {
        public void Describe() => Console.WriteLine("IProne Netbook: Lightweight and compact.");
    }

    public class IProneEBook : IEBook
    {
        public void Describe() => Console.WriteLine("IProne EBook: Retina display reader.");
    }

    public class IProneSmartphone : ISmartphone
    {
        public void Describe() => Console.WriteLine("IProne Smartphone: iOS-based flagship.");
    }
}
