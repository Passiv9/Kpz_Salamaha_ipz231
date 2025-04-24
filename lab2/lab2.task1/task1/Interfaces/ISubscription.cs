using System.Collections.Generic;

namespace lab2.task1.Interfaces
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinPeriodMonths { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
        void DisplayInfo();
    }
}
