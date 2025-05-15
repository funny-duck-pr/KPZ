using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Interfaces
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinimumPeriodMonths { get; }
        List<string> Channels { get; }
        string Features { get; }

        void ShowDetails();
    }
}