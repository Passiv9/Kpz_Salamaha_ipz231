using System;
using System.Collections.Generic;
using lab2.task1.Interfaces;

namespace lab2.task1.Subscriptions
{
    internal class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee { get { return 19.99m; } }
        public int MinPeriodMonths { get { return 6; } }
        public List<string> Channels { get { return new List<string> { "All Channels" }; } }
        public List<string> Features { get { return new List<string> { "4K Streaming", "Download", "Multiple Devices" }; } }

        public void DisplayInfo()
        {
            Console.WriteLine("Premium Subscription:");
            Console.WriteLine("  Monthly Fee: " + MonthlyFee + "$");
            Console.WriteLine("  Min Period: " + MinPeriodMonths + " months");
            Console.WriteLine("  Channels: " + string.Join(", ", Channels));
            Console.WriteLine("  Features: " + string.Join(", ", Features));
        }
    }
}
