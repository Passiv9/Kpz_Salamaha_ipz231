using System;
using System.Collections.Generic;
using lab2.task1.Interfaces;

namespace lab2.task1.Subscriptions
{
    internal class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee { get { return 9.99m; } }
        public int MinPeriodMonths { get { return 1; } }
        public List<string> Channels { get { return new List<string> { "News", "Sports", "Entertainment" }; } }
        public List<string> Features { get { return new List<string> { "Basic Support" }; } }

        public void DisplayInfo()
        {
            Console.WriteLine("Domestic Subscription:");
            Console.WriteLine("  Monthly Fee: " + MonthlyFee + "$");
            Console.WriteLine("  Min Period: " + MinPeriodMonths + " months");
            Console.WriteLine("  Channels: " + string.Join(", ", Channels));
            Console.WriteLine("  Features: " + string.Join(", ", Features));
        }
    }
}
