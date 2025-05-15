using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;
using Task1.Subscriptions;

namespace Task1.Creators
{
    public class WebSite : SubscriptionCreator
    {
        public override ISubscription CreateSubscription()
        {
            return new DomesticSubscription();
        }
    }
}