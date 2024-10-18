using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects.Stock_Price_Notifier;

namespace Projects.Stock_Price_Notifier
{
    internal class App
    {
        static public void Run()
        {
            StockSubscriber Subscriber1 = new StockSubscriber("Ahmed");
            StockSubscriber Subscriber2 = new StockSubscriber("Mohammed");

            Stock.PriceChanged += Subscriber1.OnPriceChanged;
            Stock.PriceChanged += Subscriber2.OnPriceChanged;
            Stock st = new Stock("Iphone", 1562.00m);
            Stock.UpdatePrice(155.00m);
            
            Stock.UpdatePrice(160.00m);                    
        }
    }
}
