using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Stock_Price_Notifier
{
    public class Stock
    {
        static public string Sympol { set; get; }
        static public decimal Price;
        public delegate void StockPriceChangedEventHandler(string Sympol, decimal OldPrice, decimal NewPrice);
        static public event StockPriceChangedEventHandler PriceChanged;
        public Stock(string Sympol, decimal Price)
        {
            Stock.Sympol = Sympol;
            Stock.Price = Price;
        }

        static public void UpdatePrice(decimal NewPrice)
        {
            if(NewPrice != Price)
            {
                decimal OldPrice = Price;
                Price = NewPrice;
                if(PriceChanged != null)
                {
                    PriceChanged(Sympol,OldPrice, NewPrice);
                }
            }
        }

    }
}
