using lab2.task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2.Devices
{
    public class KiaomiLaptop : ILaptop
    {
        public void Describe() => Console.WriteLine("Kiaomi Laptop: Budget-friendly and powerful.");
    }

    public class KiaomiNetbook : INetbook
    {
        public void Describe() => Console.WriteLine("Kiaomi Netbook: Affordable mobility.");
    }

    public class KiaomiEBook : IEBook
    {
        public void Describe() => Console.WriteLine("Kiaomi EBook: Simple and efficient.");
    }

    public class KiaomiSmartphone : ISmartphone
    {
        public void Describe() => Console.WriteLine("Kiaomi Smartphone: Android powerhouse.");
    }
}
