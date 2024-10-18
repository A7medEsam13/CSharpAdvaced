using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Stock_Price_Notifier
{
    public class StockSubscriber
    {
        private string SubscriberName;
        public StockSubscriber(string SubscriberName)
        {
            this.SubscriberName = SubscriberName;
        }

        public void OnPriceChanged(string Sympol,decimal OldPrice,decimal NewPrice)
        {
            Console.WriteLine($"{SubscriberName} - {Sympol} Price changed from {OldPrice:c} to {NewPrice:c}");
        }
    }
}
