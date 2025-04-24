using lab2.task1.Creators;
using lab2.task1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISubscriptionCreator website = new WebSite();
            ISubscriptionCreator mobile = new MobileApp();
            ISubscriptionCreator call = new ManagerCall();

            ISubscription sub1 = website.CreateSubscription("Domestic");
            ISubscription sub2 = mobile.CreateSubscription("Educational");
            ISubscription sub3 = call.CreateSubscription("Premium");

            sub1.DisplayInfo();
            Console.WriteLine();

            sub2.DisplayInfo();
            Console.WriteLine();

            sub3.DisplayInfo();
        }
    }
}
