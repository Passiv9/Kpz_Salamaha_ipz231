using System;
using lab2.task1.Interfaces;

namespace lab2.task1.Creators
{
    internal class ManagerCall : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            Console.WriteLine("Subscription ordered via call with manager...");
            return new WebSite().CreateSubscription(type);
        }
    }
}
