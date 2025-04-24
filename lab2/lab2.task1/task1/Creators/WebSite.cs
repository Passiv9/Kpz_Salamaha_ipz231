using System;
using lab2.task1.Interfaces;
using lab2.task1.Subscriptions;

namespace lab2.task1.Creators
{
    internal class WebSite : ISubscriptionCreator
    {
        public ISubscription CreateSubscription(string type)
        {
            if (type == "Domestic")
                return new DomesticSubscription();
            if (type == "Educational")
                return new EducationalSubscription();
            if (type == "Premium")
                return new PremiumSubscription();

            throw new ArgumentException("Invalid subscription type");
        }
    }
}
