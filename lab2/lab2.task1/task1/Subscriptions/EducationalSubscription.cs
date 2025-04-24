using System;
using System.Collections.Generic;
using lab2.task1.Interfaces;

namespace lab2.task1.Subscriptions
{
    internal class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee { get { return 5.99m; } }
        public int MinPeriodMonths { get { return 3; } }
        public List<string> Channels { get { return new List<string> { "Documentary", "Science", "Kids" }; } }
        public List<string> Features { get { return new List<string> { "Parental Control" }; } }

        public void DisplayInfo()
        {
            Console.WriteLine("Educational Subscription:");
            Console.WriteLine("  Monthly Fee: " + MonthlyFee + "$");
            Console.WriteLine("  Min Period: " + MinPeriodMonths + " months");
            Console.WriteLine("  Channels: " + string.Join(", ", Channels));
            Console.WriteLine("  Features: " + string.Join(", ", Features));
        }
    }
}
