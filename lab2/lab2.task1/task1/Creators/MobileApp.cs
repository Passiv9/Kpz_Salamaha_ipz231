using System;
using lab2.task1.Interfaces;

namespace lab2.task1.Creators
{
    internal class MobileApp : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Creating via Mobile App...");
            return new WebSite().CreateSubscription(type);
        }
    }
}
